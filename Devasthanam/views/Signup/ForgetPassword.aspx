<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="Devasthanam.views.Signup.ForgetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/ForgetPassword.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <nav>
     <ul>
         <li>
             <img src="../../Image/home.jpg" id="home" />
             <a href="LoginPage.aspx">Home</a>
         </li>
         <li>
             <img src="../../Image/call.jpg" id="contact" />
             <a href="../UserHome/ContactUs.aspx"> Contact Us</a>
         </li>
         <%--<li>                
     <img src="../Image/logout.jpg" id="logout"/>                 
     <a href="Signup.aspx">Log Out</a>
 </li>--%>
     </ul>
 </nav>
 <div class="container">
     <h3>Reset Password</h3>
     <label for="txtPhone" id="lblPhone">UserID:</label>
     <input type="tel" maxlength="10" placeholder="Enter your UserId" id="txtPhone" /><br />
     <label for="txtPswd" id="lblPswd">New Password:</label>
     <input type="password" maxlength="15" placeholder="Enter New Password" id="txtPswd" /><br />
     <label for="txtCPswd" id="lblCPswd">Confirm Password:</label>
     <input type="password" maxlength="15" placeholder="Confirm Password" id="txtCPswd" /><br />
     <input type="button" value="Reset Password" id="reset" />
 </div>
</asp:Content>
