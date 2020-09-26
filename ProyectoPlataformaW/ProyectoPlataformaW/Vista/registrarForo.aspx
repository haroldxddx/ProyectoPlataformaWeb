<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="registrarForo.aspx.cs" Inherits="ProyectoPlataformaW.Vista.registrarForo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 362px;
        }

        .auto-style4 {
            width: 362px;
            height: 39px;
        }

        .auto-style5 {
            height: 39px;
        }

        .auto-style6 {
            width: 362px;
            height: 40px;
        }

        .auto-style7 {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblFecha" runat="server" Text="Label"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style4">Titulo del foro</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtTitulo" runat="server" Width="287px"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="auto-style6">Decripción </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtDescripcion" runat="server" Height="172px" Width="406px"></asp:TextBox>
            </td>

        </tr>
        

        </tr>    
                <tr>
            <td class="auto-style4">Añadir imagen</td>
            <td class="auto-style5">
                <asp:FileUpload ID="flupImagen" runat="server" />
         
            </td>

        </tr>
          
                <tr>
            <td class="auto-style4">Añadir archivo</td>
            <td class="auto-style5">
                <asp:FileUpload ID="flupArchivo" runat="server" />
         
            </td>

        </tr>
        <tr>
            <td class="auto-style3">Tipo de foro</td>
            <td>
                <asp:DropDownList ID="dpdTipo" runat="server" >
                    <asp:ListItem>Preguntas</asp:ListItem>
                    <asp:ListItem>Evaluacion </asp:ListItem>
                    <asp:ListItem>Datos Personales</asp:ListItem>
                </asp:DropDownList>
                 </td>
            <tr>
            <td class="auto-style3">Actividad</td>
            <td>
                <asp:DropDownList ID="dpdActividad" runat="server">
                </asp:DropDownList>
                 <asp:Button ID="btnRegistrar" runat="server" Text="Button" OnClick="btnRegistrar_Click" />
                 </td>

    </table>
</asp:Content>
