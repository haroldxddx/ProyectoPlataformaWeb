<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="listadoMateriasAsignadoCurso.aspx.cs" Inherits="ProyectoPlataformaW.Vista.listadoMateriasAsignadoaACurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:TextBox ID="txtBuscarC" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscarC" runat="server" Text="Button" OnClick="btnBuscarC_Click" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
