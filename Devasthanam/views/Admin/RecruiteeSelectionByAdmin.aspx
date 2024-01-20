<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="RecruiteeSelectionByAdmin.aspx.cs" Inherits="Devasthanam.views.Admin.RecruiteeSelectionByAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/RecruiteeSelectionByAdmin.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.11.5/css/jquery.dataTables.min.css">
    <script type="text/javascript" src="https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js"></script>
    <link href="../../StyleSheets/RecruiteeSelectionByAdmin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <nav>
        <ul>
            <li>
                <img src="../../Image/home.jpg" id="home" />
                   <a href="Admin.aspx">Home</a>
            </li>
            <li>
                <img src="../../Image/call.jpg" id="contact" />
                <a href="../UserHome/ContactUs.aspx">Contact Us</a>
            </li>
            <li>
               <img src="../../Image/logout.jpg" id="logout" onclick="logout();" />
              <a href="../Signup/LoginPage.aspx" onclick="logout();">Log out</a>
            </li>
        </ul>
    </nav>
    <div class="data">
   <table id="Data1" class="display" ">
    <thead>
        <tr id="colName">
            <th>Name</th>
            <th>SurName</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Gender</th>
            <th>DOB</th>
            <th>City</th>
            <th>Address</th>
            <th>Qualification</th>
            <th>Percentage</th>
            <th>Select Candidate</th>
        </tr>
    </thead>
    <tbody>
       
    </tbody>
</table>
   </div>
    </asp:Content>