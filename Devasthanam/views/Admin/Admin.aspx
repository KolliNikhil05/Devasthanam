<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Devasthanam.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminHomePage</title>  
    <link href="../../StyleSheets/Admin.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/Admin.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logo">    
            <img src="../../Image/Master.jpg" id="masterpage" />
        </div>
    <nav>
        <ul>
            <li>
                <img src="../../Image/home.jpg" id="home"/>   
                <a href="Admin.aspx">Home</a>
            </li>
            <li>                
               <img src="../../Image/logout.jpg" id="logout" onclick="logout();" />
              <a href="../Signup/LoginPage.aspx" onclick="logout();">Log out</a>
            </li>
        </ul>
    </nav>
    <div class="data">
    <div class="container1">
        <h2 id="con1Name">Candidate Reports</h2>
        <ul>
            <li>
                 <a href="AdminDashboard.aspx">Candidate Details</a>
            </li>
            <li>
                <a href="RecruiteeSelectionByAdmin.aspx">Select Candidates</a>
            </li>
        </ul>
    </div>
    <div class="container2">
        <h2 id="con2Name">Darshanam Slots</h2>
        <ul>
            <li>
               <a href="SlotReleaseByAdmin.aspx">Release Slots</a>
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
