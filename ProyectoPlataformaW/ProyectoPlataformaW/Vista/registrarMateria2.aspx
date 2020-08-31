<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="registrarMateria2.aspx.cs" Inherits="ProyectoPlataformaW.Vista.registrarMateria2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
    <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Registrar Materia</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <!-- Font Awesome -->
  <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
  <!-- overlayScrollbars -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
  <!-- Google Font: Source Sans Pro -->
  <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
    <!-- overlayScrollbars -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
     <!-- SweetAlert2 -->
  <link rel="stylesheet" href="/Vista/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css">
  <!-- Toastr -->
  <link rel="stylesheet" href="/Vista/plugins/toastr/toastr.min.css">

</head>
<body class="hold-transition sidebar-mini">
<!-- Site wrapper -->
<div class="wrapper">
 
<!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1>Registros</h1>
          </div>
        
        </div>
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-md-6">
          <div class="card card-primary">
            <div class="card-header">
              <h3 class="card-title">Registrar Cursos</h3>

             
            </div>
            <div class="card-body">
              
	      
	       <div class="form-group">
                <label for="inputClientCompany">Nivel Academico</label>
                
                <br />
                
                <asp:DropDownList ID="dplNivel" class="form-control" runat="server">
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
              </div>
                 <div class="form-group">
                <label for="inputClientCompany">Nombre de Materia</label>
                <asp:TextBox ID="txtNomM" runat="server" placeholder="Ingrese Nombre de materia" class="form-control"></asp:TextBox>
              </div>

                <div class="row">
       

            <div class="col-12">
          
           <asp:Button ID="btnRegistrarC" type="submit" runat="server" class="btn btn-success float-right" Text="Registrar" OnClick="btnRegistrarP_Click"/>
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
      timer: 2000
    });
     
      Toast.fire({
        icon: 'success',
          title: 'Registro Realizado Correctamente'
      });
    
  };

</script>
</body>
</html>
    <br />
</asp:Content>
