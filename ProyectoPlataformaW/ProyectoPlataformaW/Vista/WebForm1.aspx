<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProyectoPlataformaW.Vista.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:TemplateField>
               <ItemTemplate>
                    <asp:CheckBox ID="chbItemC" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>


    </asp:GridView> </asp:Content>

