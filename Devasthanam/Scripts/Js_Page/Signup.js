function SignupValidation() {
    var phone = $("#txtPhone").val();
    var password = $("#loginPswd").val();
    var confirmPassword = $("#loginCPswd").val();

    // Phone number validation
    if (phone === null || phone === "") {
        alert("Please enter your Phone number.");
        $("#txtPhone").focus();
        return false;
    } else if (phone.length !== 10) {
        alert("Mobile Number should be exactly 10 digits.");
        $("#txtPhone").focus();
        return false;
    } else if (!phone.match(/^[6-9]\d/)) {
        alert("Phone number should start with 6, 7, 8, or 9.");
        $("#txtPhone").focus();
        return false;
    } else if (!phone.match(/^\d+$/)) {
        alert("Mobile number should only contain digits.");
        $("#txtPhone").focus();
        return false;
    }

    // Password validation
    if (password === null || password === "") {
        alert("Please enter a password.");
        $("#loginPswd").focus();
        return false;
    } else if (password.length < 8) {
        alert("Password should contain at least 8 characters.");
        $("#loginPswd").focus();
        return false;
    } else if (!password.match(/[A-Z]/)) {
        alert("Password must contain an uppercase character.");
        $("#loginPswd").focus();
        return false;
    } else if (!password.match(/[a-z]/)) {
        alert("Password must contain a lowercase character.");
        $("#loginPswd").focus();
        return false;
    } else if (!password.match(/\d/)) {
        alert("Password must contain a digit.");
        $("#loginPswd").focus();
        return false;
    } else if (!password.match(/[!@#$%^&*]/)) {
        alert("Password must contain a special character.");
        $("#loginPswd").focus();
        return false;
    }

    // Confirm password validation
    if (confirmPassword === null || confirmPassword === "") {
        alert("Please enter Confirm password.");
        $("#loginCPswd").focus();
        return false;
    } else if (password !== confirmPassword) {
        alert("Password and confirm password do not match.");
        $("#loginCPswd").focus();
        return false;
    }
    else {
       
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        url: "Signup.aspx/InsertSignUpData",
        async: false,
        data: "{'phone':'" + phone + "','password':'" + password + "','confirmPassword':'" + confirmPassword + "'}",
        contentType: "application/json",
       
        success: function (res) {
            var obj = JSON.parse(res.d);
            if (obj[0].FLAG == 0)
            {
                alert("ALREADY REGISTERED");
            }
            else if (obj[0].FLAG == 1) {


                /* window.location.href = "../Test/OtpModalPopUp.aspx";*/
                alert("REGISTERED SUCCESSFULLY");

                window.location.href = "LoginPage.aspx";
                var form = $("#form");
                form[0].reset();
            }
        },
        error: function (err) {
            alert("Something went wrong! please Try Again Later");
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


function noSpaces(evt) {
    var charcode = (evt.which) ? evt.which : evt.keyCode;
    if (charcode === 32) {
        evt.preventDefault();
    }
    return true;
}
