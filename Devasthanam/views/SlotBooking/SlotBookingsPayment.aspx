<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="SlotBookingsPayment.aspx.cs" Inherits="Devasthanam.views.SlotBooking.SlotBookingsPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/SlotBookingsPayment.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/SlotBookingsPayment.js"></script>
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/JqueryDataTable.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
    <div class="container">
        <h3>Ticket Booking Payment</h3>
        <div class="payment">
            <div class="date">
                <label id="lblDate" for="txtDate">BookingDate:</label>
                <input type ="text" ID="txtDate" runat="server"  AutoComplete="off" placeholder="Enter Booking Date" readonly onkeypress="return allowNumbersAndSpaces(event);" />
            </div>
            <div class="aadhar">
                <label for="txtAadhar">Aadhar:</label>
              <input type ="text" ID="txtAadhar" runat="server" MaxLength="14" AutoComplete="off" placeholder="Enter Aadhar ID" readonly onkeypress="return allowNumbersAndSpaces(event);" />
                <br />
            </div>
            <label>Payment Mode:</label>
            <input type="radio" name="payment" id="upi" value="upi" onclick="upihide()" />
            <label for="upi">UPI</label>
            <input type="radio" name="payment" id="qr" value="qr" onclick="upicheck()" />
            <label for="qr">QR Code</label>
            <br />
            <div id="upiInput" style="display: none">
                <label for="txtUpi">Enter UPI:</label>
                <input type="text" id="txtUpi" maxlength="10"  autocomplete="off" name="txtUpi" onkeypress="return onlyNumbers(event);" placeholder="Enter UPI ID"/>
            </div>
            <div id="qrImage" style="display: none">
                <img src="../../Image/qr.png" id="qrimg" />
            </div>
            <br />
            <button id="pay" onclick="return validation();" type="button">Pay</button>
        </div>
    </div>
</asp:Content>
