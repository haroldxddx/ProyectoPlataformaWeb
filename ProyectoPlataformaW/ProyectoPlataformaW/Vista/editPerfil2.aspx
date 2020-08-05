<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="editPerfil2.aspx.cs" Inherits="ProyectoPlataformaW.Vista.editPerfil2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 93px;
            height: 21px;
            top: 42px;
            left: 463px;
        }
        .auto-style3 {
            width: 93px;
            height: 21px;
            top: 86px;
            left: 463px;
        }
        .auto-style4 {
            width: 93px;
            height: 21px;
            top: 128px;
            left: 464px;
        }
        .auto-style5 {
            width: 93px;
            height: 21px;
            top: 171px;
            left: 464px;
        }
        .auto-style6 {
            width: 93px;
            height: 21px;
            top: 214px;
            left: 466px;
        }
    </style>
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
                      <br />
                    <asp:TextBox ID="txtNom" runat="server" class="form-control" Width="437px" Enabled="False" ></asp:TextBox>
                      <br />
                      <asp:CheckBox ID="chbN" runat="server" AutoPostBack="True" CssClass="auto-style2" />
&nbsp; Editar</div>
                    <div class="form-group">
                      Apellidos
                        <br />
                    <asp:TextBox ID="txtAp" runat="server"  class="form-control" Width="435px" Enabled="False" ></asp:TextBox>
                        <br />
                        <asp:CheckBox ID="chbA" runat="server" AutoPostBack="True" CssClass="auto-style5" />
&nbsp; Editar</div>
                    <div class="form-group">
                      Documento
                        <br />
                    <asp:TextBox ID="txtDoc" runat="server" class="form-control" Width="435px" Enabled="False" ></asp:TextBox>
                        <br />
                        <asp:CheckBox ID="chbD" runat="server" AutoPostBack="True" CssClass="auto-style3" />
&nbsp; Editar</div>
                    <div class="form-group">
                      Email
                        <br />
                    <asp:TextBox ID="txtEmail" runat="server" type="email" class="form-control" Width="436px" Enabled="False" ></asp:TextBox>
                        <br />
                        <asp:CheckBox ID="chbE" runat="server" AutoPostBack="True" CssClass="auto-style4" />
&nbsp; Editar</div>

                    <div class="form-group">
                      Cambiar Contraseña
                        <br />
                    <asp:TextBox ID="txtCo" runat="server" type="password" class="form-control" Width="436px" Enabled="False" ></asp:TextBox>
                  </div>
                  
                  <div class="form-check">
                      <asp:CheckBox ID="cbhC" runat="server" AutoPostBack="True" CssClass="auto-style6" />
&nbsp; Editar</div>
                </div>
                <!-- /.card-body -->

                <div class="card-footer">
                  
                    <asp:Button ID="btnEditar" type="submit" class="btn btn-primary" runat ="server" Text="Editar Informacion" />
                    <br />
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
