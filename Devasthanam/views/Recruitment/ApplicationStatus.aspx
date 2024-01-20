<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="ApplicationStatus.aspx.cs" Inherits="Devasthanam.views.Recruitment.ApplicationStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/ApplicationStatus.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/ApplicationStatus.js"></script>
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
      <div class="con2">
          <h3>Check Status of Your Application</h3>
          <br />
          <label for="txtPhone">Phone:</label>
          <input type="text" placeholder="Enter Your Phone Number" runat="server" autocomplete="off" id="txtPhone" maxlength="10" />
          <input type="button" id="btnCheck" value="Check" onclick="checkStatus();" /><br />
      </div>
      <div class="con1" id="letter" runat="server" style="display: none;">
           <br />
          <label>Name : </label>
          <label id="lblName" runat="server" ></label>
          <br />
          <label>SurName : </label>
          <label id="lblSurName" runat="server" ></label>
          <br />
          <label>Phone : </label>
          <label id="lblPhone" runat="server" ></label>
          <br />
          <label>Email : </label>
          <label id="lblEmail" runat="server" ></label>
          <br />
          <label>Gender : </label>
          <label id="lblGender" runat="server" ></label>
          <br />
          <label>Payment : </label>
          <label id="lblPayment" runat="server" ></label>
          <br />
          <label>Qualified : </label>
          <label id="lblQualified" runat="server"></label>
      </div>
      <div class="download"  style="display: none;">
          <p class="blinking-marquee" >Congratulations You have Selected !, Download Offer Letter</p>
         <asp:button runat="server"  Text="Download" value="Download" ID="btnLetter" onclick="btnDownload" ></asp:button>
      </div>
  </div>
</asp:Content>
