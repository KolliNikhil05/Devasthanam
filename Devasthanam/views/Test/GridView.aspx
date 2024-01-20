<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/Test.Master" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="Devasthanam.views.Test.GridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/GridView.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width: 91%; height: 450px; overflow: auto;">
        <div class="container1">

            <asp:Label ID="lbluserId" runat="server" Text="UserId:" AssociatedControlID="txtuserId"></asp:Label>
            <asp:TextBox ID="txtuserId" runat="server" placeholder="enter userId"></asp:TextBox>
            <asp:Label ID="lbluName" runat="server" Text="Name:" AssociatedControlID="txtuName"></asp:Label>
            <asp:TextBox ID="txtuName" runat="server" placeholder="enter Name"></asp:TextBox>
            <asp:Label ID="lblSurName" runat="server" Text="SurName:" AssociatedControlID="txtSurName"></asp:Label>
            <asp:TextBox ID="txtSurName" runat="server" placeholder="enter SurName"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server" Text="Phone:" AssociatedControlID="txtPhone"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" placeholder="enter Phone"></asp:TextBox>
            <asp:Label ID="lbEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="enter Email"></asp:TextBox>
            <div class="gender">
                <asp:Label ID="Gender" runat="server" Text="Gender:" AssociatedControlID="rblGender"></asp:Label>
                <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:RadioButtonList>
            </div>
            <asp:Label ID="lbDOB" runat="server" Text="DOB:" AssociatedControlID="txtDOB"></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server" placeholder="enter DOB"></asp:TextBox>
            <asp:Label ID="lblCity" runat="server" Text="City:" AssociatedControlID="ddlCities"></asp:Label>
            <asp:DropDownList ID="ddlCities" runat="server" DataTextField="City" DataValueField="id">
            </asp:DropDownList>
            <asp:Label ID="lblAddress" runat="server" Text="Address:" AssociatedControlID="txtAddress"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter Address"></asp:TextBox>

            <asp:Label ID="lbQualification" runat="server" Text="Qualification:" AssociatedControlID="txtQualification"></asp:Label>
            <asp:TextBox ID="txtQualification" runat="server" placeholder="Enter Qualification"></asp:TextBox>
            <asp:Label ID="lblUPercentage" runat="server" Text="Percentage:" AssociatedControlID="txtPercentage"></asp:Label>
            <asp:TextBox ID="txtPercentage" runat="server" placeholder="Enter Percentage"></asp:TextBox>
            <div>
                     <asp:Label ID="lblUCertificate" runat="server" Text="Certificate:"></asp:Label>
       <asp:FileUpload runat="server" ID="txtCertificates" Visible="true" />
       <asp:TextBox ID="txt" runat="server"></asp:TextBox>
            </div>
     
            <asp:Label ID="lblPayment" runat="server" Text="Payment Status:" AssociatedControlID="txtPayment"></asp:Label>
            <asp:TextBox ID="txtPayment" runat="server" placeholder="Enter Payment Status:"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        </div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="true"></asp:GridView>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        <div class="container2">
            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
            <asp:GridView runat="server" ID="GridView1" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="userId" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" OnPageIndexChanging="GridView1_PageIndexChanging" ShowFooter="true" AutoGenerateColumns="false" AllowPaging="True" PageSize="4" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <Columns>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:Button ID="lnkEdit" runat="server" CommandName="Edit" Text="Edit" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="lnkUpdate" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="lnkCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="Server" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <%--<asp:TemplateField HeaderText="Add">
                    <FooterTemplate>
                        <asp:Button ID="btnAdd" runat="server" Text="Add New" OnClick="btn_AddRow" />
                    </FooterTemplate>
                </asp:TemplateField>--%>
                    <asp:TemplateField HeaderText="UserID">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditUserId" runat="server" ReadOnly="true" Text='<%# Bind("userId") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblUserId" runat="server" Text='<%# Bind("userId") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewUserId" runat="server" placeholder="Enter userId" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditUName" runat="server" Text='<%# Bind("UName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblUName" runat="server" Text='<%# Bind("UName") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewUName" runat="server" placeholder="Enter Name" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SurName">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditSurName" runat="server" Text='<%# Bind("SurName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblSurName" runat="server" Text='<%# Bind("SurName") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewSurName" runat="server" placeholder="Enter SurName" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Phone">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditPhone" runat="server" ReadOnly="true" Text='<%# Bind("Phone") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblPhone" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewPhone" runat="server" placeholder="Enter Phone" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditEmail" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewEmail" runat="server" placeholder="Enter Email" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <EditItemTemplate>
                            <asp:RadioButtonList ID="rblEditGender" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Male" Value="Male" />
                                <asp:ListItem Text="Female" Value="Female" />
                            </asp:RadioButtonList>
                            <asp:HiddenField ID="hdnGender" runat="server" Value='<%#Bind("Gender") %>' />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblGender" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:RadioButtonList ID="rdbNewGender" runat="server" RepeatDirection="Horizontal" Visible="false">
                                <asp:ListItem Text="Male" Value="Male" />
                                <asp:ListItem Text="Female" Value="Female" />
                            </asp:RadioButtonList>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DOB">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditDOB" runat="server" Text='<%# Bind("DOB", "{0:MM/dd/yyyy}") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDOB" runat="server" Text='<%# Bind("DOB", "{0:MM/dd/yyyy}") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewDOB" runat="server" placeholder="Enter DOB" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlEditCity" runat="server" DataTextField="City" DataValueField="id">
                            </asp:DropDownList>
                            <asp:HiddenField ID="hdnCity" runat="server" Value='<%#Bind("City") %>' />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="ddlNewCity" runat="server" Visible="false"></asp:DropDownList>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditAddress" runat="server" Text='<%# Bind("UAddress") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAddress" runat="server" Text='<%# Bind("UAddress") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewAddress" runat="server" placeholder="Enter Address" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Qualification">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditQualification" runat="server" Text='<%# Bind("Qualification") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblQualification" runat="server" Text='<%# Bind("Qualification") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewQualification" runat="server" placeholder="Enter Qualification" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Percentage">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditPercentage" runat="server" Text='<%# Bind("UPercentage") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblPercentage" runat="server" Text='<%# Bind("UPercentage") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewPercentage" runat="server" placeholder="Enter Percentage" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Certificate">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditCertificate" runat="server" ReadOnly="true" Text='<%# Bind("UCertificate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkDownload" runat="server" CausesValidation="False" CommandArgument='<%# Eval("UCertificate") %>' OnClick="download_Certifiacte" CommandName="Download" Text="Download" />
                            <asp:HiddenField ID="hdnCertificate" runat="server" Value='<%#Bind("UCertificate") %>' />
                            <asp:Label ID="lblCertificate" runat="server" Visible="false" Text='<%# Bind("UCertificate") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:FileUpload runat="server" ID="txtNewCertificate" Visible="false" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Payment">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditPayment" runat="server" Text='<%# Bind("Payment") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblPayment" runat="server" Text='<%# Bind("Payment") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewPayment" runat="server" placeholder="Enter Payment" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <FooterTemplate>
                            <asp:Label ID="lbl" runat="server" Text="." />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#2461BF" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle CssClass="grid-pager" ForeColor="Black" HorizontalAlign="left" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#2461BF" />
                <SortedDescendingCellStyle BackColor="#2461BF" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
              
        </div>
    </div>
</asp:Content>
