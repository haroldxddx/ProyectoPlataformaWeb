<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ProyectoPlataformaW.Vista.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="dtgExc" runat="server">
    </asp:GridView>
    <asp:Table ID="Table1" runat="server">
    </asp:Table>
    <asp:Button ID="Button1" runat="server"  Text="Button"  />

  

   <asp:FileUpload id="FileUpload1"                 
       runat="server" OnClick="UploadButton_Click">
   </asp:FileUpload>

   

  
   <asp:Label id="UploadStatusLabel"
       runat="server"> </asp:Label>        


    <asp:HyperLink ID="HiperLink1" runat="server">HyperLink</asp:HyperLink>


    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>


</asp:Content>
