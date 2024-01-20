<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="RegisteredCandidateDetails.aspx.cs" Inherits="Devasthanam.views.Admin.RegisteredCandidateDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/RegisteredCandidateDetails.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
    <div class="container">
    <asp:GridView runat="server" ID="gv_Download" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="lblUserId" runat="server" Text='<%# Bind("uName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SurName">
                <ItemTemplate>
                    <asp:Label ID="lblUserId" runat="server" Text='<%# Bind("SurName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Phone">
                <ItemTemplate>
                    <asp:Label ID="lblUserId" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                <ItemTemplate>
                    <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Gender">
                <ItemTemplate>
                    <asp:Label ID="lblGender" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DOB">
                <ItemTemplate>
                    <asp:Label ID="lblDOB" runat="server" Text='<%# Bind("DOB") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UAddress">
                <ItemTemplate>
                    <asp:Label ID="lblUAddress" runat="server" Text='<%# Bind("UAddress") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Qualification">
                <ItemTemplate>
                    <asp:Label ID="lblQualification" runat="server" Text='<%# Bind("Qualification") %>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPercentage">
                    <itemtemplate>
                        <asp:Label ID="lblUPercentage" runat="server" Text='<%# Bind("UPercentage") %>'></asp:Label>
                    </itemtemplate>
                </asp:TemplateField>
        </Columns>
         <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="Black" />
    </asp:GridView>
    <asp:Button runat="server" ID="btn" OnClick="btnDownload" Text="Download Report" />
            </div>
</asp:Content>
