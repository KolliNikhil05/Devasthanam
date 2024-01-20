<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataBind.views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body
        {
            background-color:aquamarine;
            padding:10px;
            text-align:center
        }
        .txtbox1
        {
            padding:10px;
        }
        .txtbox2
        {
            padding:10px;
        }
    </style>
</head>
<body>  
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblException" runat="server" Text=""></asp:Label>
            <asp:GridView ID="grdPeople" runat="server"></asp:GridView><br />
            <asp:GridView ID="grdPeoples" runat="server"></asp:GridView>
        </div>
        <div class="txtbox1">
            <asp:Label ID="label1" runat="server" Text="Id:"></asp:Label>
            <asp:TextBox ID="textbox1" runat="server" Text=""></asp:TextBox>
       </div>
        <div class="txtbox2">
            <asp:Label ID="label2" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="textbox2" runat="server" Text=""></asp:TextBox>
         </div>
        <div class="txtbox3">
            <asp:Label ID="label3" runat="server" Text="Age:"></asp:Label>
            <asp:TextBox ID="textbox3" runat="server" Text=""></asp:TextBox>
        </div>
        <br />
        <%--<div class="dropdown">
            <asp:Label ID="label4" runat="server" Text="select"></asp:Label>
            <asp:DropDownList ID="drd" runat="server" OnSelectedIndexChanged="drd_SelectedIndexChanged"></asp:DropDownList>
        </div>--%>
        <div class="button">
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="button_click"></asp:Button>
        </div>

            
       
    </form>
</body>
</html>
