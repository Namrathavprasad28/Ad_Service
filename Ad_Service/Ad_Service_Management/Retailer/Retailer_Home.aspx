<%@ Page Title="" Language="C#" MasterPageFile="~/Retailer/Retailer.Master" AutoEventWireup="true" CodeBehind="Retailer_Home.aspx.cs" Inherits="Ad_Service_Management.Retailer.Retailer_Home" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 col-sm-12 col-xs-12">
        <div class="panel panel-info">
            <div class="panel-heading">
                <h2>
                   GRAPH</h2>
            </div>
            <br />
            <div class="panel-body">
    <form id="form1" runat="server">
<div>
    <asp:Chart ID="Chart1" runat="server">
        <Series>
            <asp:Series Name="Series1" ChartArea="ChartArea1">
            <Points>
                <asp:DataPoint AxisLabel="Amount" YValues="Amount" />
                <asp:DataPoint AxisLabel="Deduction" YValues="Deduction" />
            </Points>
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
                <AxisX Title="Amount"></AxisX>
                <AxisY Title="Deduction Price"></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
</div>
</form>
</div>
</div>
</div>
</asp:Content>
