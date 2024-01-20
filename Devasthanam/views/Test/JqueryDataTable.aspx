<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/Test.Master" AutoEventWireup="true" CodeBehind="JqueryDataTable.aspx.cs" Inherits="Devasthanam.views.Test.JqueryDataTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
 <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
 <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.11.5/css/jquery.dataTables.min.css">
 <script type="text/javascript" src="https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js"></script>
    <script src="../../Scripts/Js_Page/JqueryDataTable.js"></script>
    <link href="../../StyleSheets/JqueryDataTable.css" rel="stylesheet" />
    <script>
        $(document).ready(function () {
            GetCandidates();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="data">
<table id="Data1" class="display" ">
    <thead>
        <tr id="colName">
            <th>User ID</th>
            <th>Name</th>
            <th>SurName</th>
            <th>Phone</th>
            <th>City</th>
            <th>Action</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>
   </div>
</asp:Content>
