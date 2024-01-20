<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="SlotReleaseByAdmin.aspx.cs" Inherits="Devasthanam.views.Admin.SlotReleaseByAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/SlotReleaseByAdmin.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/SlotReleaseByAdmin.js"></script>


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

             <p class="blinking-marquee">*** Note: You Can Only Release the Current Next Month Slots Only ***</p>
 

      <div class="container">

          <h2>Release The Next Month Slots</h2>
          <button id="btnRelease"  onclick="Release();" type="button">Release Slots</button>
          <br />
 </div>
</asp:Content>
