function validation() {
    var phone = $("#txtPhone").val();
    var paymentmode = $("input[name='payment']:checked").val();
    var upi = $("#txtUpi").val();

    if (phone == null || phone === "") {
        alert("Please enter your Phone number.");
        $("#txtPhone").focus();
        return false;
    } else if (phone.length !== 10) {
        alert("Mobile Number should be exactly 10 digits.");
        $("#txtPhone").focus();
        return false;
    } else if (!phone.match(/^[9|8|7|6]\d/)) {
        alert("Phone number should start with 9, 8, 7, or 6.");
        $("#txtPhone").focus();
        return false;
    } else if (!phone.match(/^\d+$/)) {
        alert("Mobile number should only contain digits.");
        $("#txtPhone").focus();
        return false;
    }
    if (paymentmode == null || paymentmode === "") {
        alert("Please select a Payment Mode.");
        return false;
    }
    if (paymentmode === "upi" && (upi == null || upi === "")) {
        alert("Please Enter UPI");
        $("#txtUpi").focus();
        return false;
    }

    var data = {};
    data.phone = phone;

    $.ajax({
        type: "POST",
        url: "CandidatePayment.aspx/RecruiteePaymentInsert",
        data: JSON.stringify({ data: data }),
        datatype: "json",
        async: false,
        contentType: "application/json",
        success: function (res) {
            var obj = JSON.parse(res.d);
            if (obj[0] != null) {
                if (obj[0].FLAG === 2) {
                    alert(obj[0].MSG);
                    windows.location = "RecruiteeRegistration.aspx";
                }
                if (obj[0].FLAG === 1) {
                    alert(obj[0].MSG);
                    location.window.href = "RecruiteeRegistration.aspx";

                }
                else if (obj[0].FLAG === 0) {
                    alert(obj[0].MSG);
                    location.window.href = "RecruiteeRegistration.aspx";

                }
            }
        },
        error: function (err) {
            alert(err);
        }
    });

}


function onlyNumbers(evt) {
    var charcode = (evt.which) ? evt.which : evt.keyCode;
    if (charcode >= 48 && charcode <= 57) {
        var inputValue = $("#txtPhone").val();
        if (inputValue.length === 0 && (charcode < 54 || charcode > 57)) {
            evt.preventDefault();
        }
    } else {
        evt.preventDefault();
    }

    return true;
}

function upihide() {
    $("#upiInput").show();
    $("#qrImage").hide();
}

function upicheck() {
    $("#qrImage").show();
    $("#upiInput").hide();

}