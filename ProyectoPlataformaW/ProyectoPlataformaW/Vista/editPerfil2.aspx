<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="editPerfil2.aspx.cs" Inherits="ProyectoPlataformaW.Vista.editPerfil2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>AdminLTE 3 | General Form Elements</title>
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
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1>
                <br />
                Perfil Estudiante</h1>
          </div>
          
        </div>
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="container-fluid">
        <div class="row">
          <!-- left column -->
          <div class="col-md-6">
            <!-- general form elements -->
            <div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Editar Informacion Personal</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form">
                <div class="card-body">
                  <div class="form-group">
                      Nombres
                    <asp:TextBox ID="txtNom" runat="server" class="form-control" ></asp:TextBox>
                  </div>
                    <div class="form-group">
                      Apellidos
                    <asp:TextBox ID="txtAp" runat="server"  class="form-control" ></asp:TextBox>
                  </div>
                    <div class="form-group">
                      Documento
                    <asp:TextBox ID="txtDoc" runat="server" class="form-control" ></asp:TextBox>
                  </div>
                    <div class="form-group">
                      Email
                    <asp:TextBox ID="txtEmail" runat="server" type="email" class="form-control" ></asp:TextBox>
                  </div>

                    <div class="form-group">
                      Cambiar Contraseña
                    <asp:TextBox ID="txtCo" runat="server" type="password" class="form-control" ></asp:TextBox>
                  </div>
                  
                  <div class="form-check">
                    &nbsp;<label class="form-check-label" for="exampleCheck1">Check me out</label>
                  </div>
                </div>
                <!-- /.card-body -->

                <div class="card-footer">
                  <button type="submit" class="btn btn-primary">Submit</button>
                </div>
              </form>
            </div>
              </div>
            </div>
          </div>
             </section>
    
    </div>
</div>


<!-- jQuery -->
<script src="/Vista/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="/Vista/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- bs-custom-file-input -->
<script src="/Vista/plugins/bs-custom-file-input/bs-custom-file-input.min.js"></script>
<!-- AdminLTE App -->
<script src="/Vista/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="/Vista/dist/js/demo.js"></script>
<script type="text/javascript">
$(document).ready(function () {
  bsCustomFileInput.init();
});
</script>
</body>
</html>
</asp:Content>
