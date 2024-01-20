function GetCandidates() {
    var editingRow = null;
    $.ajax({
        type: "POST",
        url: "JqueryDataTable.aspx/GetData",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var data = JSON.parse(response.d);
            var table = $('#Data1').DataTable({
                data: data,
                columns: [
                    { "data": "userId" },
                    { "data": "uName" },
                    { "data": "SurName" },
                    { "data": "Phone" },
                    { "data": "City" },
                    {
                        "render": function (data, type, row) {
                            return '<div class="btn-group">' +
                                '<button class="btnedit">Edit</button>' +
                                '<button class="btnupdate" style="display:none;">Update</button>' +
                                '<button class="btncancel" style="display:none;">Cancel</button>' +
                                '</div>';
                        },
                    },
                    {
                        "render": function (data, type, row) {
                            return '<button class="btndelete">Delete</button>';
                        },
                    }
                ],
                lengthMenu: [5],
                pageLength: 5,
                autoWidth: false,
            });
            $('#Data1 tbody').on('click', '.btnedit', function (e) {
                e.preventDefault();
                if (editingRow !== null) {
                    cancelEdit(editingRow);
                }
                var tr = $(this).closest('tr');
                var row = table.row(tr);
                //tr.find('td:not(:first-child):not(:last-child)').each(function () {
                //    var cell = $(this);
                //    if (!cell.index()) {
                //        return;
                //    }
                //    cell.data('original-value', cell.text());
                //    var originalContent = cell.text();
                //    cell.html('<input type="text" class="form-control" value="' + originalContent + '">');
                //});
                tr.find('td:not(:first-child):not(:last-child):not(:nth-last-child(2))').each(function () {
                    var cell = $(this);
                    cell.data('original-value', cell.text());
                    var originalContent = cell.text();
                    cell.html('<input type="text" class="form-control" value="' + originalContent + '">');
                });
                tr.find('.btnedit').hide();
                tr.find('.btnupdate').show();
                tr.find('.btncancel').show();
                editingRow = tr;
            });
            $('#Data1 tbody').on('click', '.btncancel', function (e) {
                e.preventDefault();
                var tr = $(this).closest('tr');
                tr.find('td').each(function () {
                    var cell = $(this);
                    var originalValue = cell.data('original-value');
                    cell.html(originalValue);
                });
                tr.find('.btnedit').show();
                tr.find('.btnupdate').hide();
                tr.find('.btncancel').hide();
                cancelEdit(tr);
            });
            $('#Data1 tbody').on('click', '.btnupdate', function (e) {
                e.preventDefault();
                var tr = $(this).closest('tr');//we can also use .parent('tr');
                var updatedUserId = tr.find('td:eq(0)').text();
                var updatedName = tr.find('td:eq(1) input').val();
                var updatedSurname = tr.find('td:eq(2) input').val();
                var updatedPhone = tr.find('td:eq(3) input').val();
                var updatedCity = tr.find('td:eq(4) input').val();
                $.ajax({
                    type: 'POST',
                    url: 'JqueryDataTable.aspx/UpdateData',
                    data: JSON.stringify({
                        userId: updatedUserId,
                        uName: updatedName,
                        SurName: updatedSurname,
                        Phone: updatedPhone,
                        City: updatedCity
                    }),
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function (response) {
                        alert("Updated Sucessfully");
                        var index = table.row(tr).index();
                        var newData = JSON.parse(response.d);
                        table.row(index).data(newData).draw();
                        table.clear();

                        // Add updated data to the table
                        var newData = JSON.parse(response.d);
                        table.rows.add(newData).draw();

                        editingRow = null;
                    },
                    error: function (error) {

                    }
                });
                tr.find('td').each(function () {
                    var cell = $(this);
                    var inputVal = cell.find('input').val();
                    cell.html(inputVal);
                });
                tr.find('.btnedit').show();
                tr.find('.btnupdate').hide();
                tr.find('.btncancel').hide();
                editingRow = null;
            });
            $('#Data1 tbody').on('click', '.btndelete', function (e) {
                e.preventDefault();
                var tr = $(this).closest('tr');
                var userId = tr.find('td:eq(0)').text();
                $.ajax({
                    type: 'POST',
                    url: 'JqueryDataTable.aspx/DeleteData',
                    data: JSON.stringify({
                        userId: userId,
                    }),
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function (response) {
                        alert("Deletion successfully");

                        tr.remove();
                    },
                    error: function (xhr, status, error) {
                        alert("Error occurred during deletion.");
                    }
                });
            });
        },
        error: function () {
            alert("Error fetching data.");
        }
    });
    //function reloadData() {
    //    $.ajax({
    //        type: "POST",
    //        url: "JqueryDataTable.aspx/GetData",
    //        contentType: "application/json; charset=utf-8",
    //        dataType: "json",
    //        success: function (response) {
    //            var data = JSON.parse(response.d);
    //            table.clear().rows.add(data).draw();
    //        },
    //        error: function () {
    //            alert("Error fetching data.");
    //        }
    //    });
    //}
    function cancelEdit(row) {
        row.find('td').each(function () {
            var cell = $(this);
            var originalValue = cell.data('original-value');
            cell.html(originalValue);
        });
        row.find('.btnedit').show();
        row.find('.btnupdate').hide();
        row.find('.btncancel').hide();
        editingRow = null;  
    }
}


//function reloadData() {
//    var editingRow = null;
//    $.ajax({
//        type: "POST",
//        url: "JqueryDataTable.aspx/GetData",
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (response) {
//            var data = JSON.parse(response.d);
//            var table = $('#Data1').DataTable({
//                data: data,
//                columns: [
//                    { "data": "userId" },
//                    { "data": "uName" },
//                    { "data": "SurName" },
//                    { "data": "Phone" },
//                    { "data": "City" },
//                    {
//                        "render": function (data, type, row) {
//                            return '<div class="btn-group">' +
//                                '<button class="btnedit">Edit</button>' +
//                                '<button class="btnupdate" style="display:none;">Update</button>' +
//                                '<button class="btncancel" style="display:none;">Cancel</button>' +
//                                '</div>';
//                        },
//                    },
//                    {
//                        "render": function (data, type, row) {
//                            return '<button class="btndelete">Delete</button>';
//                        },
//                    }
//                ],
//                lengthMenu: [5],
//                pageLength: 5,l
//                autoWidth: false,
//            });
//        },
//        error: function () {
//            alert("Error fetching data.");
//        }
//    });
//}



        


















