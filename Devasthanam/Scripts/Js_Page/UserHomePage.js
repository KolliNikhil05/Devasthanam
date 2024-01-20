
function logout() {
 
    $.ajax({
        type: "POST",
        url: "UserHomePage.aspx/Logout", 
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
