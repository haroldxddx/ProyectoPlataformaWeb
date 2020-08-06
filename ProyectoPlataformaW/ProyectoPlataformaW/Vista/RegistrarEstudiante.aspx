<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="registrarEstudiante.aspx.cs" Inherits="ProyectoPlataformaW.Vista.RegistrarEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
   <style type="text/css">
        .auto-style2 {
            color: #EEA412;
        }
    </style>
    <style type="text/css">
        .auto-style5 {
            width: 699px;
            color: #EEA412;
           
        }
    </style>
    <style type="text/css">
        .auto-style6 {
            background-color: #4C5A7D;
            color:aliceblue;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div>
        <html>

<body>
    <h2> 
        <br />
        <br />
        <p style="text-align: center" class="auto-style2"  >
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRAR ESTUDIANTE<asp:Image ID="Image4" runat="server" Height="100px" ImageUrl="~/Imagenes/estudiante.png" Width="112px" />
            </strong></p>
    <p style="text-align: center" class="auto-style2"  >
        
        <br />
        <br />
       
       
    </h2>
    <div style="text-align:center;">
	<table border="1" style="margin: 0 auto;">
    <table border="1" class="w-100">
    <table class="table table-bordered table-hover table-activ border-warning">
   
        <tr>
            <td class="auto-style5 border-warning">&nbsp;NOMBRES </td>
            <td class="border-warning" >&nbsp;<asp:TextBox  ID="txtNom" BorderColor="#4C5A7D" runat="server" CssClass="offset-sm-0 " Width="266px"></asp:TextBox> </td>
            </tr>
        <tr>
            <td class="auto-style5 border-warning">&nbsp;APELLIDOS</td>
            <td class="border-warning" >&nbsp;<asp:TextBox ID="txtApe" BorderColor="#4C5A7D" runat="server" Width="266px"></asp:TextBox></td>

            </tr>
        <tr>
            <td class="auto-style5 border-warning">&nbsp;DOCUMENTO</td>
            <td class="border-warning">&nbsp;<asp:TextBox ID="txtDoc" BorderColor="#4C5A7D" runat="server" Width="266px"></asp:TextBox></td>

            </tr>
        <tr>
            <td class="auto-style5 border-warning">&nbsp;EMAIL</td>
            <td class="border-warning">&nbsp;<asp:TextBox ID="txtEma" BorderColor="#4C5A7D" runat="server" Width="266px"></asp:TextBox></td>

            </tr>
        <tr>
            <td class="auto-style5 border-warning">&nbsp;CONTRASEÑA</td>
            <td class="border-warning">&nbsp;<asp:TextBox ID="txtCon" BorderColor="#4C5A7D" runat="server" Width="266px" ></asp:TextBox></td>

            </tr>
        <tr>
            <td class="auto-style5 border-warning">&nbsp;CURSO</td>
           <td class="border-warning">
               <asp:DropDownList ID="dpdCurso" runat="server" Height="26px" OnSelectedIndexChanged="dpdCurso_SelectedIndexChanged" Width="115px">
               </asp:DropDownList>
            </td>
            
        </tr>
       </div>
    </table>
    <div _designerregion="0">
        <br />

        <div </div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" runat="server" Height="25px" ImageUrl="~/Imagenes/registro.png" Width="27px" />

            <asp:Button ID="btnRegistrarE" runat="server" class="btn btn-outline-auto auto-style6 " Text="REGISTRAR" OnClick="btnRegistrarE_Click"  Height="36px" Width="220px" /> 
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
            <br />
            <br />
         <br />
        </div>

       <div
           <br />
           &nbsp;
           &nbsp;<asp:Image ID="Image1" runat="server" Height="24px" ImageUrl="~/Imagenes/sobresalir (2).png" Width="27px" />
           <asp:Button ID="btnSubirAr" btn=hover runat="server" Class="btn btn-outline-auto auto-style6" Text="SUBIR ARCHIVO" Height="36px" Width="191px" BorderColor="White" ForeColor="White" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Image ID="Image3" runat="server" Height="29px" ImageUrl="~/Imagenes/descarga-directa (2).png" Width="33px" />
           &nbsp;<asp:Button ID="btnDescargarF" btn=hover runat="server" Class="btn btn-outline-auto auto-style6" Text="DESCARGAR FORMATO" Height="36px" Width="191px" BorderColor="White" ForeColor="White" />
           <br />
           <br />
           <br />
        </div>

    </div>

</asp:Content>
