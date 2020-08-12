<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="inicioEstudiante.aspx.cs" Inherits="ProyectoPlataformaW.inicioEstu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-weight: 500;
            font-size: 18px;
            text-transform: capitalize;
        }
    .auto-style3 {
        width: 338px;
        height: 239px;
    }
    .auto-style4 {
        width: 1140px;
        height: 239px;
    }
    .auto-style5 {
        width: 600px;
        height: 238px;
    }
    .auto-style8 {
        width: 900px;
        height: 239px;
    }
    .auto-style9 {
        width: 800px;
        height: 239px;
    }
    .auto-style10 {
        width: 1600px;
        height: 239px;
    }
    .auto-style11 {
        width: 626px;
        height: 239px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<!DOCTYPE html>
<html lang="en">
    <head>
    <!-- Basic -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">   
   
    <!-- Mobile Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
 
     <!-- Site Metas -->
    <title>GlvClassroom</title>  
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

    <!-- Modernizer for Portfolio -->
    <script src="js/modernizer.js"></script>

    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>
<body class="host_version"> 

	<!-- Modal -->
	

    <!-- LOADER -->
	<div id="preloader">
		<div class="loader-container">
			<div class="progress-br float shadow">
				<div class="progress__item"></div>
			</div>
		</div>
	</div>
	<!-- END LOADER -->	

    <!-- Start header -->
	
	<!-- End header -->
	
	<div class="all-title-box">
		<div class="container text-center">
			<h1>Materias<span class="m_1"></span></h1>
		</div>
	</div>
	
    <div id="overviews" class="section wb">
        <div class="container">
            <div class="section-title row text-center">
                <div class="col-md-8 offset-md-2">
                    <p class="lead">Seleccione la materia</p>
                </div>
            </div><!-- end title -->

           

            <asp:Repeater ID="repeaterMateria" runat="server">
                <ItemTemplate>
                    <div class="row"> 
                <div class="col-lg-3 col-md-6 col-12">
                    <div class="course-item">
						
						<div class="course-br">
							<div class="course-title">
								<h2><a href="actividadesMatematicas.aspx"><span class="auto-style2">'<%# Eval("NombreMateria") %>'</span></a></h2>
							</div>
							<div class="course-desc">
								<p><%# Eval("NivelAcademico") %></p>
							</div>
							<div class="course-rating">
								<p>Seccion Basica Media</p>
                                <p>&nbsp;</p>
															
							</div>
						</div>
						<div class="course-meta-bot">
							<ul>
								<li>Profesor : <%# Eval("Nombres") + " " + Eval("Apellidos") %></li>
							</ul>
						</div>
					</div>
                </div><!-- end col -->

            </div><!-- end row -->	
                </ItemTemplate>

            </asp:Repeater>
            		
			</div><!-- end container -->
    </div><!-- end section -->

   <!-- end section -->

    <footer class="footer">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 col-md-4 col-xs-12">
                    <div class="widget clearfix">
                        <div class="widget-title">
                            <h3>Sobre Nosotros</h3>
                        </div>
                        <p> Colegio Guillermo Leon Valencia Duitama,Boyaca Cra7b#15a2</p>
                        <div class="footer-right">
							<ul class="footer-links-soi">
								<li><a href="#"><i class="fa fa-facebook"></i></a></li>
								<li><a href="#"><i class="fa fa-github"></i></a></li>
								<li><a href="#"><i class="fa fa-twitter"></i></a></li>
								<li><a href="#"><i class="fa fa-dribbble"></i></a></li>
								<li><a href="#"><i class="fa fa-pinterest"></i></a></li>
							</ul><!-- end links -->
						</div>
                    </div><!-- end clearfix -->
                </div><!-- end col -->

				<div class="col-lg-4 col-md-4 col-xs-12">
                    <div class="widget clearfix">
                        <div class="widget-title">
                            <h3>Informacion</h3>
                        </div>
                        <ul class="footer-links">
                            <li><a href="#">Home</a></li>
                            <li><a href="#">Blog</a></li>
                            <li><a href="#">Pricing</a></li>
							<li><a href="#">About</a></li>
							<li><a href="#">Contact</a></li>
                        </ul><!-- end links -->
                    </div><!-- end clearfix -->
                </div><!-- end col -->
				
                <div class="col-lg-4 col-md-4 col-xs-12">
                    <div class="widget clearfix">
                        <div class="widget-title">
                            <h3>Contactos</h3>
                        </div>

                        <ul class="footer-links">
                            <li><a href="mailto:#">haroldzabala5@gmail.com&nbsp; kimzu11112@gmail.com&nbsp; mauriciorinconb.glv@gmail.com&nbsp; </a></li>
                            <li><a href="#">www.yoursite.com</a></li>
                            <li>Cra7b#15a2</li>
                            <li>Duitama,Boyaca</li>
                        </ul><!-- end links -->
                    </div><!-- end clearfix -->
                </div><!-- end col -->
				
            </div><!-- end row -->
        </div><!-- end container -->
    </footer><!-- end footer -->

    <div class="copyrights">
        <div class="container">
            <div class="footer-distributed">
                <div class="footer-center">                   
                    <p class="footer-company-name">All Rights Reserved. © 2020 <a href="#"><span class="text-white">GlvClassroom</span></a> Design By : <a href="https://html.design/">G<span class="text-white">rupo 4</span></a></p>
                </div>
            </div>
        </div><!-- end container -->
    </div><!-- end copyrights -->

    <a href="#" id="scroll-to-top" class="dmtop global-radius"><i class="fa fa-angle-up"></i></a>

    <!-- ALL JS FILES -->
    <script src="js/all.js"></script>
    <!-- ALL PLUGINS -->
    <script src="js/custom.js"></script>

</body>
</html>
</asp:Content>
