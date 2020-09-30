<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="foroActividad.aspx.cs" Inherits="ProyectoPlataformaW.Vista.foroActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>AdminLTE 3 | Timeline</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
  <!-- AdminLTE css -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
    <!-- summernote -->
  <link rel="stylesheet" href="/Vista/plugins/summernote/summernote-bs4.css">
           <!-- SweetAlert2 -->
  <link rel="stylesheet" href="/Vista/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css">
     <!-- Toastr -->
  <link rel="stylesheet" href="/Vista/plugins/toastr/toastr.min.css">
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
                
                  <asp:LinkButton ID="lkbRegistro" runat="server" class="nav-link" href="/Vista/registrarForoActividad.aspx" >Registrar Foro</asp:LinkButton>
              </li>
              <li class="nav-item">
                
                  <asp:LinkButton ID="lkbForo" runat="server" class="nav-link" href="/Vista/foroActividad.aspx">Foros Actividades</asp:LinkButton>
              </li>
                <li class="nav-item">
                
              </li>

               
              
            </ul>
         </div>

      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <br />
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Titulo del foro :&nbsp;&nbsp;
      <asp:Label ID="lblTitulo" runat="server"></asp:Label>
      <br />
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <br />
&nbsp;&nbsp;&nbsp;
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tipo de foro :&nbsp;&nbsp;
      <asp:Label ID="lblTipo" runat="server"></asp:Label>
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <br />
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion :&nbsp;&nbsp;
      <asp:Label ID="lblDesc" runat="server"></asp:Label>
      <br />
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <br />
&nbsp;&nbsp;&nbsp;

      <asp:Repeater ID="repeaterProfesor" runat="server">


                <ItemTemplate>
       <section class="content">
      <div class="container-fluid">
        
        <!-- Timelime example  -->
        <div class="row">

             <br />
           
          <div class="col-md-12">
            <!-- The time line -->
            <div class="timeline">
              <!-- timeline time label -->
              <div class="time-label">
                <span class="bg-red">
                  <asp:Label ID="lblFecha1" runat="server" Text='<%# Eval("Fecha") %>'></asp:Label>
                  </span>&nbsp;</div>
              <!-- /.timeline-label -->
              <!-- timeline item -->
             
              <!-- END timeline item -->
              <!-- timeline item -->
            
              <!-- END timeline item -->
              <!-- timeline item -->
              <div>
                <i class="fas fa-comments bg-yellow"></i>
                <div class="timeline-item">
                  
                  <h3 class="timeline-header">&nbsp;<asp:Label ID="lblNombres1" runat="server" Text='<%# Eval("Nombres") + " " + Eval("Apellidos")%>'> </asp:Label>
&nbsp; realizó un comentario </h3>
                  <div class="timeline-body">
                      <asp:Label ID="lblComentario1" runat="server" Text='<%# Eval("Comentario") %>'></asp:Label>
                  </div>
                </div>
              </div>
              <!-- END timeline item -->
              <!-- timeline time label -->
            
              <!-- /.timeline-label -->
              <!-- timeline item -->
          
              <!-- END timeline item -->
              <!-- timeline item -->
            
              <!-- END timeline item -->
            
            </div>
          </div>
          <!-- /.col -->
        </div>
      </div>
      <!-- /.timeline -->

    </section>

                </ItemTemplate>
            </asp:Repeater>

       <asp:Repeater ID="repeaterComent" runat="server">


                <ItemTemplate>
       <section class="content">
      <div class="container-fluid">
        
        <!-- Timelime example  -->
        <div class="row">

             <br />
           
          <div class="col-md-12">
            <!-- The time line -->
            <div class="timeline">
              <!-- timeline time label -->
              <div class="time-label">
                <span class="bg-red">
                  <asp:Label ID="lblFecha" runat="server" Text='<%# Eval("Fecha") %>'></asp:Label>
                  </span>&nbsp;</div>
              <!-- /.timeline-label -->
              <!-- timeline item -->
             
              <!-- END timeline item -->
              <!-- timeline item -->
            
              <!-- END timeline item -->
              <!-- timeline item -->
              <div>
                <i class="fas fa-comments bg-yellow"></i>
                <div class="timeline-item">
                  
                  <h3 class="timeline-header">&nbsp;<asp:Label ID="lblNombres" runat="server" Text='<%# Eval("Nombres") + " " + Eval("Apellidos")%>'> </asp:Label>
&nbsp; realizó un comentario </h3>
                  <div class="timeline-body">
                      <asp:Label ID="lblComentario" runat="server" Text='<%# Eval("Comentario") %>'></asp:Label>
                  </div>
                </div>
              </div>
              <!-- END timeline item -->
              <!-- timeline time label -->
            
              <!-- /.timeline-label -->
              <!-- timeline item -->
          
              <!-- END timeline item -->
              <!-- timeline item -->
            
              <!-- END timeline item -->
            
            </div>
          </div>
          <!-- /.col -->
        </div>
      </div>
      <!-- /.timeline -->

    </section>

                </ItemTemplate>
            </asp:Repeater>
      <br />
           <section class="content">
      <div class="row">
        <div class="col-md-12">
          
            <div class="card-header">
             
           
              <!-- /. tools -->
            </div>
            <!-- /.card-header -->
            <div class="card-body pad">
              <div class="mb-3">
                

                  <asp:TextBox ID="txtComent" runat="server" TextMode="MultiLine" placeholder="Escriba su comentario"
                          style="width: 100%; height: 300px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"></asp:TextBox>
              </div>
              
            </div>
          
        </div>
          <br />
          <asp:Button ID="btnGuardar" runat="server" Text="Publicar" class="btn btn-success" Width="200px" OnClick="btnGuardar_Click"/>
          <asp:Label ID="lblFecha" runat="server" Visible="false"></asp:Label>
          <br />
        <!-- /.col-->
          <div class="slide_style_right">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          </div>
          <br />
      </div>
               <br />
      <!-- ./row -->
               <br />
               <br />
    </section>  
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
    <!-- Summernote -->
<script src="/Vista/plugins/summernote/summernote-bs4.min.js"></script>
<script>
  $(function () {
    // Summernote
    $('.textarea').summernote()
  })
</script>
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
            title: 'Comentario Realizado Correctamente'
        });

    };

</script>
</body>
</html>
   
</asp:Content>
