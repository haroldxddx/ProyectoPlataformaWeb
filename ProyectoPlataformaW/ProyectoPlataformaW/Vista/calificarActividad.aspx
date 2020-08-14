<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="calificarActividad.aspx.cs" Inherits="ProyectoPlataformaW.Vista.calificarActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 4%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>AdminLTE 3 | Projects</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <!-- Font Awesome -->
  <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
  <!-- overlayScrollbars -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
     <!-- SweetAlert2 -->
  <link rel="stylesheet" href="/Vista/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css">
  <!-- Toastr -->
  <link rel="stylesheet" href="/Vista/plugins/toastr/toastr.min.css">
     <!-- Theme style -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
  <!-- Google Font: Source Sans Pro -->
  <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition sidebar-mini">
<!-- Site wrapper -->
<div class="wrapper">
  <!-- Navbar -->
  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    
   

    <!-- Main content -->
    <section class="content">

      <!-- Default box -->
      <div class="card">
        <div class="card-header">
            <br />
          <h3 class="card-title">Entregas</h3>

         
        </div>


        
          <table class="table table-striped projects">
              <thead>
                  <tr>
                      <th class="auto-style2">
                          Detalles de Entrega 
                      </th>
                      <th style="width: 20%">
                          
                      </th>
                      
                  </tr>
              </thead>
             <tbody>
                  <tr>
                     
                      <td class="auto-style2">
                          <asp:Label ID="lblDesc" runat="server" Text="Descripcion : "></asp:Label>
                          <br />
                          <br />
                          <asp:Label ID="lblFecha" runat="server" Text="Fecha : "></asp:Label>
                          <br />
                          <br />
                          <asp:Label ID="lblArchivo" runat="server" Text="Archivos Adjuntos : "></asp:Label>
                          <br />
                          <br />
                          <asp:Label ID="lblEstado" runat="server" Text="Estado : "></asp:Label>
                      </td>


                      <td>
                         <asp:Label ID="Label1" runat="server" Text="HOLA "></asp:Label>
                          <br />
                          <br />
                          <asp:Label ID="Label2" runat="server" Text="QUE HACE  "></asp:Label>
                          <br />
                          <br />
                          <asp:Label ID="Label3" runat="server" Text="PTO EL QUE LO LEA "></asp:Label>
                          &nbsp;<asp:LinkButton ID="LinkButton1" runat="server">Descargar Archivo</asp:LinkButton>
                          <br />
                          <br />
                          <asp:Label ID="Label4" runat="server" Text="JAJAJAJAJAJA "></asp:Label>
                      </td>
                      
                  </tr>
               </tbody>

                
          </table>
          <button type="button" class="btn btn-default" data-toggle="modal" data-target="#modal-lg">
                  Calificar Actividad
                </button>

           <div class="modal fade" id="modal-lg">
        <div class="modal-dialog modal-lg">
          <div class="modal-content">
            <div class="modal-header">
              <h4 class="modal-title">Calificar Actividad</h4>
              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body">
              <p>Asigne su calificacion de 1.0 a 5.0 segun su criterio&hellip;</p>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" Step="0.1" Max="5"></asp:TextBox>
            </div>
            <div class="modal-footer justify-content-between">
              <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
             
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar Cambios" class="btn btn-primary"/>
            </div>
          </div>
          <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
      </div>
        </div>
        <!-- /.card-body -->
      
      <!-- /.card -->

    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->

 
  <!-- /.control-sidebar -->
</div>
<!-- ./wrapper -->

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

</body>
</html>
</asp:Content>
