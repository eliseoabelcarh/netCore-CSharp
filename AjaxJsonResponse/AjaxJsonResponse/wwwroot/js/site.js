// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    LoadData();
    $("#btnSave").click(function () {
        //alert("dddsdadasdasddasda");
        var std = {};
        std.studentName = $("#StudentName").val();
        std.studentAddress = $("#StudentAddress").val();
        $.ajax({
            type: "POST",
            url: '@Url.Action("createStudent")',
            data: '{std: ' + JSON.stringify(std) + '}',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function () {
                alert("Data has been added successfully.");
                LoadData();
            },
            error: function () {
                alert("Error while inserting data");
            }
        });
        return false;
    });
});

function LoadData() {
    $("#tblStudent tbody tr").remove();
    $.ajax({
        type: 'POST',
        url: '@Url.Action("getStudent")',
        dataType: 'json',
        data: { id: '' },
        success: function (data) {
            var items = '';
            $.each(data, function (i, item) {
                var rows = "<tr>"
                    + "<td class='prtoducttd'>" + item.studentID + "</td>"
                    + "<td class='prtoducttd'>" + item.studentName + "</td>"
                    + "<td class='prtoducttd'>" + item.studentAddress + "</td>"
                    + "</tr>";
                $('#tblStudent tbody').append(rows);
            });
        },
        error: function (ex) {
            var r = jQuery.parseJSON(response.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);
        }
    });
    return false;
}