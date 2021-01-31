<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Area.aspx.cs" Inherits="Ad_Service_Management.Admin.Area" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div class="panel-heading">
                <h2>
                   ADD CITY</h2>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">

                <div class="form-group">
                    <label>
                        Enter Area</label>
                    <asp:TextBox ID="txtAr" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Enter City." ControlToValidate="txtAr" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label>
                        Select City</label>
                    <asp:DropDownList ID="ddlCt" runat="server" class="form-control">
                    </asp:DropDownList>
                </div>

                 <%--<div class="form-group">
                    <label id="imag">
                        Enter City</label>
                    <asp:TextBox ID="txtCty" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                         ErrorMessage="Enter city." ControlToValidate="txtCty" ForeColor="Red" 
                         ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>

                 <div class="form-group">
                    <label>
                        Enter Mobile</label>
                    <asp:TextBox ID="txtMob" runat="server" class="form-control"></asp:TextBox>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                         ErrorMessage="Enter Mobile No." ControlToValidate="txtMob" ForeColor="Red" 
                         ValidationExpression="\d{10}" ValidationGroup="a"></asp:RegularExpressionValidator>
                </div>

                 <div class="form-group">
                    <label>
                        Enter Email</label>
                    <asp:TextBox ID="txtEm" runat="server" class="form-control"></asp:TextBox>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                         ErrorMessage="Enter Email." ControlToValidate="txtEm" ForeColor="Red" 
                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                         ValidationGroup="a"></asp:RegularExpressionValidator>
                </div>

                 <div class="form-group">
                    <label>
                        Enter Password</label>
                    <asp:TextBox ID="txtPas" runat="server" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                         ErrorMessage="Enter Password." ControlToValidate="txtPas" ForeColor="Red" 
                         ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label>
                        Select Designation</label>
                    <div class="form-control7">
                        <asp:DropDownList ID="ddlDes" runat="server" class="form-control">
                            <asp:ListItem>--Select Designation--</asp:ListItem>
                            <asp:ListItem>Principal</asp:ListItem>
                            <asp:ListItem>HOD</asp:ListItem>
                            <asp:ListItem>Lecturer</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ErrorMessage="Select Designation." ControlToValidate="ddlDes" 
                            ForeColor="Red" Operator="NotEqual" ValidationGroup="a" 
                            ValueToCompare="--Select Designation--"></asp:CompareValidator>
                    </div>
                </div>--%>

                <div class="pull-right">
                    <asp:Button ID="Button1" runat="server" Text="ADD" class="btn btn-info" 
                        ValidationGroup="a" onclick="Button1_Click" />
                </div> 
                  
                <br />
                <br />
                <br />

                <div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped">
                        <Columns>
                            <asp:BoundField DataField="City" HeaderText="City" />
                            <asp:BoundField DataField="Area" HeaderText="Area" />
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        CommandArgument='<%# Eval("Ar_Id") %>' Height="45px" 
                                        ImageUrl="assets/img/Edit-Website.jpg" onclick="ImageButton1_Click" 
                                        Width="45px" ToolTip='<%# Eval("Cty_Id") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Delete">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        CommandArgument='<%# Eval("Ar_Id") %>' Height="45px" 
                                        ImageUrl="assets/img/delete.jpg" onclick="ImageButton2_Click" 
                                        Width="45px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
              
                </form>
            </div>
        </div>
    </div>
</asp:Content>
