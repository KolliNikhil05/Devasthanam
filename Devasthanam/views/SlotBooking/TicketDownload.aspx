<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="TicketDownload.aspx.cs" Inherits="Devasthanam.views.SlotBooking.TicketDownload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/TicketDownload.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/TicketDownload.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="nav">
        <nav>
            <ul>
                <li>
                    <img src="../../Image/home.jpg" id="home" />
                    <a href="../UserHome/UserHomePage.aspx">Home</a>
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
    </div>
    <div class="container" id="assd" runat="server">
        <div class="con1">
            <h4>Special Darshan Entry Ticket</h4>
            <label id="id">Ticket ID : SMLM0561</label><br />
            <label>Booking Date : </label>
            <label id="date" runat="server"></label>
            <br />
            <label>Aadhar ID : </label>
            <label id="aadhar" runat="server"></label>
            <br />
            <label id="rate">Amount : ₹300/- only</label><br />
            <label id="paymentId">Payment ID : HDFC4106854</label><br />
        </div>
    </div>
    <asp:Button runat="server" ID="btnExport" Text="Download" OnClick="btnDownload" />
</asp:Content>
