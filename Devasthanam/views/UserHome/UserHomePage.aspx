<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="Devasthanam.UserHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserHomePage</title>
    <link href="../../StyleSheets/UserHome.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/UserHomePage.js"></script>
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/jqueryCdn.js"></script>
    <script>
        $(document).ready(function () {
            $('#profile').click(function () {
                $('#profile-slider').slideToggle();
            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="logo">
            <img src="../../Image/Master.jpg" id="masterpage" />
        </div>
        <nav>
            <ul>
                <li>
                    <img src="../../Image/home.jpg" id="home" />
                    <a href="UserHomePage.aspx">Home</a>
                </li>
                <li>
                    <img src="../../Image/call.jpg" id="contact" />
                    <a href="ContactUs.aspx">Contact us</a>
                </li>
                <li>
                    <img src="../../Image/logout.jpg" id="logout" onclick="logout();" />
                    <a href="../Signup/LoginPage.aspx" onclick="logout();">Log out</a>
                </li>
                <li>
                    <div class="con1">
                        <img src="../../Image/Profile.jpg" id="profileimg" />
                        <h5 id="profile">Profile</h5>
                        </div>
                        <div id="profile-slider" style="display: none;">
                            <p id="user" runat="server">User : </p>
                            <p>More profile details</p>
                    </div>
                </li>
            </ul>
        </nav>
        <div class="data">
            <div class="container1">
                <h2 id="con1Name">Recruitee</h2>
                <ul>
                    <li>
                        <a href="../Recruitment/RecruiteeRegistration.aspx">Recruitee Registration</a>
                    </li>
                    <li>
                        <a href="../Recruitment/RecruiteePayment.aspx">Registration Payment</a>
                    </li>
                    <li>
                        <a href="../Recruitment/ApplicationStatus.aspx">Application Status</a>
                    </li>


                </ul>
            </div>
            <div class="container2">
                <h2 id="con2Name">Devotee</h2>
                <ul>
                    <li>
                        <a href="../SlotBooking/SlotBookings.aspx">Sarva Darshan Ticket Booking</a>
                    </li>
                </ul>
            </div>
            <div class="container3">
                <h2 id="con3Name">About</h2>
                <ul>
                    <li>
                        <a href="https://www.onlinesbi.sbi/sbicollect/icollecthome.htm?corpID=368963">E-hundi</a>
                    </li>
                    <li>
                        <a href="https://en.wikipedia.org/wiki/Varaha_Lakshmi_Narasimha_temple,_Simhachalam">History</a>
                    </li>
                    <li>
                        <a href="Timings.aspx">Timings</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class="footer">
            <p id="footer1">Copyright © 2023-2025 Simhachala Devasthanams, All Rights Reserved</p>
            <p id="footer2">Devoloped by Nikhil</p>
        </div>
    </form>
</body>
</html>
