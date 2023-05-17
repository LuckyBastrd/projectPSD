<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerHome.aspx.cs" Inherits="TugasLabAkhir.View.Register.registerHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>REGISTER</h1>

            <br />

            <asp:Label ID="userLbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="userTbx" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTbx" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="genderRdb" runat="server">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem Value="Female">Female</asp:ListItem>
            </asp:RadioButtonList>

            <br />

            <asp:Label ID="passLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passTbx" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="confirmLbl" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="confirmTbx" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="roleLbl" runat="server" Text="Role"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                 <asp:ListItem Value="1">Staff</asp:ListItem>
                 <asp:ListItem Value="2">Admin</asp:ListItem>
                 <asp:ListItem Value="1">Member</asp:ListItem>
            </asp:DropDownList>

            <br /><br />

            <asp:Button ID="registBtn" runat="server" Text="Register" />

        </div>
    </form>
</body>
</html>
