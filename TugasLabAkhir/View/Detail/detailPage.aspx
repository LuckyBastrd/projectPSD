﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="detailPage.aspx.cs" Inherits="TugasLabAkhir.View.Detail.detailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="detailGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="headerId" HeaderText="Transaction Id"/>
                <asp:BoundField DataField="UserName" HeaderText="Name"/>
                <asp:BoundField DataField="StaffId" HeaderText="Staff Id"/>
                <asp:BoundField DataField="StaffName" HeaderText="Staff Name"/>
                <asp:BoundField DataField="Date" HeaderText="Date"/>
                <asp:BoundField DataField="ramenName" HeaderText="Ramen Name"/>
                <asp:BoundField DataField="Broth" HeaderText="Broth"/>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity"/>
                <asp:BoundField DataField="totalPrice" HeaderText="Total Price"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
