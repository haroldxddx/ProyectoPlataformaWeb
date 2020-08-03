<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="buscadorAprendices.aspx.cs" Inherits="ProyectoPlataformaW.Vista.buscadorAprendices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 172px;
            height: 20px;
            position: absolute;
            top: 195px;
            left: 550px;
        }
        .auto-style3 {
            width: 127px;
            height: 31px;
            position: absolute;
            top: 241px;
            left: 472px;
        }
        .auto-style4 {
            width: 96px;
            height: 22px;
            position: absolute;
            top: 245px;
            left: 622px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Buscador de aprendices"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style3" Text="Flitrar Por Cursos"></asp:Label>
        <asp:DropDownList ID="cmbCurso" runat="server" AutoPostBack="True" CssClass="auto-style4">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
