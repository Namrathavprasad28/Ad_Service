<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="User_Profile.aspx.cs" Inherits="Ad_Service_Management.User.User_Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div>
                <h4>
                    PROFILE UPDATE</h4>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">
                <div class="form-group">
                    <label>
                        Name</label>
                    <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Enter Name." ControlToValidate="txtName" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>
               <%-- <div class="form-group">
                    <label>
                        Address</label>
                   <asp:TextBox ID="txtAdrs" runat="server"  class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Enter Address." ControlToValidate="txtAdrs" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label>
                        Experience</label>
                     <asp:DropDownList ID="ddlCty" runat="server" class="form-control">
                     </asp:DropDownList>
                     <asp:CompareValidator ID="CompareValidator1" runat="server" 
                         ErrorMessage="Select City." ControlToValidate="ddlCty" ForeColor="Red" 
                         Operator="NotEqual" ValidationGroup="a" ValueToCompare="--Select--"></asp:CompareValidator>
                </div>
                <div class="form-group">
                    <label>
                        City</label>
                     <asp:TextBox ID="txtCty" runat="server" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                         ErrorMessage="Enter Experience." ControlToValidate="txtCty" ForeColor="Red" 
                         ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>--%>
                <div class="form-group">
                    <label>
                        Mobile</label>
                   <asp:TextBox ID="txtMob" runat="server"  class="form-control"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Enter Mobile Number." ControlToValidate="txtMob" ForeColor="Red" 
                        ValidationExpression="\d{10}" ValidationGroup="a"></asp:RegularExpressionValidator>
                </div>
                <div class="pull-right">
                    <asp:Button ID="Button1" runat="server" Text="Edit" class="btn btn-info" 
                        onclick="Button1_Click" ValidationGroup="a" />
                    <asp:Button ID="Button2" runat="server" Text="Cancel" class="btn btn-info" 
                        onclick="Button2_Click"  />
                    <asp:Button ID="Button3" runat="server" Text="Update" class="btn btn-info" 
                        onclick="Button3_Click" ValidationGroup="a"  />    
                </div>    
                </form>
            </div>
        </div>
    </div>
</asp:Content>
