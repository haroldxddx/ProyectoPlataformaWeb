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
            top: 298px;
            left: 435px;
        }
        .auto-style4 {
            width: 96px;
            height: 22px;
            position: absolute;
            top: 298px;
            left: 587px;
        }
        .auto-style5 {
            width: 135px;
            height: 35px;
            position: absolute;
            top: 254px;
            left: 392px;
        }
    .auto-style6 {
        width: 316px;
        height: 186px;
        position: absolute;
        top: 345px;
        left: 424px;
    }
    .auto-style7 {
        width: 152px;
        height: 22px;
        position: absolute;
        top: 251px;
        left: 535px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Buscador de Estudiantes"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style3" Text="Flitrar Por Cursos"></asp:Label>
        <asp:DropDownList ID="cmbCurso" runat="server" AutoPostBack="True" CssClass="auto-style4" OnSelectedIndexChanged="cmbCurso_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="txtNombreE" runat="server" CssClass="auto-style7" AutoCompleteType="Search" AutoPostBack="True" OnTextChanged="txtNombreE_TextChanged"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Buscar por nombre"></asp:Label>
        <asp:Label ID="lblCurso" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
    <p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        <asp:GridView ID="gvEstu" runat="server" CellPadding="4" CssClass="auto-style6" ForeColor="#333333" GridLines="None">
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
</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
