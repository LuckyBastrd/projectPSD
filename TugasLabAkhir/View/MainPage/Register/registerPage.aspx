<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerPage.aspx.cs" Inherits="TugasLabAkhir.View.MainPage.Register.registerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>REGISTER</h1>

            <br />

            <asp:Label ID="userLbl" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="userTbx" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="emailLbl" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="emailTbx" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="genderLbl" runat="server" Text="Gender : "></asp:Label>
            <asp:RadioButtonList ID="genderRdb" runat="server">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem Value="Female">Female</asp:ListItem>
            </asp:RadioButtonList>

            <br />

            <asp:Label ID="passLbl" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="passTbx" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="confirmLbl" runat="server" Text="Confirm Password : "></asp:Label>
            <asp:TextBox ID="confirmTbx" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Button ID="registBtn" runat="server" Text="Register" OnClick="registBtn_Click" /><br /><br />

            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label><br /><br />

            <h5>Already have an account</h5>
            <asp:LinkButton ID="loginLbtn" runat="server" OnClick="loginLbtn_Click">Log-in</asp:LinkButton>

        </div>
    </form>
</body>
</html>
