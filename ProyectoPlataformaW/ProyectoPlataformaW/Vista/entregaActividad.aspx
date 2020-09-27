<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="entregaActividad.aspx.cs" Inherits="ProyectoPlataformaW.Vista.entregaActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html lang="en">
    <head>

    <!-- Basic -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">   
   
    <!-- Mobile Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
 
     <!-- Site Metas -->
    <title>Entrega de actividades</title>  
    <meta name="keywords" content="">
    <meta name="description" content="">
    <meta name="author" content="">

    <!-- Site Icons -->
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon" />
    <link rel="apple-touch-icon" href="images/apple-touch-icon.png">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- Site CSS -->
    <link rel="stylesheet" href="style.css">
    <!-- ALL VERSION CSS -->
    <link rel="stylesheet" href="css/versions.css">
    <!-- Responsive CSS -->
    <link rel="stylesheet" href="css/responsive.css">
    <!-- Custom CSS -->
    <link rel="stylesheet" href="css/custom.css">
        <!-- overlayScrollbars -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
     <!-- SweetAlert2 -->
  <link rel="stylesheet" href="/Vista/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css">
  <!-- Toastr -->
  <link rel="stylesheet" href="/Vista/plugins/toastr/toastr.min.css">

    <!-- Modernizer for Portfolio -->
    <script src="js/modernizer.js"></script>

    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>
<body > 

	

	<!-- LOADER -->
	<div id="preloader">
		<div class="loader-container">
			<div class="progress-br float shadow">
				<div class="progress__item"></div>
			</div>
		</div>
	</div>
	<!-- END LOADER -->	
  
    
	
	
	<div class="all-title-box">
		<div class="container text-center">
			<h1>Entrega<span class="m_1">actividad </span></h1>
		</div>
	</div>
	

      <div id="contact" class="section wb">
        <div class="container">
            <div class="section-title text-center">
                <h3>Entrega tu actividad !</h3>
                <p class="lead">entrega la actividad propuesta<br>:V!</p>
            </div><!-- end title -->

            <div class="row">
                <div class="col-xl-6 col-md-12 col-sm-12">
                    <div class="contact_form">
                        <div id="message"></div>
                        <form id="contactform" class="" action="contact.php" name="contactform" method="post">
                            <div class="row row-fluid">
                                <div class="col-lg-6 col-md-6 col-sm-6">
                                  
                                    <asp:Label ID="lblUser" runat="server" Text=""  class="form-control"  placeholder="user"></asp:Label>
                                    <asp:Label ID="lble" runat="server" Text="" class="form-control"></asp:Label>
                                   
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6">
                                   
                                 <asp:TextBox ID="txtComentario" runat="server" class="form-control" placeholder="comentario"></asp:TextBox>

                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6">
                                 
                                    <asp:TextBox ID="txtVinculo" runat="server" class="form-control"  placeholder="Adjuntar vinculo"></asp:TextBox>
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6">
                                   
                                     <asp:FileUpload ID="AdArchivo" runat="server" class="form-control" placeholder="Adjuntar archivo"/>

                                   

                                     
                                </div>

                                <div class="col-lg-12 col-md-12 col-sm-12">
                                    
                                    <asp:TextBox ID="txtEvidencia" runat="server"  class="form-control"  placeholder="Escribe tu evidencia aqui ...." ></asp:TextBox>
                                </div>
                                <div class="text-center pd">
                              
                                    <asp:Button ID="btnEntregaA" runat="server" Text="Entregar" class="btn btn-light btn-radius btn-brd grd1 btn-block" OnClick="btnEntregaA_Click" />

                                </div>
                               
                            </div>
                        </form>
                    </div>
                </div><!-- end col -->
				<div class="col-xl-6 col-md-12 col-sm-12">
                    <div class="map-box">
					<asp:Repeater ID="repeaterActividad" runat="server" >
                <ItemTemplate>
                    
                    <div class="blog-item"> 
                <div class="col-lg-4 col-md-6 col-12">
                    <div class="blog-item">
						<div class="image-blog">
							<img src="images/i.jpg" alt="" class="img-fluid">
						</div>
						<div class="meta-info-blog">
							<span><i class="fa fa-calendar"></i> <a href="#"> Fecha inicio actividad: '<%# Eval("FechaInicio") %>'</a> </span>

							<span><i class="fa fa-calendar"></i> <a href="#"> Fecha fin actividad : '<%# Eval("FechaFinal") %>'</a> </span>
                         
						</div>
						<div class="blog-title">
							<h2><a href="#" title="">'<%# Eval("NombreActividad") %>'</a></h2>
						</div>
						<div class="blog-desc">
							<p>'<%# Eval("Descripcion") %>' </p>
                            <asp:Label ID="lblDescripcion" runat="server"     Text='<%# Eval("Descripcion") %>' ></asp:Label>
						</div>
						<div class="pricing-table-sign-up">
						  <asp:LinkButton   class="hover-btn-new orange" ID="lbtCurso" runat="server" OnClick="DescargarAct" Text=""><span>&#11123Actividad<span></span></asp:LinkButton>
					</div>

                </div><!-- end col -->
                       
                </ItemTemplate>

            </asp:Repeater>
				</div>



                    </div>
            </div><!-- end row -->
        </div><!-- end container -->
    </div>
  <!-- end section -->







	
	<div class="parallax section dbcolor">
        <div class="container">
            <div class="row logos">
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/logo_01.png" alt="" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/logo_02.png" alt="" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/logo_03.png" alt="" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/logo_04.png" alt="" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/logo_05.png" alt="" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/logo_06.png" alt="" class="img-repsonsive"></a>
                </div>
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->

  

  

    <a href="#" id="scroll-to-top" class="dmtop global-radius"><i class="fa fa-angle-up"></i></a>

    <!-- ALL JS FILES -->
    <script src="js/all.js"></script>
	<script src="https://maps.googleapis.com/maps/api/js?libraries=places&key=AIzaSyCKjLTXdq6Db3Xit_pW_GK4EXuPRtnod4o"></script>
	<!-- Mapsed JavaScript -->
	<script src="js/mapsed.js"></script>
	<script src="js/01-custom-places-example.js"></script>
    <!-- ALL PLUGINS -->
    <script src="js/custom.js"></script>

    <script type="text/javascript">
    function registro() {
    const Toast = Swal.mixin({
      toast: true,
        position: 'top_end',
        my: "center",
        at: "center",
        

      
     


      showConfirmButton: false,
      timer: 3000
    });
     
      Toast.fire({
        icon: 'success',
        title: 'Actividad Entregada Correctamente'
      });
    
  };

</script>

</body>
</html>
</asp:Content>

