<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="orderPage.aspx.cs" Inherits="TugasLabAkhir.View.RamenDataPage.orderRamen.orderPage" %>
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

    <div>
        <br />

        <h1>Ramen Data</h1>

        <br />

        <asp:Label ID="Label" runat="server" Text=""></asp:Label>

        <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="False" OnRowCommand="ramenGV_RowCommand">
            <Columns>
                <asp:BoundField DataField="RamenId" HeaderText="Ramen Id">
                    <HeaderStyle CssClass="hidden-column" />
                    <ItemStyle CssClass="hidden-column" />
                </asp:BoundField>
                <asp:BoundField DataField="RamenName" HeaderText="Ramen Name"/>
                <asp:BoundField DataField="MeatName" HeaderText="Meat"/>
                <asp:BoundField DataField="Broth" HeaderText="Broth"/>
                <asp:BoundField DataField="Price" HeaderText="Price"/>
                <asp:ButtonField ButtonType="Button" Text="Order" CommandName="orderItem" />
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <br /> <br />

        <h2>Shopping Cart</h2>

        <br />

        <asp:GridView ID="cartGV" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="RamenId" HeaderText="Ramen Id">
                    <HeaderStyle CssClass="hidden-column" />
                    <ItemStyle CssClass="hidden-column" />
                </asp:BoundField>
                <asp:BoundField DataField="RamenName" HeaderText="Ramen Name" />
                <asp:BoundField DataField="MeatName" HeaderText="Meat Name" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="clearBtn" runat="server" Text="Clear Cart" OnClick="clearBtn_Click"/>

        <br />

        <asp:Button ID="btnBuyCart" runat="server" Text="Buy Cart" OnClick="btnBuyCart_Click"/>
    </div>


</asp:Content>
