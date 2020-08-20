<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="verNotasActividad.aspx.cs" Inherits="ProyectoPlataformaW.Vista.verNotasActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>AdminLTE 3 | jsGrid</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <!-- Font Awesome -->
  <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
  <!-- jsGrid -->
  <link rel="stylesheet" href="/Vista/plugins/jsgrid/jsgrid.min.css">
  <link rel="stylesheet" href="/Vista/plugins/jsgrid/jsgrid-theme.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
  <!-- Google Font: Source Sans Pro -->
  <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition sidebar-mini">

<div class="wrapper">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
         <div class="card-body">
            
            <ul class="nav nav-tabs" id="custom-content-below-tab" role="tablist">
              <li class="nav-item">
                
                  <asp:LinkButton ID="lkbAsig" runat="server" class="nav-link" href="/Vista/asignarActividadesP.aspx" >Asignacion de Actividades</asp:LinkButton>
              </li>
              <li class="nav-item">
                
                  <asp:LinkButton ID="lkbCalifi" runat="server" class="nav-link" href="/Vista/verEntregasEstudiantes.aspx">Calificacion de Actividades</asp:LinkButton>
              </li>

                 <li class="nav-item">
                
                  <asp:LinkButton ID="lkbNotas" runat="server" class="nav-link" href="/Vista/verNotasActi.aspx">Notas Por Actividades</asp:LinkButton>
              </li>
              
            </ul>
         </div>

        <section class="content">
            <div class="card">
                <div class="card-header">
                    <h3 class="card-title">
                        <br />
                        Notas Por Actividades</h3>
                    <br />
                    &nbsp;<asp:Label ID="lblIdCurso" runat="server"></asp:Label>
                    <br />
                    <br />
                </div>
                <!-- /.card-header -->
                <div class="card-body">
                    
                    <br />
                    <asp:GridView ID="gvProf" class="jsgrid" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbProyectoPlataformaConnectionString1 %>" ProviderName="<%$ ConnectionStrings:dbProyectoPlataformaConnectionString1.ProviderName %>">
                    </asp:SqlDataSource>
                    <br />
                </div>
                <!-- /.card-body -->
            </div>
            <!-- /.card -->
        </section>
    </div>
</div>

    <br />

<!-- jQuery -->
<script src="/Vista/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="/Vista/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- jsGrid -->
<script src="/Vista/plugins/jsgrid/demos/db.js"></script>
<script src="/Vista/plugins/jsgrid/jsgrid.min.js"></script>
<!-- AdminLTE App -->
<script src="/Vista/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="/Vista/dist/js/demo.js"></script>
<!-- page script -->

</body>
</html>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder1">

								

            <!-- LOADER -->
          
          <!-- END LOADER -->

          <!-- Start header -->
                <header class="top-navbar">
                    <nav class="navbar navbar-expand-lg navbar-light bg-light">
                        <div class="container-fluid">
                            <a class="navbar-brand" href="../index.html">&nbsp;<img alt="logo2" class="auto-style1" src="/logo-email-2-g-suite.png" /></a>
                            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbars-host" aria-controls="navbars-rs-food" aria-expanded="false" aria-label="Toggle navigation">
                                <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
                            </button>
                            <div class="collapse navbar-collapse" id="navbars-host">
                                <ul class="navbar-nav ml-auto">
                                    <li class="nav-item dropdown"><a class="nav-link dropdown-toggle" href="#" id="dropdown-a" data-toggle="dropdown">Cursos </a></li>
                                    <li class="nav-item dropdown"><a class="nav-link dropdown-toggle" href="#" id="dropdown-a" data-toggle="dropdown">Estudiantes </a>
                                        <div class="dropdown-menu" aria-labelledby="dropdown-a">
                                            <a class="dropdown-item" href="/Vista/buscadorAprendices.aspx">Buscador de aprendices</a>
                                        </div>
                                    </li>
                                    <li class="nav-item dropdown"><a class="nav-link dropdown-toggle" href="#" id="dropdown-a" data-toggle="dropdown">
                                        <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
                                        </a>
                                        <div class="dropdown-menu" aria-labelledby="dropdown-a">
                                            <a class="dropdown-item" href="/Vista/editarPerfilProf.aspx">Editar Perfil</a>
                                        </div>
                                    </li>
                                    <li class="nav-item">
                                        <asp:LinkButton ID="lbcerrarsesion" class="nav-link"  runat="server" OnClick="lblcerrarsesion_Click" >cerrar sesion</asp:LinkButton>
                                    </li>
                                </ul>
                                <ul class="nav navbar-nav navbar-right">
                                </ul>
                            </div>
                        </div>
                    </nav>
    </header>
          <!-- End header -->
                


                  <script src="js/all.js"></script>
    <!-- ALL PLUGINS -->
    <script src="js/custom.js"></script>
	<script src="js/timeline.min.js"></script>
	<script>
        timeline(document.querySelectorAll('.timeline'), {
            forceVerticalMode: 700,
            mode: 'horizontal',
            verticalStartPosition: 'left',
            visibleItems: 4
        });
    </script>



        
            </asp:Content>

