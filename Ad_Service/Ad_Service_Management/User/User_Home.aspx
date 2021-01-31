<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="User_Home.aspx.cs" Inherits="Ad_Service_Management.User.User_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="outer-w3-agile col-xl">
                        <div class="stat-grid p-3 d-flex align-items-center justify-content-between bg-primary">
                            <div class="s-l">
                                <h5>Ad's</h5>
                                
                            </div>
                            <div class="s-r">
                                <h6>
                                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                    <i class="far fa-edit"></i>
                                </h6>
                            </div>
                        </div>
                        <div class="stat-grid p-3 mt-3 d-flex align-items-center justify-content-between bg-success">
                            <div class="s-l">
                                <h5>Message</h5>
                               
                            </div>
                            <div class="s-r">
                                <h6>
                                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                    <i class="far fa-smile"></i>
                                </h6>
                            </div>
                        </div>
                        <%--<div class="stat-grid p-3 mt-3 d-flex align-items-center justify-content-between bg-danger">
                            <div class="s-l">
                                <h5>Tasks</h5>
                                <p class="paragraph-agileits-w3layouts">Lorem Ipsum</p>
                            </div>
                            <div class="s-r">
                                <h6>232
                                    <i class="fas fa-tasks"></i>
                                </h6>
                            </div>
                        </div>
                        <div class="stat-grid p-3 mt-3 d-flex align-items-center justify-content-between bg-warning">
                            <div class="s-l">
                                <h5>Employees</h5>
                                <p class="paragraph-agileits-w3layouts">Lorem Ipsum</p>
                            </div>
                            <div class="s-r">
                                <h6>190
                                    <i class="fas fa-users"></i>
                                </h6>
                            </div>
                        </div>--%>
                    </div>
</asp:Content>
