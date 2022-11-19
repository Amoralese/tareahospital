<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="Hospitales.Pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="RSEGUROSI">
            <asp:GridView ID="GridView1" runat="server" Height="166px" Width="284px">
            </asp:GridView>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            CEDULA:&nbsp;&nbsp;
            <asp:TextBox ID="TCedula" runat="server"></asp:TextBox>
            <br />
            <br />
            NOMBRE:&nbsp;
            <asp:TextBox ID="TNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BBuscar" runat="server" OnClick="BBuscar_Click" Text="BUSCAR" Width="72px" />
            <br />
            <br />
            EDAD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TEdad" runat="server"></asp:TextBox>
            <br />
            <br />
            SEXO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DSexo" runat="server">
                <asp:ListItem Value="M">Masculino</asp:ListItem>
                <asp:ListItem Value="F">Femenino</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            PROVINCIA:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DProvincia" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CANTON:&nbsp;&nbsp;
            <asp:DropDownList ID="DCanton" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DISTRITO:&nbsp;
            <asp:DropDownList ID="DDistrito" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            TELEFONO:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TTelefono" runat="server"></asp:TextBox>
            <br />
            <br />
            ASEGURADO:&nbsp;
            <asp:RadioButton ID="RSEGUROSI" runat="server" GroupName="SEGURO" Text="SI" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RSEGURONO" runat="server" GroupName="SEGURO" Text="NO" />
            <br />
            <br />
            <asp:Button ID="BINGRESAR" runat="server" Height="29px" OnClick="BINGRESAR_Click" Text="INGRESAR" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BBORRAR" runat="server" CssClass="auto-style1" Height="27px" OnClick="BBORRAR_Click" Text="BORRAR" Width="72px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BActualizar" runat="server" OnClick="BActualizar_Click" Text="ACTUALIZAR" Width="93px" />
&nbsp;&nbsp;
            <asp:Button ID="BPromedioEdad" runat="server" OnClick="BPromedioEdad_Click" Text="PROMEDIO EDAD" Width="134px" />
&nbsp;&nbsp;
            <asp:Button ID="BCantidadmujeresyhombres" runat="server" OnClick="BCantidadmujeresyhombres_Click" Text="CANTIDAD DE MUJERES Y HOMBRES" Width="271px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
