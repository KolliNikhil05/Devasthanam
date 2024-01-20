<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="SlotBookings.aspx.cs" Inherits="Devasthanam.views.SlotBooking.SlotBookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Scripts/Js_Page/jqueryCdn.js"></script>
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/SlotBookings.js"></script>
    <link href="../../StyleSheets/SlotBookings.css" rel="stylesheet" />

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
        <div class="container1">
            <div id="calendar">
                <div class="header">
                    <span id="prev">&#9665;</span>
                    <span id="Month">Month</span>
                    <span id="next">&#9655;</span>
                </div>
                <div class="days" id="calendarDays"></div>
                <br />
                <br />
            </div>
        </div>
        <div class="container2">
            <div class="header2"></div>
            <div class="date">
                <label id="lblDate" for="txtDate">Date:</label>
                <input type="text" id="txtDate" placeholder="Booking Date" readonly /><br />
            </div>
            <div class="aadhar">
                <label id="lblAadhar" for="txtAadhar">Aadhar ID:</label>
                <input type="text" id="txtAadhar" placeholder="Aadhar ID" maxlength="12" autocomplete="off" onkeypress="return onlyNumbers(event);" /><br />
            </div>
            <label id="selectedDateLabel"></label>
            <label id="selectedSlotsLabel"></label>
            <div class="book">
                <button id="btnBook" onclick="return bookTicket(event);">Book Ticket</button>
            </div>
        </div>
    </div>
    <div class="container3">
        <div class="green">
            <label id="lblgreen">Available</label>
        </div>
        <div class="red">
            <label id="lblred">AlreadyBooked</label>
        </div>
        <div class="yellow">
            <label id="lblyellow">FastFilling</label>
        </div>
        <div class="blue">
            <label id="lblblue">Today</label>
        </div>
        <div class="gray">
            <label id="lblgray">PastDays</label>
        </div>
        <div class="seagreen">
            <label id="lblseagreen">Selected</label>
        </div>
    </div>
</asp:Content>

















