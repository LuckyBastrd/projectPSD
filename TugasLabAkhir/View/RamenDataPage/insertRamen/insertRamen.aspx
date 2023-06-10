<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertRamen.aspx.cs" Inherits="TugasLabAkhir.View.RamenDataPage.insertRamen.insertRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="backBtn" runat="server" Text="Manage Ramen" OnClick="backBtn_Click" /><br /><br />

            <asp:Label ID="ramenNameLbl" runat="server" Text="Ramen Name : "></asp:Label>
            <asp:TextBox ID="ramenNameTbx" runat="server"></asp:TextBox><br />

            <asp:Label ID="meatLbl" runat="server" Text="Meat : "></asp:Label>
            <asp:DropDownList ID="meatDdl" runat="server">
                 <asp:ListItem Value="1">Beef</asp:ListItem>
                 <asp:ListItem Value="2">Tori</asp:ListItem>
                 <asp:ListItem Value="3">Cha-su</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="brothLbl" runat="server" Text="Broth : "></asp:Label>
            <asp:TextBox ID="brothTbx" runat="server"></asp:TextBox><br />

            <asp:Label ID="priceLbl" runat="server" Text="Price : "></asp:Label>
            <asp:TextBox ID="priceTbx" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="addRamenBtn" runat="server" Text="Add Ramen" OnClick="addRamenBtn_Click" /><br /><br />
            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
