<%@ Page Title="" Language="C#" MasterPageFile="~/Retailer/Retailer.Master" AutoEventWireup="true" CodeBehind="Ret_Password.aspx.cs" Inherits="Ad_Service_Management.Retailer.Ret_Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div>
                <h4>
                    CHANGE PASSWORD</h4>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">
                <div class="form-group">
                    <label>
                        Old Password</label>
                    <asp:TextBox ID="txtOld" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Enter Old Password." ControlToValidate="txtOld" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>
               <div class="form-group">
                    <label>
                        New Password</label>
                   <asp:TextBox ID="txtNew" runat="server"  class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Enter New Password." ControlToValidate="txtNew" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label>
                        Confirm Password</label>
                   <asp:TextBox ID="txtConf" runat="server"  class="form-control"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ErrorMessage="Enter Confirm Password." ControlToCompare="txtNew" 
                        ControlToValidate="txtConf" ForeColor="Red" ValidationGroup="a"></asp:CompareValidator>
                </div>
                <div class="pull-right">
                    <asp:Button ID="Button1" runat="server" Text="Update" class="btn btn-info" 
                        onclick="Button1_Click" ValidationGroup="a" />
                </div>    
                </form>
            </div>
        </div>
    </div>
</asp:Content>
