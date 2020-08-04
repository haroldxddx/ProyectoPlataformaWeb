<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="editarPerfilE.aspx.cs" Inherits="ProyectoPlataformaW.Vista.editarPerfilE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 40px;
        height: 21px;
        position: absolute;
        top: 256px;
        left: 349px;
    }
    .auto-style3 {
        width: 155px;
        height: 22px;
        position: absolute;
        top: 253px;
        left: 458px;
    }
        .auto-style4 {
            width: 99px;
            height: 25px;
            position: absolute;
            top: 256px;
            left: 655px;
        }
        .auto-style5 {
            width: 40px;
            height: 21px;
            position: absolute;
            top: 306px;
            left: 346px;
        }
        .auto-style6 {
            width: 154px;
            height: 22px;
            position: absolute;
            top: 303px;
            left: 457px;
            bottom: 316px;
        }
        .auto-style7 {
            width: 99px;
            height: 25px;
            position: absolute;
            top: 395px;
            left: 656px;
        }
        .auto-style8 {
            line-height: 150%;
            text-align: center;
        }
        .auto-style9 {
            width: 40px;
            height: 21px;
            position: absolute;
            top: 353px;
            left: 345px;
        }
        .auto-style10 {
            width: 149px;
            height: 22px;
            position: absolute;
            top: 396px;
            left: 459px;
            bottom: 223px;
        }
        .auto-style11 {
            width: 99px;
            height: 25px;
            position: absolute;
            top: 303px;
            left: 655px;
        }
        .auto-style12 {
            width: 40px;
            height: 26px;
            position: absolute;
            top: 397px;
            left: 345px;
        }
        .auto-style13 {
            width: 151px;
            height: 22px;
            position: absolute;
            top: 351px;
            left: 458px;
            bottom: 268px;
        }
        .auto-style14 {
            width: 99px;
            height: 25px;
            position: absolute;
            top: 351px;
            left: 655px;
        }
        .auto-style15 {
            width: 29px;
            height: 21px;
            position: absolute;
            top: 435px;
            left: 346px;
        }
        .auto-style16 {
            width: 147px;
            height: 22px;
            position: absolute;
            top: 445px;
            left: 458px;
        }
        .auto-style17 {
            width: 99px;
            height: 25px;
            position: absolute;
            top: 444px;
            left: 655px;
        }
        .auto-style18 {
            width: 129px;
            height: 34px;
            position: absolute;
            top: 512px;
            left: 345px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        &nbsp;</p>
<p class="auto-style8">
    Editar Informacion Personal Estudiante</p>
    <p>
        &nbsp;</p>
<p>
    <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNom" runat="server" CssClass="auto-style3" Enabled="False"></asp:TextBox>
    <asp:CheckBox ID="chbN" runat="server" AutoPostBack="True" CssClass="auto-style4"/>
</p>
<p>
    &nbsp;</p>
    <p>
        <asp:TextBox ID="txtDoc" runat="server" CssClass="auto-style13" Enabled="False"></asp:TextBox>
        <asp:Label ID="lbl3" runat="server" CssClass="auto-style9" Text="Documento"></asp:Label>
        <asp:CheckBox ID="chbD" runat="server" AutoPostBack="True" CssClass="auto-style14" />
    </p>
    <p>
        <asp:Label ID="lbl2" runat="server" CssClass="auto-style5" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="txtAp" runat="server" CssClass="auto-style6" Enabled="False"></asp:TextBox>
        <asp:CheckBox ID="chbA" runat="server" AutoPostBack="True" CssClass="auto-style11" />
        <asp:Label ID="lbl4" runat="server" CssClass="auto-style12" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style10" Enabled="False"></asp:TextBox>
        <asp:CheckBox ID="chbE" runat="server" AutoPostBack="True" CssClass="auto-style7" />
    </p>
    <p>
        <asp:Label ID="lblC" runat="server" CssClass="auto-style15" Text="Cambiar Contraseña"></asp:Label>
        <asp:TextBox ID="txtCo" runat="server" CssClass="auto-style16" Enabled="False"></asp:TextBox>
        <asp:CheckBox ID="cbhC" runat="server" AutoPostBack="True" CssClass="auto-style17" />
    </p>
    <p>
        &nbsp;</p>
    <asp:Button ID="btnEditar" runat="server" CssClass="auto-style18" OnClick="btnEditar_Click" Text="Editar Informacion" />
    <p>
        &nbsp;</p>
<p>
    <br />
</p>
</asp:Content>
