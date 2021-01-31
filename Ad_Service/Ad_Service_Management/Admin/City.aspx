<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="City.aspx.cs" Inherits="Ad_Service_Management.Admin.City" %>
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
                        Enter City</label>
                    <asp:TextBox ID="txtCty" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Enter City." ControlToValidate="txtCty" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>
                

                <div class="btn btn-primary glyphicon glyphicon-search">
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
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        CommandArgument='<%# Eval("Cty_Id") %>' Height="45px" 
                                        ImageUrl="assets/img/Edit-Website.jpg" onclick="ImageButton1_Click" 
                                        Width="45px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Delete">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        CommandArgument='<%# Eval("Cty_Id") %>' Height="45px" 
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
