$(document).ready(function () {
    let currentMonthIndex = 0;
    let releaseData = [];
    let selectedDate = '';
    function renderCurrentMonth() {
        var bookingDates = [];
        var bookedSlots = [];
        $.ajax({
            type: "POST",
            url: "SlotBookings.aspx/SlotBookingGet",
            async: false,
            datatype: "json",
            contentType: "application/json",
            success: function (res) {
                var obj = JSON.parse(res.d);
                for (var i = 0; i < obj.length; i++) {
                    bookingDates.push(obj[i].BookingDate);
                    bookedSlots.push(obj[i].BookedSlotCount);
                }
            },
            error: function (err) {
                alert(err);
            }

        });

        const calendarDays = $("#calendarDays");
        calendarDays.empty();
        const currentMonthData = releaseData[currentMonthIndex];
        const serverMonth = currentMonthData.Month;
        const serverYear = currentMonthData.Year;
        const daysInMonth = new Date(serverYear, serverMonth, 0).getDate();
        const startingDay = new Date(serverYear, serverMonth - 1, 1).getDay();
        const table = $('<table class="calendar-table"></table>');
        const headerRow = $('<tr></tr>');
        // Add weekday headers
        const weekdays = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
        for (let i = 0; i < 7; i++) {
            headerRow.append('<th>' + weekdays[i] + '</th>');
        }
        table.append(headerRow);
        // Fill in the calendar days
        let currentDay = 1;
        for (let row = 0; row < 6; row++) {
            const tableRow = $('<tr></tr>');
            for (let col = 0; col < 7; col++) {
                if (row === 0 && col < startingDay) {
                    // Empty cells before the start of the month
                    tableRow.append('<td></td>');
                }
                else if (currentDay > daysInMonth)
                {
                    // Empty cells after the end of the month
                    tableRow.append('<td></td>');
                }
                else
                {
                    const isReleased = currentMonthData.IsReleased === 'Y' && currentMonthData.Day === currentDay;
                    const dayElement = $('<td class="day ' + (isReleased ? 'released' : '') + '" id="' + currentDay + '">' + currentDay + '</td>');
                    tableRow.append(dayElement);
                    const today = new Date();
                    const dayOfMonth = today.getDate();
                    const currentMonth = today.getMonth() + 1;
                    const currentYear = today.getFullYear();

                    if (currentYear <= serverYear && currentMonth <= serverMonth && dayOfMonth > currentDay) {
                        dayElement.css('background-color', 'lightgray');
                        dayElement.css('border-bottom', '4px solid gray');
                    }
                    else if (currentYear <= serverYear && currentMonth <= serverMonth && dayOfMonth === currentDay) {
                        dayElement.css('background-color', 'rgb(13, 174, 232)');
                        dayElement.css('border-bottom', '4px solid rgb(0, 64, 148)');
                    }
                    else {
                        dayElement.css('background-color', 'lightgreen');
                        dayElement.css('border-bottom', '4px solid  darkgreen');
                    }

                    for (var i = 0; i < bookingDates.length; i++) {
                        var formattedCurrentDay = currentDay + '-' + (serverMonth < 10 ? '0' : '') + serverMonth + '-' + serverYear;

                        if (bookingDates[i] === formattedCurrentDay && bookedSlots[i] === 2) {
                            dayElement.css('background-color', 'rgb(246,190,0)');
                            dayElement.css('border-bottom', '4px solid rgb(139, 0, 0)');
                        }
                    }
                    for (var i = 0; i < bookingDates.length; i++) {
                        if (currentYear <= serverYear && currentMonth <= serverMonth && dayOfMonth > currentDay) {
                            dayElement.css('background-color', 'lightgray');
                            dayElement.css('border-bottom', '4px solid gray');
                        } else {
                            var formattedCurrentDay = currentDay + '-' + (serverMonth < 10 ? '0' : '') + serverMonth + '-' + serverYear;

                            if (bookingDates[i] === formattedCurrentDay && bookedSlots[i] === 3) {
                                dayElement.css('background-color', 'rgb(139,0,0)');
                                dayElement.css('border-bottom', '4px solid rgb(255,255,51)');
                                dayElement.css('color', 'white');
                            }
                        }
                    }


                    //change bg color selected date
                    var originalColor;
                    var lastSelectedDate;
                    dayElement.click(function () {
                        var currentDate = new Date();
                        currentDate.setHours(0, 0, 0, 0);  
                        var clickedDay = parseInt(dayElement.text(), 10);
                        var clickedMonth = serverMonth;
                        var clickedYear = serverYear;
                        var clickedDate = new Date(clickedYear, clickedMonth - 1, clickedDay);
                        clickedDate.setHours(0, 0, 0, 0);  
                        if (clickedDate < currentDate) {
                            return;
                        }
                        var isDateFound = false;
                        for (var i = 0; i < bookingDates.length; i++) {
                            var formattedCurrentDay = clickedDay + '-' + (clickedMonth < 10 ? '0' : '') + clickedMonth + '-' + clickedYear;
                            if (bookingDates[i] === formattedCurrentDay) {
                                if (bookedSlots[i] === 3) {
                                    return;
                                }
                                isDateFound = true;
                                var modifiedBookedCount = 3 - bookedSlots[i]  ;
                                $("#selectedDateLabel").text('' + formattedCurrentDay);
                                $("#selectedSlotsLabel").text('Has ' + modifiedBookedCount + ' ' +'Slots Remaining');
                                break;
                            }
                        }
                        if (!isDateFound) {
                            $("#selectedDateLabel").text('' + formattedCurrentDay);
                            $("#selectedSlotsLabel").text('Has 3 Slots Remaining');
                        }
                        if (lastSelectedDate) {
                            lastSelectedDate.css('background-color', originalColor);
                        }

                        originalColor = dayElement.css('background-color');
                        dayElement.css('background-color', 'rgb(0, 255, 255)');
                        lastSelectedDate = dayElement;

                        var serverDay = $(this).text();
                        selectedDate = serverDay + '-' + (serverMonth < 10 ? '0' : '') + serverMonth + '-' + serverYear;
                        $("#txtDate").val(selectedDate);
                    });


                    currentDay++;
                }
            }
            table.append(tableRow);
        }

        calendarDays.append(table);
    }


    function updateMonthDisplay() {
        const currentMonthData = releaseData[currentMonthIndex];
        const serverMonth = currentMonthData.Month;
        const serverYear = currentMonthData.Year;

        const currentMonth = new Date(Date.UTC(serverYear, serverMonth - 1, 1)).toLocaleString("default", { month: "long" });
        $("#Month").text(currentMonth + ' ' + serverYear);
    }

    function showNextMonth() {
        if (currentMonthIndex < releaseData.length - 1) {
            currentMonthIndex++;
            renderCurrentMonth();
            updateMonthDisplay();
        }
    }

    function showPrevMonth() {
        if (currentMonthIndex > 0) {
            currentMonthIndex--;
            renderCurrentMonth();
            updateMonthDisplay();
        }
    }

    $("#prev").click(showPrevMonth);
    $("#next").click(showNextMonth);

    $.ajax({
        type: "POST",
        url: "SlotBookings.aspx/GetCalendarData",
        data: JSON.stringify({ year: new Date().getFullYear(), month: new Date().getMonth() + 1 }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            releaseData = JSON.parse(data.d);
            if (releaseData.length > 0) {
                renderCurrentMonth();
                updateMonthDisplay();
            }
        },
        error: function (error) {
            console.log(error);
        }
    });
});


function bookTicket(event) {
    event.preventDefault();
    var date = $("#txtDate").val();
    var aadhar = $("#txtAadhar").val();

    if (date == null || date === "") {
        alert("Please Select a Date");
        $("#txtDate").focus();
        return false;
    }
    if (aadhar == null || aadhar === "") {
        alert("Please enter your Aadhar ID.");
        $("#txtAadhar").focus();
        return false;
    } else if (aadhar.length !== 12) {
        alert("Aadhar ID should be exactly 12 digits.");
        $("#txtAadhar").focus();
        return false;
    } else if (!aadhar.match(/^[9|8|7|6]\d/)) {
        alert("Aadhar number should start with 9, 8, 7, or 6.");
        $("#txtAadhar").focus();
        return false;
    } else if (!aadhar.match(/^\d+$/)) {
        alert("Aadhar ID should only contain digits.");
        $("#txtAadhar").focus();
        return false;
    }


    var data = {};
    data.bookingdate = date;
    data.aadhar = aadhar;

    $.ajax({
        type: "POST",
        url: "SlotBookings.aspx/SlotBookingInsert",
        data: JSON.stringify(data),
        datatype: "json",
        contentType: "application/json",
        success: function (res) {
            var obj = JSON.parse(res.d);
            if (obj[0] != null) {
                if (obj[0].FLAG == 0) {
                    alert(obj[0].MSG);
                }
                else if (obj[0].FLAG == 1) {
                    alert(obj[0].MSG);

                    window.location = "SlotBookingsPayment.aspx";
                }
            }
        },
        error: function (err) {
            alert(err);
        }
    });
}

function SlotCount() {
    $.ajax({
        type: "POST",
        url: "SlotBookings.aspx/SlotBookingGet",
        data: JSON.stringify(data),
        datatype: "json",
        contentType: "application/json",
        success: function (res) {
            var obj = JSON.parse(res.d);
        },
        error: function (err) {
            alert(err);
        }

    });
}




function onlyNumbers(evt) {
    var charcode = (evt.which) ? evt.which : evt.keyCode;
    if (charcode > 31 && (charcode < 48 || charcode > 57)) {
        evt.preventDefault();
    }
    return true;
}

function logout() {

    $.ajax({
        type: "POST",
        url: "SlotBookings.aspx/Logout",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function () {
            window.location.href = "../Signup/LoginPage.aspx";
        },
        error: function (xhr, status, error) {
            console.error(xhr.responseText);
        }
    });
}