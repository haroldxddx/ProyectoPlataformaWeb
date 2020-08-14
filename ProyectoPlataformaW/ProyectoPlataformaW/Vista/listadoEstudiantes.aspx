<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="listadoEstudiantes.aspx.cs" Inherits="ProyectoPlataformaW.Vista.listadoEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <asp:GridView ID="gvlistEstudiante" runat="server"></asp:GridView>
    <asp:Button ID="btnDescargar" runat="server" Text="Button" OnClick="btnDescargar_Click" />
</asp:Content>
