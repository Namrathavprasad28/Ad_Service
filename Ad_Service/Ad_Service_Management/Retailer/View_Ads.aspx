<%@ Page Title="" Language="C#" MasterPageFile="~/Retailer/Retailer.Master" AutoEventWireup="true" CodeBehind="View_Ads.aspx.cs" Inherits="Ad_Service_Management.Retailer.View_Ads" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div class="panel-heading">
                <h2>
                   VIEW RETAILER AD'S</h2>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">

                <div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped">
                        <Columns>
                            <asp:BoundField DataField="Description" HeaderText="Description " />
                            <asp:BoundField DataField="Posted_Date" HeaderText="Posted_Date" />
                            <asp:TemplateField HeaderText="Video">
                                <ItemTemplate>
                                    <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("V_Url") %>'></asp:Literal>
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
