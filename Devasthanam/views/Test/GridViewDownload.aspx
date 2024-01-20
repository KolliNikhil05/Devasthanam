<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/Test.Master" AutoEventWireup="true" CodeBehind="GridViewDownload.aspx.cs" Inherits="Devasthanam.views.Test.GridViewDownload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/GridViewDownload.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:GridView runat="server" ID="gv_Download" AutoGenerateColumns="false">
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
                <asp:TemplateField HeaderText="UserId">
                    <ItemTemplate>
                        <asp:Label ID="lblUserId" runat="server" Text='<%# Bind("userId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Phone">
                    <ItemTemplate>
                        <asp:Label ID="lblUserId" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button runat="server" ID="btn" OnClick="btnDownload" Text="Download" />
    </div>
</asp:Content>
