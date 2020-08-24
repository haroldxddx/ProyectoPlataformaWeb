<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ProyectoPlataformaW.Vista.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="dtgExc" runat="server">
    </asp:GridView>
    <asp:Button ID="Button1" runat="server"  Text="Button" />

  

   <asp:FileUpload id="FileUpload1"                 
       runat="server">
   </asp:FileUpload>

   

  
   <asp:Label id="UploadStatusLabel"
       runat="server"> </asp:Label>        


    <asp:HyperLink ID="HiperLink1" runat="server">HyperLink</asp:HyperLink>


    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1">LinkButton</asp:LinkButton>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


</asp:Content>
