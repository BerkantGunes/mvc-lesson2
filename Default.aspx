<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ornek2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtSayi1" runat="server" ForeColor="Red"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSayi2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnTopla" runat="server" Text="Topla" OnClick="btnTopla_Click" BackColor="#CC0066" />
            <br />
            <asp:Button ID="btnCikar" runat="server" Text="Çıkar" OnClick="btnCikar_Click" />
            <br />
            <asp:Button ID="btnCarp" runat="server" Text="Çarp" OnClick="btnCarp_Click" />
            <br />
            <asp:Button ID="btnBol" runat="server" Text="Böl" OnClick="btnBol_Click" />
        </div>
    </form>
</body>
</html>
