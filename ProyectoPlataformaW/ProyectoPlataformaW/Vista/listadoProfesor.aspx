<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="listadoProfesor.aspx.cs" Inherits="ProyectoPlataformaW.Vista.listadoProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 322px;
        height: 173px;
        position: absolute;
        top: 273px;
        left: 417px;
    }
    .auto-style3 {
        line-height: 150%;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p class="auto-style3">
    &nbsp;</p>
<p class="auto-style3">
    &nbsp;</p>
<p class="auto-style3">
    Listado de Profesores</p>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<asp:GridView ID="gvProf" runat="server" CellPadding="4" CssClass="auto-style2" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
</asp:Content>
