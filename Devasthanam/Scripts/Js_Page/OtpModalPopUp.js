 $(document).ready(function () {
        $('#btnOtp').click(function () {
            var phoneNumber = $('#ContentPlaceHolder1_txtPhoneNumber').val();
            $('#ContentPlaceHolder1_txtPhoneNumber').text(phoneNumber);
        });
    });
function sendOTP() {
    var phone = $('#ContentPlaceHolder1_txtPhoneNumber').val();
    var otp =  "";

    var data = {
        phone: phone,
        sentOtp: otp
    };
    $.ajax({
        type: "POST",
        url: "OtpModalPopUp.aspx/OTP_Insert",
        data: JSON.stringify(data),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var result = JSON.parse(response.d);
            console.log(result);
        },
        error: function (err) {
            alert("Error: " + err.responseText);
        }
    });
}

function validateOTP() {
    var phone = $('#ContentPlaceHolder1_txtPhoneNumber').val();
    var otp = $('#txtOTP').val();
    var data = {
        Phone: phone,
        SentOtp: otp
    };

    $.ajax({
        type: "POST",
        url: "OtpModalPopUp.aspx/OTPValidate",
        data: JSON.stringify(data),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var result = JSON.parse(response.d);
            if (result[0].FLAG == 1) {
                alert(result[0].MSG);
                window.location = "../Recruitment/RecruiteePayment.aspx";
               
            } else {
                alert(result[0].MSG);
            }
        },
        error: function (err) {
            console.error("Error validating OTP: " + err.statusText);
        }
    });
}

