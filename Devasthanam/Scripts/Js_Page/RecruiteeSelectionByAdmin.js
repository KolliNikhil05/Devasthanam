$(document).ready(function () {
    var dataTableInstance;
    bind();


function bind() {
    $.ajax({
        type: "POST",
        url: "RecruiteeSelectionByAdmin.aspx/GetData",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var dataTable = JSON.parse(response.d);
            if (dataTableInstance) {
                dataTableInstance.destroy();
            }

            dataTableInstance = $('#Data1').DataTable({
                "autoWidth": false,
                "scrollX": true,
                data: dataTable,
                columns: [
                    { "data": "uName" },
                    { "data": "SurName" },
                    { "data": "Phone" },
                    { "data": "Email" },
                    { "data": "Gender" },
                    { "data": "DOB" },
                    { "data": "City" },
                    { "data": "UAddress" },
                    { "data": "Qualification" },
                    { "data": "UPercentage" },
                    {
                        "data": null,
                        "render": function (data, type, row) {
                            return '<button class="btnselect" data-phone="' + row.Phone + '">Select</button>';
                        }
                    }
                ],
                lengthMenu: [5],
                pageLength: 5
            });

            $('#Data1 tbody').on('click', '.btnselect', function (e) {
                e.preventDefault();
                var tr = $(this).closest('tr');
                var phone = $(this).data('phone');
                var confirmSelection = confirm("Do you want to select the user with ID " + phone + "?");
                if (confirmSelection) {
                    $.ajax({
                        type: 'POST',
                        url: 'RecruiteeSelectionByAdmin.aspx/Selection',
                        data: JSON.stringify({
                            phone: phone
                        }),
                        contentType: 'application/json; charset=utf-8',
                        dataType: 'json',
                        success: function (response) {
                            var obj = JSON.parse(response.d);
                            if (obj[0].FLAG == 0) {
                                alert(obj[0].MSG);
                                
                            }
                            else if (obj[0].FLAG == 1) {
                                alert(obj[0].MSG);
                                bind();
                            }
                            else if (obj[0].FLAG == 2) {
                                alert(obj[0].MSG);
                                
                            }

                        },
                        error: function (error) {
                            console.error("Error selecting candidate:", error);
                        }
                    });
                } else {

                }
            });
        },
        error: function () {
            alert("Error fetching data.");
        }
    });
}
});


function logout() {

    $.ajax({
        type: "POST",
        url: "RecruiteeSelectionByAdmin.aspx/Logout",
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