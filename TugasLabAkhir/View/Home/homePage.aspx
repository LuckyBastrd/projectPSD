<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="TugasLabAkhir.View.Home.homePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br /><br />

    <div>
        <asp:GridView ID="customerGV" runat="server" AutoGenerateColumns="false">
            <%--<Columns>
                <asp:BoundField DataField="UserId" HeaderText="Id" SortExpression="UserID"/>
                <asp:BoundField DataField="RoleId.RoleName" HeaderText="Role" SortExpression="RoleId.RoleName"/>
                <asp:BoundField DataField="UserName" HeaderText="Name" SortExpression="UserName"/>
                <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail"/>
                <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender"/>
                <asp:BoundField DataField="UserPassword" HeaderText="Password" SortExpression="UserPassword"/>
            </Columns>--%>     
        </asp:GridView>
    </div>

    <div>
        <asp:GridView ID="staffGV" runat="server"></asp:GridView>
    </div>

</asp:Content>


