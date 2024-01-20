<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="RecruiteePaymentDetails.aspx.cs" Inherits="Devasthanam.views.Admin.RecruiteePaymentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/RecruiteePaymentDetails.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width: 91%; height: 510px; overflow: auto;">
        <h3>Recruitee Payment Data</h3>
        <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="4" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_InsertDropdown" ShowFooter="True" DataKeyNames="userId" CellPadding="4" OnRowDeleting="GridView1_RowDeleting" ForeColor="Black" GridLines="Vertical" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowEditButton="True" ButtonType="Button" EditText="Edit" HeaderText="Edit" />
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button" DeleteText="Delete" HeaderText="Delete" />
                <asp:TemplateField>
                    <FooterTemplate>
                        <asp:Button ID="btnAdd" runat="server" Text="Add New" OnClick="btn_AddRow" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UserID">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditUserId" runat="server" ReadOnly="true" Text='<%# Bind("userId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblUserId" runat="server" Text='<%# Bind("userId") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtNewUserId" runat="server" placeholder="Enter userId" Visible="false" ></asp:TextBox>
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
                        <asp:TextBox ID="txtNewUName" runat="server" placeholder="Enter Name" Visible="false" ></asp:TextBox>
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
                         <asp:LinkButton ID="lnkDownload" runat="server" CausesValidation="False" CommandArgument='<%# Eval("UCertificate") %>'  OnClick="download_Certifiacte" CommandName="Download" Text="Download" />  
                         <asp:HiddenField ID="hdnCertificate" runat="server" Value='<%#Bind("UCertificate") %>' />
                        <asp:Label ID="lblCertificate" runat="server" Visible="false" Text='<%# Bind("UCertificate") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:FileUpload runat="server" ID="txtNewCertificate" Visible="false"/>
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
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" CommandName="Insert" OnClick="data_insert" Visible="false" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Visible="false" OnClick="btn_Clear" />
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Black" />
            <HeaderStyle CssClass="grid-header" BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle CssClass="grid-pager" HorizontalAlign="Center" BackColor="#2461BF" ForeColor="Black" /> 
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" HorizontalAlign="Center" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </div>
    
</asp:Content>












