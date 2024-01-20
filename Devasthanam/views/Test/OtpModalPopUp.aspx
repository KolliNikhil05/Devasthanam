<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterPages/Test.Master" AutoEventWireup="true" CodeBehind="OtpModalPopUp.aspx.cs" Inherits="Devasthanam.views.Test.OtpModalPopUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="../../StyleSheets/OtpModalPopUp.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="../../Scripts/Js_Page/OtpModalPopUp.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
    <div class="phone">
        <label>Phone:</label>
        <input type="text" id="txtPhoneNumber" runat="server" placeholder="Enter Phone Number:" maxlength="10"   readonly/>
    </div>
    <div class="otp">
        <input id="btnOtp" type="button" value="Send OTP" data-toggle="modal" data-target="#myModal" onClick="sendOTP();"/>
    </div>
</div>
     
<div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title"></h4>
            </div>
            <div class="modal-body">
                <p>OTP Sent successfully to <span id="phoneNumberPlaceholder"></span>.</p>
                <label>Enter OTP:</label>
                 <input type="text" placeholder="Enter OTP" id="txtOTP" />
            </div>
            <div class="modal-footer">
                <button type="submit" class="btn" id="btn_Validate" style="background-color:lightsalmon" onClick="validateOTP();">Validate</button>
            </div>
        </div>
    </div>
</div>
</asp:Content>


 
