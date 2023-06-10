<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateRamen.aspx.cs" Inherits="TugasLabAkhir.View.RamenDataPage.updateRamen.updateRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Update Ramen</h2>

            <asp:Button ID="returnBtn" runat="server" Text="Manage Ramen" OnClick="returnBtn_Click" /><br /><br />

            <div>
                <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:BoundField DataField="RamenId" HeaderText="Ramen ID" SortExpression="RamenId" />
                        <asp:BoundField DataField="RamenName" HeaderText="Ramen name" SortExpression="RamenName" />
                        <asp:BoundField DataField="Meat.MeatName" HeaderText="Meat" SortExpression="Meat.MeatName" />
                        <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth" />
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    </Columns>
                </asp:GridView>
            </div>

            <br /><br />
            <asp:Label ID="updRamenNameLbl" runat="server" Text="Ramen Name : "></asp:Label>
            <asp:TextBox ID="updRamenNameTbx" runat="server"></asp:TextBox><br />

            <asp:Label ID="updMeatLbl" runat="server" Text="Meat : "></asp:Label>
            <asp:DropDownList ID="updMeatDdl" runat="server">
                <asp:ListItem Value="1">Beef</asp:ListItem>
                <asp:ListItem Value="2">Tori</asp:ListItem>
                <asp:ListItem Value="3">Cha-su</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="updBrothLbl" runat="server" Text="Broth : "></asp:Label>
            <asp:TextBox ID="updBrothTbx" runat="server"></asp:TextBox><br />

            <asp:Label ID="updPriceLbl" runat="server" Text="Price : "></asp:Label>
            <asp:TextBox ID="updPriceTbx" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="updateRamenBtn" runat="server" Text="Update Ramen" OnClick="updateRamenBtn_Click" /><br /><br />

            <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
