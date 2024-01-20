<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/Test.Master" AutoEventWireup="true" CodeBehind="GridViewAdd.aspx.cs" Inherits="Devasthanam.views.Test.GridViewAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/GridViewAdd.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3>Multi Data Insertion Through Grid View</h3>    
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:GridView ID="gvMultiInsert" runat="server" AutoGenerateColumns="false" ShowFooter="true" OnRowDataBound="gvMultiInsert_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="UserId">
                            <ItemTemplate>
                                <asp:Label ID="lbluserId" Text='<% # Bind("userId") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtuserId" runat="server" placeholder="Enter UserId" ItemStyle-HorizontalAlign="Center" />
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Name">
                            <ItemTemplate>
                                <asp:Label ID="lblname" Text='<% # Bind("uName") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtName" runat="server" placeholder="Enter Name" />
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SurName">
                            <ItemTemplate>
                                <asp:Label ID="lblSurName" Text='<% # Bind("SurName") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtSurName" runat="server" placeholder="Enter SurName" />
                            </FooterTemplate>
                        </asp:TemplateField> 
                        <asp:TemplateField HeaderText="Phone">
                            <ItemTemplate>
                                <asp:Label ID="lblPhone" Text='<% # Bind("Phone") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtPhone" runat="server" placeholder="Enter PhoneNuber" />
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" CssClass="ad" runat="server" Text="Delete" OnClick="Gv_row_Delete" />
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:Button ID="btnAdd" runat="server" OnClick="Gv_NewRow" Text="Add" />
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Button ID="btnSubmit" runat="server" OnClick="Gv_Submit" Text="Submit" />
               
            </ContentTemplate>
        </asp:UpdatePanel> 
    </div>
</asp:Content>
 