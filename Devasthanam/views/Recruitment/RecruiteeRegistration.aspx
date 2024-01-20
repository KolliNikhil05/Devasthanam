<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecruiteeRegistration.aspx.cs" Inherits="Devasthanam.RecruiteeRegistration" EnableEventValidation="true" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RecruiteeRegistration</title>
    <script src="../../Scripts/Js_Page/RecruiteeRegistration.js"></script>
    <link href="../../StyleSheets/RecruiteeRegistration.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/jqueryCdn.js"></script>
</head>
<script>
    $(document).ready(function () {
        cities();
        qualifications();
    });
</script>
<body>
    <form id="form" method="post">
        <div class="logo">

            <img src="../../Image/Master.jpg" id="masterpage" />
        </div>
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
            <h2 id="conname">Registration</h2>
            
            <div class="con1">
                <div class="name">
                    <label for="txtName" id="lblName">Name:</label><br />
                    <input type="text" id="txtName"  autocomplete="off" placeholder="Enter your Name" autocomplete="off" maxlength="15" onkeypress="return noNumbers(event);" />
                </div>
                <div class="surname">
                    <label for="txtSurname" id="lblSurname">SurName:</label><br />
                    <input type="text" id="txtSurname" autocomplete="off" placeholder="Enter your SurName" maxlength="15" onkeypress="return noNumbers(event);" />
                </div>
            </div>
            <div class="con2">
                <div class="phone">
                    <label for="txtPhone" id="lblPhone">Phone:</label><br />
                    <input type="tel" id="txtPhone" onkeypress="return onlyNumbers(event);" autocomplete="off" placeholder="Enter your Phone Number" maxlength="10" />
                </div>
                <div class="email">
                    <label for="txtEmail" id="lblEmail">Email:</label><br />
                    <input type="email" id="txtEmail" autocomplete="off"  placeholder="Enter your Email" maxlength="18" />
                </div>
            </div>
            <div class="con3">
                <div class="gender">
                    <label>Gender:</label>
                    <input type="radio" name="gender" id="rdbMale" value="male"/>
                    <label for="rdbMale" id="lblMale">Male</label>

                    <input type="radio" name="gender" id="rdbFemale" value="female"/>
                    <label for="rdbFemale" id="lblFemale">Female</label>

                    <input type="radio" name="gender" id="rdbNone" value="none"/>
                    <label for="rdbNone" id="lblNone">Prefer Not to Say</label>
                </div>
            </div>
            <div class="con4">
                <div class="dob">
                    <label for="dateDob" id="lblDob">DOB:</label><br />
                    <input type="date" id="dateDob"/>
                </div>
                <div class="city">
                    <label for="ddlCity" id="lblCity">City:</label><br />
                    <select id="ddlCity">
                    </select>
                </div>
            </div>
            <div class="con5">
                <div class="address">
                    <label for="txtArea" id="lblAddress">Address:</label><br />
                    <textarea rows="6" cols="61" id="txtArea" maxlength="40" runat="server"></textarea>
                </div>
            </div>
            <div class="con6">
                <div class="qualification">
                    <label id="lblQualification" for="ddlQualification">Qualification:</label><br />
                    <select id="ddlQualification">
                    </select>

                </div>
                <div class="percentage">
                    <label for="txtPercentage" id="lblPercentage" autocomplete="off" >Percentage:</label><br />
                    <input type="text" id="txtPercentage" onkeypress="return onlyNumbers(event);"  placeholder="Enter your Percentage" maxlength="6" />
                </div>
            </div>
            <div class="con7">
                <div class="certificate">
                    <label for="fileUpload" id="lblCmm">CMM Upload:</label>
                    <input type="file" id="fileUpload"  />
                </div>
            </div>
            <div class="submit">
                <button id="btnRegister" onclick="return FileInput();" type="button">Submit</button>
            </div>
        </div>
        <div class="footer">
            <p id="footer1">Copyright © 2023-2025 Simhachala Devasthanams, All Rights Reserved</p>
            <p id="footer2">Devoloped by Nikhil</p>
        </div>
        
    </form>

</body>
</html>
