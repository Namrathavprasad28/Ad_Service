<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="View_Users.aspx.cs" Inherits="Ad_Service_Management.Admin.View_Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="js/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js" type="text/javascript"></script>
    <link href="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css" rel="Stylesheet" />

     <script type="text/javascript">
         $(function () {
             $("#<%=GridView1.ClientID %>").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
             //$("#GridView1").dataTable();
         });
     </script>

<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div class="panel-heading">
                <h2>
                   VIEW USER</h2>
            </div>
            <br />
            <div class="panel-body">
                <form id="Form1" role="form" runat="server">

                <div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped">
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="Area" HeaderText="Area" />
                            <asp:BoundField DataField="City" HeaderText="City" />
                            <asp:BoundField DataField="Mobile" HeaderText="Mobile" />
                            <asp:BoundField DataField="Email_Id" HeaderText="Email_Id" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        </Columns>
                    </asp:GridView>
                </div>
                
                </form>
            </div>
        </div>
    </div>
</asp:Content>
