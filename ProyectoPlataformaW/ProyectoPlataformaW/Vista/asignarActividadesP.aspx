<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="asignarActividadesP.aspx.cs" Inherits="ProyectoPlataformaW.Vista.asignarActividadesP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <br />
    <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>AdminLTE 3 | Project Add</title>
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
            <h1>Asignacion de actividades a estudiantes</h1>
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
              <h3 class="card-title">Trabajo a realizar</h3>

             
            </div>
            <div class="card-body">
              <div class="form-group">
                <label for="inputName">Actividad</label>
                
                  <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
              </div>
              <div class="form-group">
                <label for="inputDescription">Descripcion</label>
                <textarea id="inputDescription" class="form-control" rows="4"></textarea>
              </div>
            
              <div class="form-group">
                <label for="inputClientCompany">Adjunte sus archivos </label>
                <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
              </div>
              <div class="form-group">
                <label for="inputProjectLeader">Curso Materia</label>
                <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
              </div>
            </div>
            <!-- /.card-body -->
          </div>
          <!-- /.card -->
        </div>
        <div class="col-md-6">
          <div class="card card-secondary">
            <div class="card-header">
              <h3 class="card-title">Fechas</h3>

             
            </div>
            <div class="card-body">
              <div class="form-group">
                <label for="inputEstimatedBudget">Fecha de inicio</label>
                <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
              </div>
              <div class="form-group">
                <label for="inputSpentBudget">Fecha Final</label>
                <asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox>
              </div>
                <div class="row">
       

            <div class="col-12">
          
           <asp:Button ID="btnEnviar" type="submit" runat="server" class="btn btn-success float-right" Text="Enviar"/>
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
</body>
</html>
    <br />
</asp:Content>
