<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/Test.Master" AutoEventWireup="true" CodeBehind="RecruiteeDetailsPDF.aspx.cs" Inherits="Devasthanam.views.Test.RecruiteeDetailsPDF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../StyleSheets/RecruiteeDetailsPDF.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="container1">
            <div class="city">
                <asp:Label runat="server" Text="Select City:" AssociatedControlID="ddlCities"></asp:Label>
                <asp:DropDownList ID="ddlCities" runat="server" DataTextField="City" DataValueField="id">
                </asp:DropDownList>
            </div>
            <div class="phone">
                <asp:Label runat="server" Text="Enter Phone Number:" AssociatedControlID="txtPhone"></asp:Label>
                <asp:TextBox runat="server" ID="txtPhone" placeholder="Enter Phone Number" MaxLength="10"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="btnDetails" Text="Get Details" OnClick="btnDetails_Click" />
        </div>
        <asp:Panel runat="server" ID="pnlContainer2" Visible="false">
            <div class="container2" id="assd" runat="server">
                <fieldset>
                    <legend>Details</legend>
                    <table>
                        <tr>
                            <td>
                                <div class="name">
                                    <asp:Label runat="server" AssociatedControlID="lblName" Text="Name: "></asp:Label>
                                    <asp:Label runat="server" ID="lblName"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="surname">
                                    <asp:Label runat="server" AssociatedControlID="lblSurName" Text="SurName: "></asp:Label>
                                    <asp:Label runat="server" ID="lblSurName"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="mobile">
                                    <asp:Label runat="server" AssociatedControlID="lblPhone" Text="Phone: "></asp:Label>
                                    <asp:Label runat="server" ID="lblPhone"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="email">
                                    <asp:Label runat="server" AssociatedControlID="lblEmail" Text="Email: "></asp:Label>
                                    <asp:Label runat="server" ID="lblEmail"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="gender">
                                    <asp:Label runat="server" AssociatedControlID="lblGender" Text="Gender: "></asp:Label>
                                    <asp:Label runat="server" ID="lblGender"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="dob">
                                    <asp:Label runat="server" AssociatedControlID="lblDob" Text="DOB: "></asp:Label>
                                    <asp:Label runat="server" ID="lblDob"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="ucity">
                                    <asp:Label runat="server" AssociatedControlID="lblCity" Text="City: "></asp:Label>
                                    <asp:Label runat="server" ID="lblCity"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="address">
                                    <asp:Label runat="server" AssociatedControlID="lblAddress" Text="Address: "></asp:Label>
                                    <asp:Label runat="server" ID="lblAddress"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="qualification">
                                    <asp:Label runat="server" AssociatedControlID="lblQualification" Text="Qualification: "></asp:Label>
                                    <asp:Label runat="server" ID="lblQualification"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="percentage">
                                    <asp:Label runat="server" AssociatedControlID="lblPercentage" Text="Percentage: "></asp:Label>
                                    <asp:Label runat="server" ID="lblPercentage"></asp:Label>
                                </div>
                            </td>
                        </tr>
                    </table>
                </fieldset>
                </div>
                <div class="container5">
                    <asp:Button runat="server" ID="btnExport" Text="Download" OnClick="btnDownload" />
                </div>     
        </asp:Panel>
    </div>
</asp:Content>
