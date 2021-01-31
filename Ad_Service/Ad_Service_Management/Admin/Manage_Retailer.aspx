<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Manage_Retailer.aspx.cs" Inherits="Ad_Service_Management.Admin.Manage_Retailer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div class="panel-heading">
                <h2>
                   MANAGE RETAILER</h2>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">

                <div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" ToolTip='<%# Eval("Ret_Id") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="Area" HeaderText="Area" />
                            <asp:BoundField DataField="City" HeaderText="City" />
                            <asp:BoundField DataField="Mobile" HeaderText="Mobile" />
                            <asp:BoundField DataField="Email_Id" HeaderText="Email_Id" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="DOB" HeaderText="DOB" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="pull-right">
                    <asp:Button ID="Button1" runat="server" Text="Approve" class="btn btn-info" 
                        onclick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Reject" class="btn btn-info" 
                        onclick="Button2_Click" />
                </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
