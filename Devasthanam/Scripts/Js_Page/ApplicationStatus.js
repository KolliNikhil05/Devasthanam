function checkStatus() {
    var phone = $("#ContentPlaceHolder1_txtPhone").val();

    $.ajax({
        type: "POST",
        url: "ApplicationStatus.aspx/GetStatusData",
        data: JSON.stringify({ phone: phone }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var parsedData = JSON.parse(response.d);

            if (parsedData.Table1[0].FLAG === 1) {
                var rowData = parsedData.Table[0];
                $("#ContentPlaceHolder1_lblName").text(rowData.uName);
                $("#ContentPlaceHolder1_lblSurName").text(rowData.SurName);
                $("#ContentPlaceHolder1_lblPhone").text(rowData.Phone);
                $("#ContentPlaceHolder1_lblEmail").text(rowData.Email);
                $("#ContentPlaceHolder1_lblGender").text(rowData.Gender);
                $("#ContentPlaceHolder1_lblPayment").text(rowData.Payment);
                $("#ContentPlaceHolder1_lblQualified").text(rowData.Qualified);
                $("#ContentPlaceHolder1_letter").show();

                if (rowData.Qualified === 'Y') {
                    $(".download").show();
                }
            }
            else if (parsedData.Table1[0].FLAG === 0)
            {
                alert(parsedData.Table1[0].MSG);
            }
        },

        error: function (error) {
            console.log(error);
        }
    });
}

function logout() {

    $.ajax({
        type: "POST",
        url: "ApplicationStatus.aspx/Logout",
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