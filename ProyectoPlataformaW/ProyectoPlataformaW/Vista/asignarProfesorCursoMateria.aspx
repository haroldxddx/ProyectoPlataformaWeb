<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="asignarProfesorCursoMateria.aspx.cs" Inherits="ProyectoPlataformaW.Vista.asignarProfesorCursoMateria" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 320px;
            height: 173px;
            position: absolute;
            top: 306px;
            left: 704px;
        }

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
    <asp:GridView ID="gvProf" runat="server" CellPadding="4" CssClass="auto-style2" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>

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
            <td>&nbsp;<asp:DropDownList ID="dpdIdProfe" runat="server"></asp:DropDownList>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdCursoMateria" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
            <Columns>
                <asp:BoundField DataField="IdCursoMateria" HeaderText="IdCursoMateria" ReadOnly="True" SortExpression="IdCursoMateria" />
                <asp:BoundField DataField="IdCurso" HeaderText="IdCurso" SortExpression="IdCurso" />
                <asp:BoundField DataField="IdMateria" HeaderText="IdMateria" SortExpression="IdMateria" />
                <asp:BoundField DataField="IdProfesor" HeaderText="IdProfesor" SortExpression="IdProfesor" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbProyectoPlataformaConnectionString1 %>" DeleteCommand="DELETE FROM [CursoMateria] WHERE [IdCursoMateria] = @IdCursoMateria" InsertCommand="INSERT INTO [CursoMateria] ([IdCurso], [IdMateria], [IdProfesor]) VALUES (@IdCurso, @IdMateria, @IdProfesor)" OnSelecting="SqlDataSource1_Selecting" ProviderName="<%$ ConnectionStrings:dbProyectoPlataformaConnectionString1.ProviderName %>" SelectCommand="SELECT [IdCursoMateria], [IdCurso], [IdMateria], [IdProfesor] FROM [CursoMateria]" UpdateCommand="UPDATE [CursoMateria] SET [IdCurso] = @IdCurso, [IdMateria] = @IdMateria, [IdProfesor] = @IdProfesor WHERE [IdCursoMateria] = @IdCursoMateria">
            <DeleteParameters>
                <asp:Parameter Name="IdCursoMateria" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="IdCurso" Type="Int32" />
                <asp:Parameter Name="IdMateria" Type="Int32" />
                <asp:Parameter Name="IdProfesor" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="IdCurso" Type="Int32" />
                <asp:Parameter Name="IdMateria" Type="Int32" />
                <asp:Parameter Name="IdProfesor" Type="Int32" />
                <asp:Parameter Name="IdCursoMateria" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p class="auto-style3">
        &nbsp;</p>
    <p class="auto-style3">
        &nbsp;</p>
    <p class="auto-style3">
      <asp:Button ID="btnAsignar" runat="server" Text="ASIGNAR" OnClick="Button1_Click" />
      &nbsp;
    </p>

</asp:Content>
