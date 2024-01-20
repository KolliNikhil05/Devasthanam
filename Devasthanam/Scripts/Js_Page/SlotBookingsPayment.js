 function validation() {
    var bookingdate = $("#ContentPlaceHolder1_txtDate").val();
    var aadhar = $("#ContentPlaceHolder1_txtAadhar").val();
    var paymentmode = $("input[name='payment']:checked").val();
    var upi = $("#txtUpi").val();
    if (paymentmode == null || paymentmode === "") {
        alert("Please select a Payment Mode.");
        return false;
    }
    if (paymentmode === "upi" && (upi == null || upi === "")) {
        alert("Please Enter UPI");
        $("#txtUpi").focus();
        return false;
    }

    var data = {
        aadhar: aadhar,
        bookingdate : bookingdate
    };

    $.ajax({
        type: "POST",
        url: "SlotBookingsPayment.aspx/SlotBookingPaymentInsert",
        data: JSON.stringify(data),
        datatype: "json",
        contentType: "application/json",
        success: function (res) {
            try {
                var obj = JSON.parse(res.d);
                if (obj[0] != null) {
                    if (obj[0].FLAG == 0) {
                        alert(obj[0].MSG);                
                    } else if (obj[0].FLAG == 1) {
                        alert(obj[0].MSG);
                        window.location = "TicketDownload.aspx";
                    } else if (obj[0].FLAG == 2) {
                        alert(obj[0].MSG);
                    }
                }
            } catch (e) {
                console.log("Actual response:", res);
                alert("Error parsing JSON response. See console for details.");
            }
        },

        error: function (err) {
            alert(err);
        }
    });

}


function upihide() {
    $("#upiInput").show();
    $("#qrImage").hide();
}

function upicheck() {
    $("#qrImage").show();
    $("#upiInput").hide();

}

function allowNumbersAndSpaces(event) {
    // Allow numbers (0-9) and spaces (key code 32)
    var charCode = event.which || event.keyCode;
    return (charCode >= 48 && charCode <= 57) || charCode === 32;
}


function logout() {

    $.ajax({
        type: "POST",
        url: "SlotBookingsPayment.aspx/Logout",
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




 
