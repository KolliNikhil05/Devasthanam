<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="RecruiteePayment.aspx.cs" Inherits="Devasthanam.views.Recruitment.RecruiteePayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Scripts/Js_Page/RecruiteePayment.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <link href="../../StyleSheets/RecruiteePayment.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/jqueryCdn.js"></script>
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
        <h3>Payment</h3>
        <div class="payment">
            <label for="txtPhone">Phone:</label>
            <input type="text" id="txtPhone" name="txtPhone" autocomplete="off" onkeypress="return onlyNumbers(event);" maxlength="10" placeholder="Enter Phone Number" />
            <br />
            <label id="lblMode">Payment Mode:</label>
            <input type="radio" name="payment" id="upi" value="upi" onclick="upihide()" />
            <label for="upi">UPI</label>

            <input type="radio" name="payment" id="qr" value="qr" onclick="upicheck()" />
            <label for="qr">QR Code</label>
            <br />
            <div id="upiInput" style="display: none">
                <label for="txtUpi">Enter UPI:</label>
                <input type="text" id="txtUpi" maxlength="10" autocomplete="off" onkeypress="return onlyNumbers(event);" placeholder="Enter UPI ID" name="txtUpi" />
            </div>
            <div id="qrImage" style="display: none">
                <img src="../../Image/qr.png" id="qrimg" />
            </div>
            <br />
            <input type='button' id="pay" value='Pay Now' onclick="validation()"/>
        </div>
    </div>
</asp:Content>
