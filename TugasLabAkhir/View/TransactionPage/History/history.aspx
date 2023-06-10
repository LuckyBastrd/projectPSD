<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="TugasLabAkhir.View.TransactionPage.History.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--CSS Tipis--%>
    <style>

    .hidden-column {
        display: none;
    }

    </style>

    <br /><br />

    <h3>History</h3>

    <div>
        <asp:GridView ID="tranGV" runat="server" AutoGenerateColumns="false" OnRowCommand="tranGV_RowCommand">
            <Columns>
                <asp:BoundField DataField="headerId" HeaderText="Transaction Id"/>
                <asp:BoundField DataField="Date" HeaderText="Transaction Date"/>
                <asp:BoundField DataField="UserName" HeaderText="Customer Name"/>
                <asp:BoundField DataField="StaffId" HeaderText="Staff Id"/>
                <asp:BoundField DataField="staffName" HeaderText="Staff Name"/>
                <asp:BoundField DataField="totalItem" HeaderText="Total Ramen"/>
                <asp:BoundField DataField="TrStatus" HeaderText="Transaction Status"/>
                <asp:ButtonField ButtonType="Button" Text="Transaction Detail" CommandName="tranDetail" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
