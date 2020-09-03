<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="reporteNotasEstud.aspx.cs" Inherits="ProyectoPlataformaW.Vista.reporteNotasEstud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Reporte de Notas</title>
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
  <!-- Navbar -->
  

  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper" id="imp">
    <!-- Content Header (Page header) -->
 

    <section class="content">
      <div class="container-fluid">
        <div class="row">
          <div class="col-12">
            


            <!-- Main content -->
            <div class="invoice p-3 mb-3">
              <!-- title row -->
              <div class="row">
                <div class="col-12">
                  <h4>
                    <i class="fas fa-globe"></i> Colegio Guillermo León Valencia
                    <small class="float-right"><asp:Label ID="lblFecha" runat="server"></asp:Label></small>
                  </h4>
                </div>
                <!-- /.col -->
              </div>
              <!-- info row -->
              <div class="row invoice-info">
                <div class="col-sm-4 invoice-col">
                    Estudiante
                  <address>
                      <asp:Label ID="lblNombre" runat="server"></asp:Label>
                      <asp:Label ID="lblApellido" runat="server"></asp:Label>
                      <br>
                      Documento :<br>
                      <asp:Label ID="lblDocu" runat="server"></asp:Label>
                      <br>
                      Email :<br>
                    &nbsp;<asp:Label ID="lblEmail" runat="server"></asp:Label>
                  </address>
                </div>
                <!-- /.col -->
                <div class="col-sm-4 invoice-col">
                  &nbsp;<address>
                        Curso<br>
                        <asp:Label ID="lblCurso" runat="server"></asp:Label>
                        <br>
                        Grado<br>
                        <asp:Label ID="lblGrado" runat="server"></asp:Label>
                        <br>
                  </address>
                </div>
                <!-- /.col -->
                <!-- /.col -->
              </div>
              <!-- /.row -->
                <div class="row">
                <div class="col-12 table-responsive">

                <asp:Repeater ID="repeaterNot" runat="server">

                    <ItemTemplate>

                     <table class="table table-striped">
                    <thead>
                    <tr>
                      <th>Nombre Actividad</th>
                      <th>Descripcion</th>
                      <th>Nota</th>
                      
                    </tr>
                    </thead>
                    <tbody>
                    <tr>
                      <td>
                         <asp:Label ID="lblNomAct" runat="server" Text='<%# Eval("NombreActividad") %>'></asp:Label></td>
                      <td>
                             <asp:Label ID="lblDesc" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label></td>
                      <td>
                                 <asp:Label ID="lblNota" runat="server" Text='<%# Eval("Nota") %>'></asp:Label></td>
                      
                    </tr>
                    
                    </tbody>
                  </table>
                    </ItemTemplate>

                </asp:Repeater>
                  
                </div>
                <!-- /.col -->
              </div>
              <!-- Table row -->
              <!-- /.row -->
               

                   
              <!-- /.row -->

              <!-- this row will not appear when printing -->
              <div class="row no-print">
                <div class="col-12">
                 
                    <input id="btn2" type="button" value="Imprimir" class="btn btn-default" onclick="imprimir2();" />
                  
                </div>
              </div>
            </div>
            <!-- /.invoice -->
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->

  <!-- Control Sidebar -->
  <aside class="control-sidebar control-sidebar-dark">
    <!-- Control sidebar content goes here -->
  </aside>
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
    
<script type="text/javascript">

    function Imprime(nombre) {
        var ficha = document.getElementById(nombre);
        var ventimp = window.open(' ', 'popimpr');
        ventimp.document.write(ficha.innerHTML);
        ventimp.document.close();
        ventimp.print();
        ventimp.close();
    }

</script>
    <script type="text/javascript"> 
        function imprimir2() {
            window.addEventListener("load", window.print());
        }
       
</script>
</body>
</html>
</asp:Content>
