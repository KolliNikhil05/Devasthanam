<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Devasthanam.views.Admin.AdminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/jqueryCdn.js"></script>
    <script src="../../Scripts/Js_Page/AdminDashboard.js"></script>
    <link href="../../StyleSheets/AdminDashboard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav>
        <ul>
            <li>
                <img src="../../Image/home.jpg" id="home" />
                <a href="Admin.aspx">Home</a>
            </li>
            <li>
                <img src="../../Image/logout.jpg" id="logout" onclick="logout();" />
                <a href="../Signup/LoginPage.aspx" onclick="logout();">Log out</a>
            </li>
        </ul>
    </nav>
    <div class="data">
        <div class="container1">
            <h2 id="con1Name">Registered Candidates</h2>
            <h1 id="Registered"></h1>
          <a href="RegisteredCandidateDetails.aspx" style="text-decoration: none; color: black;"  >Get Details</a>
            <h6 id="details"></h6>
        </div>
        <div class="container2">
            <h2 id="con2Name">Payment Succeded Candidates</h2>
            <h1 id="Paymented"></h1>
            <a href="PaymentDoneCandidateDetails.aspx" style="text-decoration: none; color: black;">Get Details</a>
        </div>
    </div>
     <div class="data2">
     <div class="container3">
         <h2 id="con3Name">Qualified Candidates</h2>
          <h1 id="Selected"></h1>
         <a href="QualifiedCandidateDetails.aspx" style="text-decoration: none; color: black;">Get Details</a>
         <h6></h6>
     </div>
     <div class="container4">
         <h2 id="con4Name">Rejected Candidates</h2>
          <h1 id="Rejected"></h1>
       <a href="RejectedCandidateDetails.aspx" style="text-decoration: none; color: black;" >Get Details</a>
     </div>
 </div>

</asp:Content>
