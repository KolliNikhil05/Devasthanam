<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Devasthanam.LoginPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../StyleSheets/LoginPage.css" rel="stylesheet" />
 
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/jqueryCdn.js"></script>
    <script src="../../Scripts/Js_Page/LoginPage.js"></script>
    <title>LoginPage</title>
</head>
<body>
    <form id="form1" >
        <div class="logo">
            <img src="../../Image/Master.jpg" id="masterpage"/>             
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
            <h2 id="conName">Login</h2>
            <div class="userid">
                <label for="txtPhone" id="lblLoginPhone">Mobile:
                    <span style="color : red">*</span>
                </label><br />
                <input type="tel" id="txtPhone" autocomplete="off" placeholder="Enter Your UserID" maxlength="10" onkeypress="return onlyNumbers(event);" /><br />
            </div>
            <div class="password">
                <label id="lbl_pswd" for="loginPswd">Password:
                    <span style="color : red">*</span>
                </label><br />
                <input type="password" id="loginPswd" autocomplete="off" maxlength="15" placeholder="Enter Your password" onkeypress="return noSpaces(event);" /><br />  
            </div>
            <div class="button">
               <button id="btnLogin"  onclick="Login();" type="button">Log In</button>
            </div>   
            <a href="Signup.aspx" id="anchor" >New User ? Sign Up</a>
        </div>
        </div>
        <div class="footer">
            <p id="footer1">Copyright © 2023-2025 Simhachala Devasthanams, All Rights Reserved</p>    
            <p id="footer2">Devoloped by Nikhil</p>           
        </div>
    </form>                                                
</body>
</html>
