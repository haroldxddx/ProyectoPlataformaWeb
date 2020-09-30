<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="forosTotalesAct.aspx.cs" Inherits="ProyectoPlataformaW.Vista.forosTotalesAct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Entregas de Estudiantes</title>
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
  <!-- Navbar -->
  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
     <div class="card-body">
            <ul class="nav nav-tabs" id="custom-content-below-tab" role="tablist">
              <li class="nav-item">
                
                  <asp:LinkButton ID="lkbRegistro" runat="server" class="nav-link" href="/Vista/registrarForoActividad.aspx" >Registrar Foro</asp:LinkButton>
              </li>
              <li class="nav-item">
                
                  <asp:LinkButton ID="lkbForo" runat="server" class="nav-link" href="/Vista/foroActividad.aspx">Foros Actividades</asp:LinkButton>
              </li>
                <li class="nav-item">
                
              </li>

               
              
            </ul>
         </div>
   

    <!-- Main content -->
    <section class="content">

      <!-- Default box -->
      <div class="card">
        <div class="card-header">
          <h3 class="card-title">Foros</h3>

         
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Seleccione la actividad para ver los foros disponibles"></asp:Label>
            <asp:Label ID="lblCursoMat" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="ddlAct" runat="server" class="form-control" Width="60%" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="ddlAct_SelectedIndexChanged">
                <asp:ListItem Value="-1">Seleccione la actividad</asp:ListItem>
            </asp:DropDownList>
            

         
            <asp:Label ID="lblIdCursoM" runat="server" Text=""></asp:Label>
            <br />
            

         
        </div>


        <div class="card-body p-0">
          <table class="table table-striped projects">
              <thead>
                  <tr>
                      <th style="width: 1%">
                          Titulo
                      </th>
                      <th style="width: 20%">
                          Fecha
                      </th>
                      <th style="width: 30%">
                          Descripcion
                      </th>
                      <th>
                          Tipo
                      </th>
                     
                      <th style="width: 20%">

                      </th>
                  </tr>
              </thead>

              <asp:Repeater ID="repeaterEstud" runat="server" OnItemCommand="repeaterEstud_ItemCommand">

                  <ItemTemplate>
                       <tbody>
                  <tr>
                     
                      <td>
                          <asp:Label ID="lblTitulo" runat="server" Text='<%# Eval("Titulo") %>'></asp:Label><asp:Label ID="lblIdForo" runat="server" Text='<%# Eval("IdForo") %>'></asp:Label>
                      </td>
                      <td>
                         <asp:Label ID="lblFecha" runat="server" Text='<%# Eval("Fecha") %>'></asp:Label>
                      </td>
                      <td>
                        <asp:Label ID="lblDesc" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lblTipo" runat="server" Text='<%# Eval("Tipo") %>'></asp:Label>
                      </td>
                      
                      <td class="project-actions text-right">
                         
                        
                          <asp:Button ID="btnVerEntrega" runat="server" Text="Entrar " class="btn btn-info btn-sm"/>
                         
                      </td>
                  </tr>
               </tbody>

                  </ItemTemplate>

              </asp:Repeater>
             
          </table>
            <br />
        </div>
        <!-- /.card-body -->
      </div>
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
</body>
</html>
</asp:Content>
