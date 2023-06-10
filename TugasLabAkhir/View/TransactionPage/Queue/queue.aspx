<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="queue.aspx.cs" Inherits="TugasLabAkhir.View.TransactionPage.Queue.queue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Unhandled Transaction</h2>

    <div>
        <asp:GridView ID="unhandledGV" runat="server" AutoGenerateColumns="false" OnRowCommand="unhandledGV_RowCommand">
            <Columns>
                <asp:BoundField DataField="headerId" HeaderText="Transaction Id"/>
                <asp:BoundField DataField="Date" HeaderText="Transaction Date"/>
                <asp:BoundField DataField="UserName" HeaderText="CustomerName"/>
                <asp:BoundField DataField="StaffId" HeaderText="Staff Id"/>
                <asp:BoundField DataField="StaffName" HeaderText="Staff Name"/>
                <asp:BoundField DataField="totalItem" HeaderText="Total Ramen"/>
                <asp:BoundField DataField="TrStatus" HeaderText="Transaction Status"/>
                <asp:ButtonField ButtonType="Button" Text="Handle" CommandName="handleItem" />
            </Columns>
        </asp:GridView>
    </div>

    <h2>Handled Transaction</h2>

    <div>
        <asp:GridView ID="handledGV" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="headerId" HeaderText="Transaction Id"/>
                <asp:BoundField DataField="Date" HeaderText="Transaction Date"/>
                <asp:BoundField DataField="UserName" HeaderText="Customer Name"/>
                <asp:BoundField DataField="StaffId" HeaderText="Staff Id"/>
                <asp:BoundField DataField="StaffName" HeaderText="Staff Name"/>
                <asp:BoundField DataField="totalItem" HeaderText="Total Ramen"/>
                <asp:BoundField DataField="TrStatus" HeaderText="Transaction Status"/>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
