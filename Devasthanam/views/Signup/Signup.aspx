<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Devasthanam.Signup" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <link href="../../StyleSheets/Signup.css" rel="stylesheet" />

    <script src="../../Scripts/Js_Page/Signup.js"></script>
</head>
<body>
    <form id="form" method="post">
        <div class="logo">
            <img src="../../Image/Master.jpg" id="masterpage" />
        </div>
        <div class="main">
            <div class="slideshow">
                <div class="slide">
                    <img src="../../Image/main.jpg" alt="Image 1" />
                </div>
                <div class="slide">
                    <img src="../../Image/archi.png" alt="Image 2" />
                </div>
                <div class="slide">
                    <img src="../../Image/main.jpg" alt="Image 3" />
                </div>
            </div>
            <div class="container">
                <h4 id="conName">New User Creation</h4>
                <div class="userid">
                    <label for="txtPhone" id="lblLoginPhone">
                        Mobile:
             <span style="color: red">*</span>
                    </label>
                    <br />
                    <input type="tel" id="txtPhone" autocomplete="off"   placeholder="Enter Mobile Number" maxlength="10" onkeypress="return onlyNumbers(event);" /><br />
                </div>
                <div class="password">
                    <label id="lbl_pswd" for="loginPswd">
                        Password:
             <span style="color: red">*</span>
                    </label>
                    <br />
                    <input type="password" id="loginPswd" autocomplete="off" placeholder="Enter Your password" maxlength="15" onkeypress="return noSpaces(event);" /><br />
                </div>
                <div class="confirmpassword">
                    <label id="lbl_cpswd" for="loginCPswd">
                        Confirm Password:
             <span style="color: red">*</span>
                    </label>
                    <br />
                    <input type="password" id="loginCPswd" autocomplete="off" placeholder="Confirm password" maxlength="15" onkeypress="return noSpaces(event);" /><br />
                </div>
                <div class="button">
                    <button id="Signupbutton" onclick="SignupValidation();" type="button">Sign up</button><br />
                </div>
                <a href="LoginPage.aspx" id="anchor">Already Have Account ? Login</a>
            </div>
        </div>
        <div class="footer">
            <p id="footer1">Copyright © 2023-2025 Simhachala Devasthanams, All Rights Reserved</p>
            <p id="footer2">Devoloped by Nikhil</p>
        </div>
    </form>
</body>
</html>
