<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Play_Ad.aspx.cs" Inherits="Ad_Service_Management.User.Play_Ad" %>
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
                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                        class="table table-striped" ShowHeader="False">
                        <Columns>
                             <asp:TemplateField HeaderText="Video">
                            <ItemTemplate>
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("V_Url") %>'></asp:Literal>
                            </ItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <div>
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control" Height="100px" 
                        TextMode="MultiLine" Width="600px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Button ID="Button1" runat="server" Text="Comment" class="btn btn-info" 
                        onclick="Button1_Click" />
                </div>
                <p>________________________________________________________________________________________________________________</p><br />
                <div>
                    <asp:GridView ID="GridView1" BorderStyle="None" CssClass="table-responsive" Width="100%"
                        GridLines="None" runat="server" AutoGenerateColumns="False" ShowHeader="False">
                        <Columns>
                            <asp:BoundField DataField="ParentCommentID" Visible="false" HeaderText="ParentCommentID" />
                            <asp:TemplateField HeaderText="ParentMessage">
                                <ItemTemplate>
                                    <div class="container">
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <table>
                                                    <tr>
                                                        <td style="width: 55px; vertical-align: top; padding-top: 10px">
                                                            <asp:Label ID="lblParentDate" runat="server" Text='<%#Bind("Date") %>'></asp:Label>
                                                            <br />
                                                            <asp:Image ID="ImageParent" runat="server" Style="width: 45px; height: 45px;" ImageUrl='<%#Bind("Image") %>' />
                                                            <asp:Label ID="Label4" Font-Bold="true" ForeColor="#cc0066" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Comment") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lb1COmmenId" runat="server" Visible="false" Text='<%#Eval("Cmt_Pr_Id") %>'></asp:Label>
                                                            <a class="link" id='lnkReplyParent<%#Eval("Cmt_Pr_Id") %>' href="javascript:void(0)"
                                                                onclick="showReply(<%#Eval("Cmt_Pr_Id") %>);return false;">Reply</a> <a class="link"
                                                                    id="lnkCancle" href="javascript:void(0)" onclick="closeReply(<%#Eval("Cmt_Pr_Id") %>);return false;">
                                                                    Cancle</a>
                                                            <div id='divReply<%#Eval("Cmt_Pr_Id") %>' style="display: none; margin-top: 5px;">
                                                                <asp:TextBox ID="textCommentReplyParent" CssClass="input-group" runat="server" Width="300px"
                                                                    TextMode="MultiLine"></asp:TextBox>
                                                                <br />
                                                                <asp:Button ID="btnReplyParent" runat="server" Text="Reply" CssClass="input-group btn"
                                                                    OnClick="btnReplyParent_Click" /></div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="padding-left: 100px; border-bottom: 1px solid #4cff00;">
                                                            <br />
                                                            <asp:GridView ID="GridView2" BorderStyle="None" GridLines="None" runat="server" AutoGenerateColumns="False"
                                                               DataSource='<%# Bind("Empl") %>'  ShowHeader="False">
                                                                <Columns>
                                                                    <asp:TemplateField HeaderText="UserName">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblChildDate" runat="server" Text='<%#Bind("Date") %>'></asp:Label>
                                                                            <br />
                                                                            <asp:Image ID="ImageParent" runat="server" Style="width: 45px; height: 45px;" ImageUrl='<%#Bind("Image") %>' />
                                                                            <asp:Label ID="Label2" runat="server" Font-Bold="true" ForeColor="#ff0066" Text='<%#Bind("Name") %>'></asp:Label>
                                                                            <br />
                                                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Comment") %>'></asp:Label>
                                                                            <hr />
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                            </asp:GridView>
                                                            <br />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <br />
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllDepartmentsandEmployee"
                        TypeName="ParentComment"></asp:ObjectDataSource>
                    <br />
                </div>

                <script src="../Visitor/js/jquery-2.1.4.min.js" type="text/javascript"></script>
                <script type="text/javascript">
                    //GridView Comment  
                    function showReply(n) {
                        $("#divReply" + n).show();
                        return false;
                    }
                    function closeReply(n) {
                        $("#divReply" + n).hide();
                        return false;
                    }  
           
           
                </script>
            </form>
            </div>
        </div>
    </div>
</asp:Content>
