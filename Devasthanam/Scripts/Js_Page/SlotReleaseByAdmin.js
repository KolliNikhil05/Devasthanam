 function Release()
{
  $.ajax({
        type: "POST",
        dataType: "json",
        url: "SlotReleaseByAdmin.aspx/SlotRelease",
        async: false,
        data: "",
        contentType: "application/json",

        success: function (res) {
            var obj = JSON.parse(res.d);
            if (obj[0].FLAG == 0) {
                alert(obj[0].MSG);

                /*alert("ALREADY REGISTERED");*/
            }
            else if (obj[0].FLAG == 1) {
                alert(obj[0].MSG);

               /* alert("REGISTERED SUCCESSFULLY");*/
                window.location.href = "Admin.aspx";       
            }
        },
        error: function (err) {
            alert("Something went wrong! please Try Again Later");
        }
  });
}


function logout() {

    $.ajax({
        type: "POST",
        url: "SlotReleaseByAdmin.aspx/Logout",
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
