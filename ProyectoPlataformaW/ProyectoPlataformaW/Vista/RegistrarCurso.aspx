﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="registrarCurso.aspx.cs" Inherits="ProyectoPlataformaW.Vista.RegistrarCurso" %>
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
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRAR CURSO<asp:Image ID="Image3" runat="server" Height="100px" ImageUrl="~/Imagenes/video.png" Width="112px" />
            </strong></p>
    <p style="text-align: center" class="auto-style2"  >
        
        <br />
        <br />
       
       
    <div style="text-align:center;">
	<table border="1" style="margin: 0 auto;">
    <table border="1" class="w-100">
    <table class="table table-bordered table-hover table-activ border-warning">
   
        <tr>
            <td class="auto-style5 border-warning">GRADO </td>
            <td class="border-warning" >
                <asp:DropDownList ID="dplGrado" runat="server" Height="21px" Width="175px">
                    <asp:ListItem Value="Quinder"></asp:ListItem>
                    <asp:ListItem Value="Primero"></asp:ListItem>
                    <asp:ListItem Value="Segundo"></asp:ListItem>
                    <asp:ListItem>Tercero</asp:ListItem>
                    <asp:ListItem>Cuarto</asp:ListItem>
                    <asp:ListItem>Quinto</asp:ListItem>
                    <asp:ListItem>Sexto</asp:ListItem>
                    <asp:ListItem>Septimo</asp:ListItem>
                    <asp:ListItem>Octavo</asp:ListItem>
                    <asp:ListItem>Noveno</asp:ListItem>
                    <asp:ListItem>Decimo</asp:ListItem>
                    <asp:ListItem>Once</asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style5 border-warning">&nbsp;CURSO</td>
            <td class="border-warning" >&nbsp;<asp:TextBox ID="txtCur" BorderColor="#4C5A7D" runat="server" Width="266px"></asp:TextBox></td>

            </tr>
      
            
        
       </div>
    </table>
    <div _designerregion="0">
        <br />

        <div </div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" runat="server" Height="25px" ImageUrl="~/Imagenes/registro.png" Width="27px" />

            <asp:Button ID="btnRegistrarC" runat="server" class="btn btn-outline-auto auto-style6 " Text="REGISTRAR" OnClick="btnRegistrarE_Click"  Height="36px" Width="220px" /> 
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
            <br />
            <br />
         <br />
        </div>

       <div
           <br />
           &nbsp;
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           &nbsp;<br />
           <br />
           <br />
        </div>

    </div>

</asp:Content>