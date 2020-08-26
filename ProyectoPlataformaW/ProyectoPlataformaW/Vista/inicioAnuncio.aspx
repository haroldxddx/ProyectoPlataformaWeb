﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="inicioAnuncio.aspx.cs" Inherits="ProyectoPlataformaW.Vista.inicioAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <br />
       <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>AdminLTE 3 | User Profile</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <!-- Font Awesome -->
  <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
  <!-- Google Font: Source Sans Pro -->
  <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition sidebar-mini">
<div class="wrapper">
  <div class="content-wrapper">
 <!-- Main content -->

      <asp:Repeater ID="repeaterAnuncio" runat="server">
          <ItemTemplate>

                <section class="content">
      <div class="container-fluid">
        <div class="row">
            <div class="card-body">
                <div class="tab-content">
                  <div class="active tab-pane" id="activity">
                    <!-- Post -->
                    <div class="post">
                      <div class="user-block">
                        <img class="img-circle img-bordered-sm" src="/Vista/dist/img/user1-128x128.jpg" alt="user image">
                        <span class="username">
                          <a href="#">
                              <asp:Label ID="lblNomAp" runat="server" Text='<%# Eval("Nombres") %>'></asp:Label></a>
                               <asp:Label ID="lblAp" runat="server" Text='<%# Eval("Apellidos") %>'></asp:Label></a>
                          <a href="#" class="float-right btn-tool"><i class="fas fa-times"></i></a>
                        </span>
                        <span class="description">Fecha : <asp:Label ID="lblFecha" runat="server" Text='<%# Eval("Fecha") %>'></asp:Label></span>
                      </div>
                      <!-- /.user-block -->
                      <p>
                          <asp:Label ID="lblTitulo" runat="server" Text='<%# Eval("Titulo") %>'></asp:Label>
                                             
                      </p>
                        <p>
                          
                          <asp:Label ID="Label2" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                
                      </p>
                        <p>
                          <asp:Label ID="lblArch" runat="server" Text='<%# Eval("Archivos") %>'></asp:Label>
                      </p>

                    </div>

                   </div>
                 </div>
               </div>
            </div>
        </div>
    </section>

          </ItemTemplate>

      </asp:Repeater>

      <asp:Repeater ID="repeaterProf" runat="server">
          <ItemTemplate>

                <section class="content">
      <div class="container-fluid">
        <div class="row">
            <div class="card-body">
                <div class="tab-content">
                  <div class="active tab-pane" id="activity">
                    <!-- Post -->
                    <div class="post">
                      <div class="user-block">
                        <img class="img-circle img-bordered-sm" src="/Vista/dist/img/user1-128x128.jpg" alt="user image">
                        <span class="username">
                          <a href="#">
                              <asp:Label ID="lblNomApProf" runat="server" Text='<%# Eval("Nombres") %>'></asp:Label></a>
                               <asp:Label ID="lblApP" runat="server" Text='<%# Eval("Apellidos") %>'></asp:Label></a>
                          <a href="#" class="float-right btn-tool"><i class="fas fa-times"></i></a>
                        </span>
                        <span class="description">Fecha : <asp:Label ID="lblFechaP" runat="server" Text='<%# Eval("Fecha") %>'></asp:Label></span>
                      </div>
                      <!-- /.user-block -->
                      <p>
                          <asp:Label ID="lblTituloP" runat="server" Text='<%# Eval("Titulo") %>'></asp:Label>
                                             
                      </p>
                        <p>
                          
                          <asp:Label ID="Label2P" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                
                      </p>
                        <p>
                          <asp:Label ID="lblArchP" runat="server" Text='<%# Eval("Archivos") %>'></asp:Label>
                      </p>

                    </div>

                   </div>
                 </div>
               </div>
            </div>
        </div>
    </section>

          </ItemTemplate>

      </asp:Repeater>

</div>
</div>
<script src="/Vista/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="/Vista/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="/Vista/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="/Vista/dist/js/demo.js"></script>
</body>
</html>
</asp:Content>
