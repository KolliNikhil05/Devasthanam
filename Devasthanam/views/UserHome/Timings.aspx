<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="Timings.aspx.cs" Inherits="Devasthanam.views.UserHome.Timings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/Timings.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <nav>
    <ul>
        <li>
            <img src="../../Image/home.jpg" id="home"/>                            
            <a href="UserHomePage.aspx">Home</a>
        </li>
        <li>                                 
            <img src="../../Image/call.jpg" id="contact"/>                
            <a href="ContactUs.aspx">Contact us</a>
        </li>
        <li>                
            <img src="../../Image/logout.jpg" id="logout"/>                 
            <a href="../Signup/LoginPage.aspx">Log Out</a>
        </li>                            
    </ul>
</nav>
    <div class="container">
        <h2 id="qq">TIMINGS</h2>
    <table>
        <tr>
            <td>04:00 AM to 04:10 AM</td>
            <td>Melkolupu(Naadaswaravadyamu)</td>
        </tr>
        <tr>
            <td>04:10 AM to 04:30 AM	   </td>
            <td>Suprabhatha Patanamu</td>
        </tr>
        <tr>
            <td>04:30 AM to 04:45 AM</td>
            <td> Suprabhatha Darshanamulu</td>
        </tr>
        <tr>
            <td>04:45 AM to 05:00 AM</td>
            <td> Antharalaya Sammarjanamu</td>
        </tr>
        <tr>
            <td>05:00 AM to 06:30 AM</td>
            <td>Prathararadhanamu</td>
        </tr>
        <tr>
            <td>05:30 AM to 09:30 AM</td>
            <td>Veda Itihasa Puranamula Parayanamu</td>
        </tr>
        <tr>
            <td>05:30 AM to 06:30 AM</td>
            <td>Aaradhana Ticket Darshanamu</td>
        </tr>
        <tr>
            <td>06:30 AM to 11:30 AM</td>
            <td>Sarvadarshanamulu</td>
        </tr>
        <tr>
            <td>From 9:30 AM</td>
            <td>Sri Swamy Vari Nithya Kalyanam</td>
        </tr>
        <tr>
            <td>11:30 AM to 12:00 PM</td>
            <td>Mahanivedanamu (Rajabhogamu) Darshanams Break</td>
        </tr>
        <tr>
            <td>12:00 PM to 02:30 PM</td>
            <td>Sarvadarshanamulu</td>
        </tr>
        <tr>
            <td>02:30 PM to 03:00 PM</td>
            <td>Madhyana Viramamu (Pavalimpu Seva) Darshanams Break</td>
        </tr>
        <tr>
            <td>03:00 PM to 07:00 PM</td>
            <td>Sarvadarshanamulu</td>
        </tr>
        <tr>
            <td>05:00 PM to 08:00 PM</td>
            <td>Veda Parayanamu</td>
        </tr>
        <tr>
            <td>07:00 PM to 08:30 PM</td>
            <td> Ratri Aaradhanamu</td>
        </tr>
        <tr>
            <td>07:30 PM to 08:30 PM</td>
            <td> Aaradhana Ticket Darshanamu</td>
        </tr>
        <tr>
            <td>08:30 PM to 09:00 PM</td>
            <td>Sarvadarshanamulu</td>
        </tr>
        <tr>
            <td>After 09:00 PM</td>
            <td>Eekanta Seva, Kavaata Bandhanamu</td>
    </table>
    </div>
</asp:Content>
