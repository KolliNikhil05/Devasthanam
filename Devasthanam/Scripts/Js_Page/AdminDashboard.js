$(document).ready(function () {
    $.ajax({
        type: "POST",
        url: "AdminDashboard.aspx/CandidateDetails",
        dataType: "json",
        contentType: "application/json",
        success: function (response) {
            var data = JSON.parse(response.d);
            if (data != null && data != "") {
                $("#Registered").text(data['Table'][0].Recruitee_count);
                $("#Paymented").text(data['Table1'][0].Payment_count);
                $("#Selected").text(data['Table2'][0].Qualified_count);
                $("#Rejected").text(data['Table3'][0].Rejected_count);
            }
            else {
                alert("no data found");
            }

        },
        error: function () {
            alert("error");
        }
    });
})

function logout() {

    $.ajax({
        type: "POST",
        url: "AdminDashboard.aspx/Logout",
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
