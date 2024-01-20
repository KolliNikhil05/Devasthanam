 

$(document).ready(function () {
    let currentMonthIndex = 0;
    let releaseData = [];

    function renderCurrentMonth() {
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
                } else if (currentDay > daysInMonth) {
                    // Empty cells after the end of the month
                    tableRow.append('<td></td>');
                } else {
                    // Cells for the actual days
                    const isReleased = currentMonthData.IsReleased === 'Y' && currentMonthData.Day === currentDay;
                    const dayElement = $('<td class="day ' + (isReleased ? 'released' : '') + '">' + currentDay + '</td>');
                    tableRow.append(dayElement);
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
        url: "ex.aspx/GetCalendarData",
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




/*****multiple months working*/
//$(document).ready(function () {
//    const now = new Date();
//    let currentMonthView = new Date();
//    renderCalendar(currentMonthView);

//    function renderCalendar(date) {
//        const calendarDays = $("#calendarDays");
//        calendarDays.empty();

//        $.ajax({
//            type: "POST",
//            url: "ex.aspx/GetCalendarData",
//            data: JSON.stringify({ year: date.getFullYear(), month: date.getMonth() + 1 }),
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (data) {
//                const releaseData = JSON.parse(data.d);

//                // Iterate through each month in the server data
//                releaseData.forEach(function (monthData) {
//                    const serverMonth = monthData.Month;
//                    const serverYear = monthData.Year;

//                    const currentMonth = new Date(Date.UTC(serverYear, serverMonth - 1, 1)).toLocaleString("default", { month: "long" });
//                    const monthContainer = $('<div class="month-container"></div>');
//                    monthContainer.append('<h3>' + currentMonth + ' ' + serverYear + '</h3>');

//                    const daysInMonth = new Date(serverYear, serverMonth, 0).getDate();
//                    const startingDay = new Date(serverYear, serverMonth - 1, 1).getDay();

//                    for (let i = 0; i < startingDay; i++) {
//                        monthContainer.append('<div class="day"></div>');
//                    }

//                    for (let day = 1; day <= daysInMonth; day++) {
//                        const isReleased = monthData.IsReleased === 'Y' && monthData.Day === day;

//                        const dayElement = $('<div class="day ' + (isReleased ? 'released' : '') + '">' + day + '</div>');
//                        monthContainer.append(dayElement);
//                    }

//                    calendarDays.append(monthContainer);
//                });
//            },
//            error: function (error) {
//                console.log(error);
//            }
//        });
//    }
//});














/****sigle month working*/
//$(document).ready(function () {
//    const now = new Date();
//    let currentMonthView = new Date();
//    renderCalendar(currentMonthView);

//    function renderCalendar(date) {
//        const calendarDays = $("#calendarDays");
//        calendarDays.empty();

//        $.ajax({
//            type: "POST",
//            url: "ex.aspx/GetCalendarData",
//            data: JSON.stringify({ year: date.getFullYear(), month: date.getMonth() + 1 }),
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (data) {
//                const releaseData = JSON.parse(data.d);

//                // Use the month and year from the server data
//                const serverMonth = releaseData[0].Month; // Assuming the first record contains the month
//                const serverYear = releaseData[0].Year; // Assuming the first record contains the year

//                const currentMonth = new Date(Date.UTC(serverYear, serverMonth - 1, 1)).toLocaleString("default", { month: "long" });
//                $("#currentMonth").text(currentMonth + " " + serverYear);

//                const daysInMonth = new Date(serverYear, serverMonth, 0).getDate();
//                const startingDay = new Date(serverYear, serverMonth - 1, 1).getDay();

//                for (let i = 0; i < startingDay; i++) {
//                    calendarDays.append('<div class="day"></div>');
//                }

//                for (let day = 1; day <= daysInMonth; day++) {
//                    const isReleased = releaseData.some(function (release) {
//                        return release.Month === serverMonth && release.Year === serverYear && release.IsReleased === 'Y' && release.Day === day;
//                    });

//                    const dayElement = $('<div class="day ' + (isReleased ? 'released' : '') + '">' + day + '</div>');
//                    calendarDays.append(dayElement);
//                }

//            },
//            error: function (error) {
//                console.log(error);
//            }
//        });
//    }
//});


 























/********************************************* */
//$(document).ready(function () {
//    const now = new Date();
//    let currentMonthView = new Date();
//    renderCalendar(currentMonthView);

//    function renderCalendar(date) {
//        const calendarDays = $("#calendarDays");
//        calendarDays.empty();
//        const currentMonth = date.toLocaleString("default", { month: "long" });
//        const currentYear = date.getFullYear();
//        $("#currentMonth").text(currentMonth + " " + currentYear);

//        $.ajax({
//            type: "POST",
//            url: "ex.aspx/GetCalendarData",
//            data: JSON.stringify({ year: currentYear, month: date.getMonth() + 1 }),
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            //success: function (data) {
//            //    const daysInMonth = new Date(currentYear, date.getMonth() + 1, 0).getDate();
//            //    const startingDay = new Date(currentYear, date.getMonth(), 1).getDay();

//            //    for (let i = 0; i < startingDay; i++) {
//            //        calendarDays.append('<div class="day"></div>');
//            //    }

//            //    for (let day = 1; day <= daysInMonth; day++) {
//            //        const dayElement = $('<div class="day">' + day + '</div>');
//            //        calendarDays.append(dayElement);
//            //    }

//            //},

//            success: function (data) {
//                const daysInMonth = new Date(currentYear, date.getMonth() + 1, 0).getDate();
//                const startingDay = new Date(currentYear, date.getMonth(), 1).getDay();

//                for (let i = 0; i < startingDay; i++) {
//                    calendarDays.append('<div class="day"></div>');
//                }

//                for (let day = 1; day <= daysInMonth; day++) {
//                    const dayElement = $('<div class="day">' + day + '</div>');
//                    const dayData = data.d.filter(function (item) {
//                        return item.Month === (date.getMonth() + 1) && item.Year === currentYear && item.Day === day;
//                    });

//                    // Check if data is available for the current day
//                    if (dayData.length > 0 && dayData[0].IsReleased) {
//                        dayElement.addClass('released'); // You can add a class or style for released days
//                    }

//                    calendarDays.append(dayElement);
//                }
//            },

//            error: function (error) {
//                console.log(error);
//            }
//        });
//    }
//});
