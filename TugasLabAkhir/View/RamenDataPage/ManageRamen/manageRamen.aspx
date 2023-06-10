<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="manageRamen.aspx.cs" Inherits="TugasLabAkhir.View.RamenDataPage.ManageRamen.manageRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="ramenGV_RowDeleting" OnRowEditing="ramenGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="RamenId" HeaderText="Ramen ID" SortExpression="RamenId" />
                <asp:BoundField DataField="RamenName" HeaderText="Ramen name" SortExpression="RamenName" />
                <asp:BoundField DataField="Meat.MeatName" HeaderText="Meat" SortExpression="Meat.MeatName" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>

        </asp:GridView>
    </div>

    <div>
        <br />
        <asp:Button ID="insertRamenBtn" runat="server" Text="Insert Ramen" OnClick="insertRamenBtn_Click" />
    </div>

</asp:Content>
