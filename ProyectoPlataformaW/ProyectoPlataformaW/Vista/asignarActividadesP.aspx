<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="asignarActividadesP.aspx.cs" Inherits="ProyectoPlataformaW.Vista.asignarActividadesP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            float: left;
            font-size: 1.1rem;
            font-weight: 400;
            left: 0px;
            top: 0px;
            margin: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
 <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Asignar Actividades</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <!-- Font Awesome -->
  <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
      <!-- SweetAlert2 -->
  <link rel="stylesheet" href="/Vista/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css">
  <!-- Toastr -->
  <link rel="stylesheet" href="/Vista/plugins/toastr/toastr.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
  <!-- overlayScrollbars -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
  <!-- Google Font: Source Sans Pro -->
  <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition sidebar-mini">
<!-- Site wrapper -->
<div class="wrapper">
    
 
<!-- Content Wrapper. Contains page content -->
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

                <li class="nav-item">
                
                  <asp:LinkButton ID="lkbListado" runat="server" class="nav-link" href="/Vista/listadoEstudiantesCurso.aspx">Listado de Estudiantes</asp:LinkButton>
              </li>
              
            </ul>
         </div>
    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-md-6">
          <div class="card card-dark">
            <div class="card-header">
              <h3 class="card-title">Asignacion de actividades a estudiantes</h3>
            
          </div>

        
        </div>
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->

    <section class="content">
      <div class="row">
          
                
        <div class="col-md-6">
          <div class="card card-dark">
            <div class="card-header">
              <h3 class="auto-style2">Trabajo a realizar</h3>

             
                <asp:Label ID="lblCursoM" runat="server" Visible="false"></asp:Label>

             
            </div>
            <div class="card-body">
              <div class="form-group">
                <label for="inputName">Nombre de la Actividad</label>
                
                  <asp:TextBox ID="txtNomAc" runat="server" class="form-control"></asp:TextBox>
              </div>
             
            
              <div class="form-group">
                <label for="inputClientCompany">Adjunte sus archivos </label>
                  <asp:FileUpload ID="fluArchivo" runat="server" class="form-control"/>
              </div>
              <div class="form-group">
                <label for="inputProjectLeader">Descripcion</label>
                  <asp:TextBox ID="txtDesc" runat="server" class="form-control" Height="150px" TextMode="MultiLine"></asp:TextBox>
              </div>
            </div>
            <!-- /.card-body -->
          </div>
          <!-- /.card -->
        </div>
                
        <div class="col-md-6">
          <div class="card card-dark">
            <div class="card-header">
              <h3 class="card-title">Fechas</h3>

             
            </div>
            <div class="card-body">
              <div class="form-group">
                
                  <asp:Label ID="Label2" runat="server" Text="Fecha de inicio"></asp:Label>
                <asp:TextBox ID="txtFechaIni" runat="server" TextMode="Date" class="form-control"></asp:TextBox>
              </div>
              <div class="form-group">
                
                  <asp:Label ID="Label1" runat="server" Text="Fecha Final"></asp:Label>
                  <asp:TextBox ID="txtFechaFn" runat="server" TextMode="Date" class="form-control"></asp:TextBox>
              </div>
                <div class="row">
       

            <div class="col-12">
          
           <asp:Button ID="btnEnviar" type="submit" runat="server" class="btn-outline-warning float-right" Text="Enviar" OnClick="btnEnviar_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
      </div>
              
            </div>
            <!-- /.card-body -->
          </div>
          <!-- /.card -->
        </div>
          
      </div>
             
      
    </section>
</div>
</div>
<!-- jQuery -->
<script src="/Vista/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="/Vista/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="/Vista/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="/Vista/dist/js/demo.js"></script>
     <!-- SweetAlert2 -->
<script src="/Vista/plugins/sweetalert2/sweetalert2.min.js"></script>
<!-- Toastr -->
<script src="/Vista/plugins/toastr/toastr.min.js"></script>

<script type="text/javascript">
function registro() {
    const Toast = Swal.mixin({
      toast: true,
      position: 'top-end',
      showConfirmButton: false,
      timer: 3000
    });
     
      Toast.fire({
        icon: 'success',
        title: 'Actividad Asignada Correctamente'
      });
    
  };

</script>
</body>
</html>
    <br />
</asp:Content>
