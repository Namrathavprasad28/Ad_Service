<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Ads_List.aspx.cs" Inherits="Ad_Service_Management.User.Ads_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div>
                <h2>
                   AD'S</h2>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">

                <div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" ToolTip='<%# Eval("Ad_v_Id") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Company" />
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                            <asp:BoundField DataField="Date" HeaderText="Date" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                        CommandArgument='<%# Eval("Ad_v_Id") %>' onclick="LinkButton1_Click">View_Video</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <br />
                <div>
                    <asp:Button ID="Button1" runat="server" Text="View Users" class="btn btn-info" 
                        onclick="Button1_Click" />
                </div>
                <br />
                <div>
                    <asp:GridView ID="GridView2" runat="server" class="table table-striped" 
                        AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" ToolTip='<%# Eval("Usr_Id") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:TemplateField HeaderText="Image">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="70px" 
                                        ImageUrl='<%# Eval("Image") %>' Width="70px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <br />
                <div>
                    <asp:Button ID="Button2" runat="server" Text="Share" class="btn btn-info" 
                        onclick="Button2_Click" />
                </div>

                </form>
            </div>
        </div>
    </div>
</asp:Content>
