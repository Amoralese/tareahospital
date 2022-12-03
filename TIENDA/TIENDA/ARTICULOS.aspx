<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ARTICULOS.aspx.cs" Inherits="TIENDA.ARTICULOS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            NOMBRE:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            PRECIO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TPrecio" runat="server"></asp:TextBox>
            <br />
            <br />
            CODIGOARTICULOS:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TCodigoarticulos" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INGRESAR" />
            <br />
        </div>
    </form>
</body>
</html>
