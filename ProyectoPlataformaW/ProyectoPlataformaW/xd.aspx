<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xd.aspx.cs" Inherits="ProyectoPlataformaW.xd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtNomAc" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtFechaIni" runat="server" TextMode="Date"></asp:TextBox>
        <asp:Label ID="lblCursoM" runat="server" Text="1"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtFechaFn" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        <asp:FileUpload ID="fluArchivo" runat="server" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </form>
</body>
</html>
