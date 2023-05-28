﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="TugasLabAkhir.View.History.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>History</h3>

    <div>
        <asp:GridView ID="tranGV" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="HeaderId" HeaderText="ID"/>
                <asp:BoundField DataField="UserName" HeaderText="Name"/>
                <asp:BoundField DataField="StaffId" HeaderText="Staff Id"/>
                <asp:BoundField DataField="Date" HeaderText="Date"/>
                <asp:BoundField DataField="totalItem" HeaderText="Total Item"/>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <asp:GridView ID="totalGv" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="totalItem" HeaderText="Total Item"/>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <asp:GridView ID="detailGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="HeaderId" HeaderText="Transaction ID" SortExpression="HeaderId" />
                <asp:BoundField DataField="Header.UserId" HeaderText="User ID" SortExpression="Header.UserId" />
               <%-- <asp:BoundField DataField="2" HeaderText="Staff ID" SortExpression="2" />--%>
                <asp:BoundField DataField="Header.Date" HeaderText="Date" SortExpression="Header.Date" />
                <asp:BoundField DataField="Ramen.RamenName" HeaderText="Ramen Name" SortExpression="Ramen.RamenName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:CommandField ButtonType="Button" HeaderText="View Detail" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
            
        </asp:GridView>
    </div>



</asp:Content>
