<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/Navbar.Master" AutoEventWireup="true" CodeBehind="profilePage.aspx.cs" Inherits="TugasLabAkhir.View.UserDataPage.Profile.profilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Profile</h1>

        <div>
            <asp:GridView ID="profileGV" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="Name" SortExpression="UserName" />
                    <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
                    <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
                </Columns>
            </asp:GridView>
        </div>

        <br />

        <asp:Label ID="nameLbl" runat="server" Text="Username : "></asp:Label>
        <asp:TextBox ID="updNameTbx" runat="server"></asp:TextBox>
        
        <br />

        <asp:Label ID="emailLbl" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="updEmailTbx" runat="server"></asp:TextBox>

        <br />

        <asp:Label ID="genderLbl" runat="server" Text="Gender : "></asp:Label>
        <asp:RadioButtonList ID="updGenderRdb" runat="server">
            <asp:ListItem Value="Male">Male</asp:ListItem>
            <asp:ListItem Value="Female">Female</asp:ListItem>
        </asp:RadioButtonList>

        <br />

        <asp:Label ID="passLbl" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="passTbx" runat="server"></asp:TextBox>

        <br />

        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />

        <br />

        <asp:Label ID="errLbl" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>
