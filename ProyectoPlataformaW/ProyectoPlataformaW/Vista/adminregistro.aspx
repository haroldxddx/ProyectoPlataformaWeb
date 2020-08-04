<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="adminregistro.aspx.cs" Inherits="ProyectoPlataformaW.Vista.adminregistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
        <asp:TextBox ID="txtnombre" runat="server" placeholder="nombre"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtapellido" runat="server" placeholder="apellido"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtdocumento" runat="server" placeholder="Documento"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtemail" runat="server" placeholder="email"></asp:TextBox>
    </p>
    <asp:TextBox ID="txtcontrasena" runat="server" placeholder="Contraseña"></asp:TextBox>
    <p>
        <asp:TextBox ID="txttipo" runat="server" placeholder="Tipo"></asp:TextBox>
    </p>
    <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Button" />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

