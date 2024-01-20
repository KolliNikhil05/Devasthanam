<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Devasthanam.views.UserHome.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/ContactUs.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
      </ul>
  </nav>
    <div class="container">
        <div class="con1">
            <h2>Contact US</h2>
            <p>For any Queries , You can  </p>
            <div class="phone">
                <img src="../../Image/Phone.png" id="phoneimg" />
                <p id="txtphone">1800-845-1042</p>
            </div>
            <div class="email">
                <img src="../../Image/email.png" id="emailimg" />
                <p id="txtemail">SimhachalamDevasthanam@gmail.com</p>
            </div>
        </div>
        <div class="img">
            <img src="../../Image/ContactUs.png" />
        </div>

    </div>
</asp:Content>
