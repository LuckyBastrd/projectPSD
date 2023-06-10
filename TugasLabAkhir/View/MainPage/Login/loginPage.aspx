<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="TugasLabAkhir.View.MainPage.Login.loginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>

            <asp:Label ID="nameLbl" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="nameTbx" runat="server"></asp:TextBox>
            
            <br />

            <asp:Label ID="passwordLbl" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="passwordTbx" runat="server"></asp:TextBox>
            
            <br />

            <asp:CheckBox ID="rememberChb" runat="server" />
            <asp:Label ID="rememberLbl" runat="server" Text="Remember Me"></asp:Label>
            
            <br />
            <br />

            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
            
            <br />

            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>

            <br />
            <br />

            <asp:LinkButton ID="registerLbtn" runat="server" OnClick="registerLbtn_Click">Register</asp:LinkButton>

        </div>
    </form>
</body>
</html>
