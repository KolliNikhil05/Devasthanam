﻿<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="RoleOptions.aspx.cs" Inherits="Devasthanam.views.UserHome.RoleOptions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/RoleOptions.css" rel="stylesheet" />
    <script src="../../Scripts/Js_Page/RoleOptions.js"></script>
    <script src="../../Scripts/Js_Page/CDNJavaScript.js"></script>
    <script src="../../Scripts/Js_Page/jqueryCdn.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="MainUpdatePanel" runat="server" UpdateMode="Conditional">
            <%--  <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ddlDistrict" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="lstRoles" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="Insert" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="Reset" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="SelectAll" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="Delete" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="Calendar1" EventName="SelectionChanged" />
            </Triggers>--%>
            <ContentTemplate>
                <div class="container1">
                    <div class="name">
                        <asp:Label AssociatedControlID="txtName" ID="lblName" runat="server">Name:</asp:Label><br />
                        <asp:TextBox ID="txtName" runat="server" MaxLength="15" MinLength="3" placeholder="Enter Your Name"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ForeColor="Red" ErrorMessage="Please Enter Your Name" Display="Dynamic" SetFocusOnError="true" />
                        <asp:RegularExpressionValidator ID="revName" runat="server" ControlToValidate="txtName"
                            ValidationExpression="^.{3,}$" ForeColor="Red" ErrorMessage="Name should be more than 2 characters" Display="Dynamic" SetFocusOnError="true" />
                        <asp:RegularExpressionValidator ID="revNoNumbers" runat="server" ControlToValidate="txtName"
                            ValidationExpression="^[^\d]+$" ForeColor="Red" ErrorMessage="Name should not contain any numbers" Display="Dynamic" SetFocusOnError="true" />
                        <br />
                    </div>
                    <div class="surname">
                        <asp:Label AssociatedControlID="txtSurName" ID="lblSurName" runat="server">SurName:</asp:Label><br />
                        <asp:TextBox ID="txtSurName" runat="server" MaxLength="15" MinLength="3" placeholder="Enter Your SurName"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RfvSurName" runat="server" ControlToValidate="txtSurName"
                            ForeColor="Red" ErrorMessage="Please Enter Your SurName" Display="Dynamic" SetFocusOnError="true" />
                        <asp:RegularExpressionValidator ID="revSurName" runat="server" ControlToValidate="txtSurName"
                            ValidationExpression="^.{3,}$" ForeColor="Red" ErrorMessage="SurName should be more than 2 characters" Display="Dynamic" SetFocusOnError="true" />
                        <asp:RegularExpressionValidator ID="revSurnameNumbers" runat="server" ControlToValidate="txtSurName"
                            ValidationExpression="^[^\d]+$" ForeColor="Red" ErrorMessage="SurName should not contain any numbers" Display="Dynamic" SetFocusOnError="true" />
                        <br />
                    </div>
                </div>

                <div class="container2">
                    <div class="district">
                        <asp:Label AssociatedControlID="ddlDistrict" ID="lblDistrict" runat="server">District:</asp:Label><br />
                        <asp:DropDownList ID="ddlDistrict" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvddlDistrict" runat="server" ControlToValidate="ddlDistrict"
                            ForeColor="Red" ErrorMessage="Select a District" InitialValue="0" Display="Dynamic" SetFocusOnError="true" />
                    </div>
                    <div class="mandal">
                        <asp:Label AssociatedControlID="ddlMandal" ID="lblMandal" runat="server">Mandal:</asp:Label><br />
                        <asp:DropDownList ID="ddlMandal" runat="server">
                            <asp:ListItem Text="Select Your Mandal" Value="0" />
                        </asp:DropDownList><br />
                        <asp:RequiredFieldValidator ID="rfvddlMandal" runat="server" ControlToValidate="ddlMandal"
                            ForeColor="Red" ErrorMessage="Please Select a Mandal" InitialValue="0" Display="Dynamic" SetFocusOnError="true" />
                    </div>
                </div>



                <div class="container3">
                    <div class="gender">
                        <asp:Label AssociatedControlID="rdbGender" ID="lblGender" runat="server">Gender:</asp:Label>
                        <asp:RadioButtonList ID="rdbGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Male" name="gender" Value="Male"></asp:ListItem>
                            <asp:ListItem Text="Female" name="gender" Value="Female"></asp:ListItem>
                            <asp:ListItem Text="Prefer Not to Say" name="gender" Value="Prefer Not to Say"></asp:ListItem>
                        </asp:RadioButtonList><br />
                        <asp:RequiredFieldValidator ID="rfvrdb" runat="server" ControlToValidate="rdbGender"
                            ForeColor="Red" ErrorMessage="Please select a gender" Display="Dynamic" SetFocusOnError="true" />
                    </div>
                </div>


                <div class="container4">
                    <div class="skills">
                        <asp:Label AssociatedControlID="lstSkills" ID="lblSkills" runat="server">✔ Skills If You are 100% Sure:</asp:Label><br />
                        <asp:CheckBoxList ID="lstSkills" runat="server" class="checkbox" AutoPostBack="true" OnSelectedIndexChanged="lstSkills_SelectedIndexChanged"></asp:CheckBoxList>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" OnServerValidate="CustomValidator1_ServerValidate" ErrorMessage="Select a Skills" ForeColor="Red"></asp:CustomValidator>
                    </div>
                    <div class="roles">
                        <asp:Label AssociatedControlID="lstRoles" ID="lblRoles" runat="server">Choose Role:</asp:Label><br />
                        <asp:ListBox runat="server" ID="lstRoles" CssClass="lstrole" SelectionMode="Multiple" AutoPostBack="true" ClientIDMode="AutoID"></asp:ListBox>
                        <asp:Button runat="server" ID="Insert" Text="Insert" class="btn" ValidationGroup="asd" OnClick="Insert_Click" />
                    </div>
                </div>

                <div class="container5">
                    <div class="getroles">
                        <asp:Label AssociatedControlID="lstEditRoles" ID="lblEditRoles" runat="server">Edit Role:</asp:Label>
                        <asp:ListBox runat="server" ID="lstEditRoles" CssClass="lstrole" AutoPostBack="true" SelectionMode="Multiple"></asp:ListBox><br />
                        <asp:RequiredFieldValidator ID="rfvLstEditRoles" runat="server" ControlToValidate="lstEditRoles"
                            ForeColor="Red" ErrorMessage="Please select a role" Display="Dynamic" SetFocusOnError="true" />
                    </div>
                    <div class="buttons">
                        <asp:Button runat="server" ID="Reset" Text="Reset" ValidationGroup="asdf" class="btn" OnClick="Reset_Click" />
                        <asp:Button runat="server" ID="SelectAll" Text="Select All" ValidationGroup="asdf" class="btn" OnClick="SelectAll_Click" />
                        <asp:Button runat="server" ID="Delete" Text="Delete" class="btn" ValidationGroup="asdf" OnClick="Delete_Click" />
                    </div>
                    <%--<div class="Dob">
                        <asp:Label runat="server">SelectionDate: </asp:Label>
                        <asp:Calendar ID="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
                        <asp:TextBox ID="txtDate" runat="server" /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="select a date" ForeColor="Red" SetFocusOnError="True" />
                    </div>--%>
                    <div class="Dob">
                        <asp:Label runat="server">Selected Slot Date: </asp:Label>
                        <asp:Calendar ID="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
                        <asp:TextBox ID="txtDate" runat="server" /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="Please Select a date" ForeColor="Red" SetFocusOnError="True" />
                        <asp:CustomValidator ID="CustomDOBValidator" ForeColor="Red" runat="server" ControlToValidate="txtDate" ErrorMessage="Invalid DOB"
                            OnServerValidate="CustomDOBValidator_ServerValidate"></asp:CustomValidator>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <div class="container6">
            <div class="upload">
                <asp:Label AssociatedControlID="Upload" ID="lblUpload" runat="server">CMM:</asp:Label>
                <asp:FileUpload ID="Upload" runat="server" AutoPostBack="true" /><br />
                <asp:RequiredFieldValidator ID="rfvUpload" runat="server" ControlToValidate="Upload"
                    ForeColor="Red" ErrorMessage="Please select a file"
                    Display="Dynamic" SetFocusOnError="true" />
            </div>
            <asp:Button ID="btnSubmit" class="btn" runat="server" Text="Submit" OnClick="btnSubmit_Click" OnClientClick="return validation();" />
        </div>
    </div>
</asp:Content>

<%--
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlDistrict" EventName="SelectedIndexChanged" />
        </Triggers>
        <ContentTemplate>
            <div class="container2">
                <div class="district">
                    <asp:Label AssociatedControlID="ddlDistrict" ID="lblDistrict" runat="server">District:</asp:Label><br />
                    <asp:DropDownList ID="ddlDistrict" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvddlDistrict" runat="server" ControlToValidate="ddlDistrict"
                        ForeColor="Red" ErrorMessage="Select a District" InitialValue="0" Display="Dynamic" SetFocusOnError="true" />
                </div>
                <div class="mandal">
                    <asp:Label AssociatedControlID="ddlMandal" ID="lblMandal" runat="server">Mandal:</asp:Label><br />
                    <asp:DropDownList ID="ddlMandal" runat="server">
                        <asp:ListItem Text="Select Your Mandal" Value="0" />
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvddlMandal" runat="server" ControlToValidate="ddlMandal"
                        ForeColor="Red" ErrorMessage="Please Select a Mandal" InitialValue="0" Display="Dynamic" SetFocusOnError="true" />
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="container3">
        <div class="gender">
            <asp:Label AssociatedControlID="rdbGender" ID="lblGender" runat="server">Gender:</asp:Label>
            <asp:RadioButtonList ID="rdbGender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Male" name="gender" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" name="gender" Value="Female"></asp:ListItem>
                <asp:ListItem Text="Prefer Not to Say" name="gender" Value="Prefer Not to Say"></asp:ListItem>
            </asp:RadioButtonList><br />
            <asp:RequiredFieldValidator ID="rfvrdb" runat="server" ControlToValidate="rdbGender"
                ForeColor="Red" ErrorMessage="Please select a gender" Display="Dynamic" SetFocusOnError="true" />
        </div>
    </div>

    <div class="container4">
        <asp:UpdatePanel ID="updatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
            <ContentTemplate>
                <div class="skills">
                    <asp:Label AssociatedControlID="lstSkills" ID="lblSkills" runat="server">✔ Skills If You are 100% Sure:</asp:Label><br />
                    <asp:CheckBoxList ID="lstSkills" runat="server" class="checkbox" AutoPostBack="true" OnSelectedIndexChanged="lstSkills_SelectedIndexChanged"></asp:CheckBoxList>
                   <asp:CustomValidator ID="CustomValidator1"  runat="server" OnServerValidate="CustomValidator1_ServerValidate" ErrorMessage="Select a Skills" ForeColor="Red"></asp:CustomValidator>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <div class="roles">
            <asp:UpdatePanel ID="updatePanelRoles" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label AssociatedControlID="lstRoles" ID="lblRoles" runat="server">Choose Role:</asp:Label><br />
                    <asp:ListBox runat="server" ID="lstRoles" CssClass="lstrole" SelectionMode="Multiple" AutoPostBack="true" ClientIDMode="AutoID"></asp:ListBox>
                    <asp:Button runat="server" ID="Insert" Text="Insert" class="btn" ValidationGroup="asd" OnClick="Insert_Click" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="lstRoles" EventName="SelectedIndexChanged" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </div>


    <div class="container5">
        <div class="getroles">
            <asp:UpdatePanel ID="updatePanelEditRoles" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label AssociatedControlID="lstEditRoles" ID="lblEditRoles" runat="server">Edit Role:</asp:Label>
                    <asp:ListBox runat="server" ID="lstEditRoles" CssClass="lstrole" AutoPostBack="true" SelectionMode="Multiple"></asp:ListBox><br />
                    <asp:RequiredFieldValidator ID="rfvLstEditRoles" runat="server" ControlToValidate="lstEditRoles"
                        ForeColor="Red" ErrorMessage="Please select a role" Display="Dynamic" SetFocusOnError="true" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="lstRoles" EventName="SelectedIndexChanged" />
                    <asp:AsyncPostBackTrigger ControlID="Insert" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="Reset" EventName="Click"/>
                    <asp:AsyncPostBackTrigger ControlID="SelectAll" EventName="Click"/>
                     <asp:AsyncPostBackTrigger ControlID="Delete" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <div class="buttons">
            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
                    <asp:Button runat="server" ID="Reset" Text="Reset" validationGroup="asdf" class="btn" OnClick="Reset_Click" />
                    <asp:Button runat="server" ID="SelectAll" Text="Select All"  validationGroup="asdf" class="btn" OnClick="SelectAll_Click" />
                    <asp:Button runat="server" ID="Delete" Text="Delete" class="btn"  validationGroup="asdf" OnClick="Delete_Click" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Reset" EventName="Click"/>
                     <asp:AsyncPostBackTrigger ControlID="Delete" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <div class="Dob">
            <asp:Label runat="server">DOB: </asp:Label>
           
                <asp:UpdatePanel ID="updatepanel5" runat="server">
                    <ContentTemplate>
                        <asp:Calendar ID="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
                        <asp:TextBox ID="txtDate" runat="server"   /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="select a date" ForeColor="Red" SetFocusOnError="True" />
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Calendar1" EventName="SelectionChanged" />
                    </Triggers>
                </asp:UpdatePanel>
        </div>
    </div>



    <div class="container6">
        <div class="upload">
            <asp:Label AssociatedControlID="Upload" ID="lblUpload" runat="server">CMM:</asp:Label>
            <asp:FileUpload ID="Upload" runat="server" AutoPostBack="true" /><br />
            <asp:RequiredFieldValidator ID="rfvUpload" runat="server" ControlToValidate="Upload"
                ForeColor="Red" ErrorMessage="Please select a file"
                Display="Dynamic" SetFocusOnError="true" />
        </div>
        <asp:Button ID="btnSubmit" class="btn" runat="server" Text="Submit" OnClick="btnSubmit_Click" OnClientClick="return validation();" />
    </div>


</div>--%>




























<%--<div class="container">

        <div class="container1">
            <div class="name">
                <asp:Label AssociatedControlID="txtName" ID="lblName" runat="server">Name:</asp:Label><br />
                <asp:TextBox ID="txtName" runat="server" MaxLength="15" MinLength="3" placeholder="Enter Your Name"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                    ForeColor="Red" ErrorMessage="Please Enter Your Name" Display="Dynamic" SetFocusOnError="true" />
                <asp:RegularExpressionValidator ID="revName" runat="server" ControlToValidate="txtName"
                    ValidationExpression="^.{3,}$" ForeColor="Red" ErrorMessage="Name should be more than 2 characters" Display="Dynamic" SetFocusOnError="true" />
                <asp:RegularExpressionValidator ID="revNoNumbers" runat="server" ControlToValidate="txtName"
                    ValidationExpression="^[^\d]+$" ForeColor="Red" ErrorMessage="Name should not contain any numbers" Display="Dynamic" SetFocusOnError="true" />
                <br />
            </div>
            <div class="surname">
                <asp:Label AssociatedControlID="txtSurName" ID="lblSurName" runat="server">SurName:</asp:Label><br />
                <asp:TextBox ID="txtSurName" runat="server" MaxLength="15" MinLength="3" placeholder="Enter Your SurName"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RfvSurName" runat="server" ControlToValidate="txtSurName"
                    ForeColor="Red" ErrorMessage="Please Enter Your SurName" Display="Dynamic" SetFocusOnError="true" />
                <asp:RegularExpressionValidator ID="revSurName" runat="server" ControlToValidate="txtSurName"
                    ValidationExpression="^.{3,}$" ForeColor="Red" ErrorMessage="SurName should be more than 2 characters" Display="Dynamic" SetFocusOnError="true" />
                <asp:RegularExpressionValidator ID="revSurnameNumbers" runat="server" ControlToValidate="txtSurName"
                    ValidationExpression="^[^\d]+$" ForeColor="Red" ErrorMessage="SurName should not contain any numbers" Display="Dynamic" SetFocusOnError="true" />
                <br />
            </div>
        </div>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server" UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ddlDistrict" EventName="SelectedIndexChanged" />
            </Triggers>
            <ContentTemplate>
                <div class="container2">
                    <div class="district">
                        <asp:Label AssociatedControlID="ddlDistrict" ID="lblDistrict" runat="server">District:</asp:Label><br />
                        <asp:DropDownList ID="ddlDistrict" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvddlDistrict" runat="server" ControlToValidate="ddlDistrict"
                            ForeColor="Red" ErrorMessage="Select a District" InitialValue="0" Display="Dynamic" SetFocusOnError="true" />
                    </div>
                    <div class="mandal">
                        <asp:Label AssociatedControlID="ddlMandal" ID="lblMandal" runat="server">Mandal:</asp:Label><br />
                        <asp:DropDownList ID="ddlMandal" runat="server">
                            <asp:ListItem Text="Select Your Mandal" Value="0" />
                        </asp:DropDownList><br />
                        <asp:RequiredFieldValidator ID="rfvddlMandal" runat="server" ControlToValidate="ddlMandal"
                            ForeColor="Red" ErrorMessage="Please Select a Mandal" InitialValue="0" Display="Dynamic" SetFocusOnError="true" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <div class="container3">
            <div class="gender">
                <asp:Label AssociatedControlID="rdbGender" ID="lblGender" runat="server">Gender:</asp:Label>
                <asp:RadioButtonList ID="rdbGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Male" name="gender" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" name="gender" Value="Female"></asp:ListItem>
                    <asp:ListItem Text="Prefer Not to Say" name="gender" Value="Prefer Not to Say"></asp:ListItem>
                </asp:RadioButtonList><br />
                <asp:RequiredFieldValidator ID="rfvrdb" runat="server" ControlToValidate="rdbGender"
                    ForeColor="Red" ErrorMessage="Please select a gender" Display="Dynamic" SetFocusOnError="true" />
            </div>
        </div>

        <div class="container4">
            <asp:UpdatePanel ID="updatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
                <ContentTemplate>
                    <div class="skills">
                        <asp:Label AssociatedControlID="lstSkills" ID="lblSkills" runat="server">✔ Skills If You are 100% Sure:</asp:Label><br />
                        <asp:CheckBoxList ID="lstSkills" runat="server" class="checkbox" AutoPostBack="true" OnSelectedIndexChanged="lstSkills_SelectedIndexChanged"></asp:CheckBoxList>
                       <asp:CustomValidator ID="CustomValidator1"  runat="server" OnServerValidate="CustomValidator1_ServerValidate" ErrorMessage="Select a Skills" ForeColor="Red"></asp:CustomValidator>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="roles">
                <asp:UpdatePanel ID="updatePanelRoles" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label AssociatedControlID="lstRoles" ID="lblRoles" runat="server">Choose Role:</asp:Label><br />
                        <asp:ListBox runat="server" ID="lstRoles" CssClass="lstrole" SelectionMode="Multiple" AutoPostBack="true" ClientIDMode="AutoID"></asp:ListBox>
                        <asp:Button runat="server" ID="Insert" Text="Insert" class="btn" ValidationGroup="asd" OnClick="Insert_Click" />
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="lstRoles" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
        </div>


        <div class="container5">
            <div class="getroles">
                <asp:UpdatePanel ID="updatePanelEditRoles" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label AssociatedControlID="lstEditRoles" ID="lblEditRoles" runat="server">Edit Role:</asp:Label>
                        <asp:ListBox runat="server" ID="lstEditRoles" CssClass="lstrole" AutoPostBack="true" SelectionMode="Multiple"></asp:ListBox><br />
                        <asp:RequiredFieldValidator ID="rfvLstEditRoles" runat="server" ControlToValidate="lstEditRoles"
                            ForeColor="Red" ErrorMessage="Please select a role" Display="Dynamic" SetFocusOnError="true" />
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="lstRoles" EventName="SelectedIndexChanged" />
                        <asp:AsyncPostBackTrigger ControlID="Insert" EventName="Click" />
                         <asp:AsyncPostBackTrigger ControlID="Reset" EventName="Click"/>
                        <asp:AsyncPostBackTrigger ControlID="SelectAll" EventName="Click"/>
                         <asp:AsyncPostBackTrigger ControlID="Delete" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="buttons">
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <asp:Button runat="server" ID="Reset" Text="Reset" validationGroup="asdf" class="btn" OnClick="Reset_Click" />
                        <asp:Button runat="server" ID="SelectAll" Text="Select All"  validationGroup="asdf" class="btn" OnClick="SelectAll_Click" />
                        <asp:Button runat="server" ID="Delete" Text="Delete" class="btn"  validationGroup="asdf" OnClick="Delete_Click" />
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Reset" EventName="Click"/>
                         <asp:AsyncPostBackTrigger ControlID="Delete" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="Dob">
                <asp:Label runat="server">DOB: </asp:Label>
               
                    <asp:UpdatePanel ID="updatepanel5" runat="server">
                        <ContentTemplate>
                            <asp:Calendar ID="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
                            <asp:TextBox ID="txtDate" runat="server"   /><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="select a date" ForeColor="Red" SetFocusOnError="True" />
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Calendar1" EventName="SelectionChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
            </div>
        </div>



        <div class="container6">
            <div class="upload">
                <asp:Label AssociatedControlID="Upload" ID="lblUpload" runat="server">CMM:</asp:Label>
                <asp:FileUpload ID="Upload" runat="server" AutoPostBack="true" /><br />
                <asp:RequiredFieldValidator ID="rfvUpload" runat="server" ControlToValidate="Upload"
                    ForeColor="Red" ErrorMessage="Please select a file"
                    Display="Dynamic" SetFocusOnError="true" />
            </div>
            <asp:Button ID="btnSubmit" class="btn" runat="server" Text="Submit" OnClick="btnSubmit_Click" OnClientClick="return validation();" />
        </div>


    </div>--%>
