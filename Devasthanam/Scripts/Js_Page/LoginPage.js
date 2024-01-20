function Login() {
    var phone = $("#txtPhone").val();
    var password = $("#loginPswd").val();
    // Phone number validation
    if (phone === null || phone === "") {
        alert("Please enter your Phone number.");
        $("#txtPhone").focus();
        return false;
    }
    if (password === null || password === "") {
        alert("Please enter a password.");
        $("#loginPswd").focus();
        return false;
    }
    var logindata = {
        phone: $("#txtPhone").val(),
        password: $("#loginPswd").val()
    }

    $.ajax({
        type: "POST",
        url: "LoginPage.aspx/GetLogin ",
        data: JSON.stringify({ LoginValues: logindata }),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {
            var data = JSON.parse(response.d);
            if (data != null) {
                if (data["Table"][0].FLAG == 1) {
                    alert(data["Table"][0].MSG);
                    if (data["Table1"][0].role == "1") {
                        window.location = "../Admin/Admin.aspx";
                    }
                    else if (data["Table1"][0].role == "2") {

                        window.location = "../UserHome/UserHomePage.aspx"; 
                    }
                }
                else if (data["Table"][0].FLAG == "2")
                {
                    alert(data["Table"][0].MSG);
                }
                else {
                    alert(data["Table"][0].MSG);
                }
            }
        },
        error: function (error) {
            alert(error);
        },

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