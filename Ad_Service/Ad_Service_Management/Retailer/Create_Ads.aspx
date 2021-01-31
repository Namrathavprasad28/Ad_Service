<%@ Page Title="" Language="C#" MasterPageFile="~/Retailer/Retailer.Master" AutoEventWireup="true" CodeBehind="Create_Ads.aspx.cs" Inherits="Ad_Service_Management.Retailer.Create_Ads" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div class="panel-heading">
                <h2>
                   CREATE AD'S</h2>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">

                <div class="form-group">
                    <label>
                        Upload Video</label>
                    <%--<asp:TextBox ID="txtUrl" runat="server" class="form-control"></asp:TextBox>--%>
                    <asp:FileUpload ID="FileUpload1" runat="server" class="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Upload Video." ControlToValidate="FileUpload1" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label id="imag">
                        Enter Video Description</label>
                    <asp:TextBox ID="txtDes" runat="server" class="form-control" Width="400" Height="250"
                        TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                         ErrorMessage="Enter Video Description." ControlToValidate="txtDes" ForeColor="Red" 
                         ValidationGroup="a"></asp:RequiredFieldValidator>
                </div>

                 <%--<div class="form-group">
                    <label>
                        Video Posted Date</label>
                    <asp:TextBox ID="txtDt" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                     
                </div>--%>
                                
                <div class="pull-right">
                    <asp:Button ID="Button1" runat="server" Text="ADD" class="btn btn-info" 
                        ValidationGroup="a" onclick="Button1_Click" />
                </div> 
                  
                <br />
                <br />
                <br />

                <div>
                    <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped">
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
                    </asp:GridView>--%>
                </div>
              
                </form>
            </div>
        </div>
    </div>
</asp:Content>
