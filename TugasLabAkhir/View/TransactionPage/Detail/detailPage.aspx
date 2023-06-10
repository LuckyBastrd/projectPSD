<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="detailPage.aspx.cs" Inherits="TugasLabAkhir.View.TransactionPage.Detail.detailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="detailGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="headerId" HeaderText="Transaction Id"/>
                <asp:BoundField DataField="Date" HeaderText="Transaction Date"/>
                <asp:BoundField DataField="UserName" HeaderText="Customer Name"/>
                <asp:BoundField DataField="StaffId" HeaderText="Staff Id"/>
                <asp:BoundField DataField="StaffName" HeaderText="Staff Name"/>
                <asp:BoundField DataField="ramenName" HeaderText="Ramen Name"/>
                <asp:BoundField DataField="Broth" HeaderText="Ramen Broth"/>
                <asp:BoundField DataField="Quantity" HeaderText="Total Ramen"/>
                <asp:BoundField DataField="subTotalPrice" HeaderText="Sub Total Price"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
