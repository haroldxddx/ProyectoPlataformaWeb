<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="asignarProfesorCursoMateria.aspx.cs" Inherits="ProyectoPlataformaW.Vista.asignarProfesorCursoMateria" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            line-height: 150%;
            text-align: center;
        }
    </style>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p class="auto-style3">
        &nbsp;
    </p>
    <p class="auto-style3">
        &nbsp;
    </p>


    <p class="auto-style3">
        ASIGNAR PROFESOR A UN CURSO Y UNA MATERIA
    </p>

    <p class="auto-style3">
        &nbsp;
        &nbsp;
    
    </p>
    <p class="auto-style3">
        &nbsp;
    </p>
    <table style="width: 100%;">
        <tr>
            <td>&nbsp; CURSO<td>&nbsp;&nbsp;<asp:GridView ID="gvCurso" runat="server" ClientIDMode="Static" Width="432px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chbItemC" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

        <asp:Label ID="lblMensajeC" runat="server" Visible="False"></asp:Label>

            <br />

            </td>
            </td>
        </tr>
        <tr>
            <td>&nbsp; PROFESOR</td>
            <td>

                <asp:GridView ID="gvProfe" runat="server" ClientIDMode="Static" Width="432px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chbItem" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

        <asp:Label ID="lblMensaje" runat="server" Visible="False"></asp:Label>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp; MATERIA</td>
            <td>&nbsp;<asp:GridView ID="gvMateria" runat="server" ClientIDMode="Static" Width="427px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chbItemM" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

        <asp:Label ID="lblMensajeM" runat="server" Visible="False"></asp:Label>

            </td>

        </tr>
    </table>
    <p class="auto-style3">
        &nbsp;
    </p>
    <p class="auto-style3">
        &nbsp;
    </p>

    <p class="auto-style3">
        &nbsp;</p>
    <p class="auto-style3">
        <asp:LinkButton ID="lnkGuardar" runat="server" OnClick="lnkGuardar_Click">GUARDAR</asp:LinkButton>
        &nbsp;
    </p>

</asp:Content>
