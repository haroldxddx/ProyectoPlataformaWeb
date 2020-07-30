<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="correoPrueba.aspx.cs" Inherits="ProyectoPlataformaW.correoPrueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
            <br />
        </div>
    </form>
</body>
</html>
