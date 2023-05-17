<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guestLogin.aspx.cs" Inherits="TugasLabAkhir.View.Login.guestLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="usernameLbl" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="usernameTbx" runat="server"></asp:TextBox><br />

            <asp:Label ID="passLbl" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="passTbx" runat="server"></asp:TextBox><br /><br />

            <asp:CheckBox ID="rememberChb" runat="server" />
            <asp:Label ID="rememberLbl" runat="server" Text="Remember Me"></asp:Label><br />

            <asp:Button ID="loginBtn" runat="server" Text="Login" /><br />

            <asp:Label ID="statLbl" runat="server" Text=""></asp:Label><br />

            <asp:LinkButton ID="registerLk" runat="server" OnClick="registerLk_Click">Register</asp:LinkButton>
        </div>
    </form>
</body>
</html>
