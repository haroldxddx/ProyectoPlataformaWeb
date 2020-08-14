<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="verEntregasEstudiantes.aspx.cs" Inherits="ProyectoPlataformaW.Vista.verEntregasEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                
                  <asp:LinkButton ID="lkbAsig" runat="server" class="nav-link active" href="/Vista/asignarActividadesP.aspx">Asignacion de Actividades</asp:LinkButton>
              </li>
              <li class="nav-item">
                
                  <asp:LinkButton ID="lkbCalifi" runat="server" class="nav-link" href="/Vista/verEntregasEstudiantes.aspx">Calificacion de Actividades</asp:LinkButton>
              </li>
              
            </ul>
         </div>
   

    <!-- Main content -->
    <section class="content">

      <!-- Default box -->
      <div class="card">
        <div class="card-header">
          <h3 class="card-title">Entregas</h3>

         
            <br />
            <br />
            <asp:DropDownList ID="ddlAct" runat="server" class="form-control" Width="60%">
            </asp:DropDownList>
            

         
            <asp:Label ID="lblIdCursoM" runat="server" Text="1"></asp:Label>
            <br />
            <asp:Button ID="btnVer" runat="server" BackColor="#001F3F" BorderColor="#001F3F" BorderStyle="Dotted" ForeColor="White" Text="Ver" Width="69px" OnClick="btnVer_Click" />
            

         
        </div>


        <div class="card-body p-0">
          <table class="table table-striped projects">
              <thead>
                  <tr>
                      <th style="width: 1%">
                          Nombres
                      </th>
                      <th style="width: 20%">
                          Apellidos
                      </th>
                      <th style="width: 30%">
                          Descripcion Actividad
                      </th>
                      <th>
                          Materia
                      </th>
                      <th style="width: 8%" class="text-center">
                          Curso
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
                          <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombres") %>'></asp:Label>
                      </td>
                      <td>
                         <asp:Label ID="lblApe" runat="server" Text='<%# Eval("Apellidos") %>'></asp:Label>
                      </td>
                      <td>
                        <asp:Label ID="lblDesc" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lblNombreMat" runat="server" Text='<%# Eval("NombreMateria") %>'></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lblCurso" runat="server" Text='<%# Eval("Curso") %>'></asp:Label>
                      </td>
                      <td class="project-actions text-right">
                         
                        
                          <asp:Button ID="btnVerEntrega" runat="server" Text="Ver Entrega" class="btn btn-info btn-sm" OnClick="btnVerEntrega_Click"/>
                         
                      </td>
                  </tr>
               </tbody>

                  </ItemTemplate>

              </asp:Repeater>
             
          </table>
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
