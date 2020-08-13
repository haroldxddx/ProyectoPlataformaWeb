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
        &nbsp;</p>
    <table style="width: 100%;">
        <tr>
            <td>&nbsp; CURSO<td>&nbsp;<asp:DropDownList ID="dpdIdCurso" runat="server"></asp:DropDownList>&nbsp;</td>
            </td>
        </tr>
        <tr>
            <td>&nbsp; PROFESOR</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp; MATERIA</td>
            <td>&nbsp;<asp:DropDownList ID="dpdIdMateria" runat="server"></asp:DropDownList>

                </td>

        </tr>
    </table>
    <p class="auto-style3">
        &nbsp;
    </p>
    <p class="auto-style3">
        &nbsp;</p>
        <asp:GridView ID="gvProfe" runat="server"   ClientIDMode="Static"  >
           <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:CheckBox ID="chbItem" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="IdProfesor" HeaderText="IdProfesor" />
        
    </Columns>
</asp:GridView>

    <p class="auto-style3">
        &nbsp;<asp:Label ID="lblMensaje" runat="server"></asp:Label></p>
    <p class="auto-style3">
<asp:LinkButton ID="lnkContar" runat="server" OnClick="lnkMostrar_Click">Contar</asp:LinkButton>
      &nbsp;
    </p>

</asp:Content>
