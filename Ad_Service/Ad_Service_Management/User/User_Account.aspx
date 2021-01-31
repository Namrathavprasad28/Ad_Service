<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="User_Account.aspx.cs" Inherits="Ad_Service_Management.User.User_Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div>
                <h2>
                   CREATE ACCOUNT</h2>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">

                 <div class="form-group">
                    <label>
                        Add Amount</label>
                    <asp:TextBox ID="txtAmt" runat="server" class="form-control"></asp:TextBox>
                     
                </div>
                                
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
                            <asp:BoundField DataField="Amount" HeaderText="Amount" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton2" runat="server" 
                                        CommandArgument='<%# Eval("Usr_Ac_Id") %>' onclick="LinkButton2_Click">Update</asp:LinkButton>
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
