﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="orderPage.aspx.cs" Inherits="TugasLabAkhir.View.orderRamen.orderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br /><br />

    <div>
        <br />

        <h1>Ramen Data</h1>

        <br />

        <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="False" OnRowCommand="ramenGV_RowCommand">
            <Columns>
                <asp:BoundField DataField="RamenName" HeaderText="Ramen Name" SortExpression="RamenName" />
                <asp:BoundField DataField="Meat.MeatName" HeaderText="Meat" SortExpression="Meat.MeatName" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                
                <asp:TemplateField>
                   <ItemTemplate>
                       <asp:Button ID="orderBtn" runat="server" Text="Order" CommandName="Order" CommandArgument='<%# Container.DataItem %>'  />
                       </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </div>

    <div>
        <br /> <br />

        <h2>Shopping Cart</h2>

        <br />

        <asp:GridView ID="cartGV" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="RamenName" HeaderText="Ramen Name" />
                <asp:BoundField DataField="Meat.MeatName" HeaderText="Meat Name" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            </Columns>
        </asp:GridView>
    </div>


</asp:Content>
