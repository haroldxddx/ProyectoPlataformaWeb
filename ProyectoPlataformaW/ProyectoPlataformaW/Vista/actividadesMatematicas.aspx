<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="actividadesMatematicas.aspx.cs" Inherits="ProyectoPlataformaW.Vista.actividadesMatematicas" %>
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
      
    <body>
      <form id="form1" runat="server">
          <div class="all-title-box">
		<div class="container text-center">
			<h1>Actividades<span class="m_1"></span></h1>
		</div>
	</div>
	
    <div id="overviews" class="section wb">
        <div class="container">
            <div class="section-title row text-center">
                <div class="col-md-8 offset-md-2">
                    <p class="lead">Actividades propuestas por instructor  de area!</p>
                </div>
            </div><!-- end title -->

            <hr class="invis"> 

            <div class="row"> 
                <div class="col-lg-4 col-md-6 col-12">
                    <div class="blog-item">
						<div class="image-blog">
							<img src="images/blog_1.jpg" alt="" class="img-fluid">
						</div>
						<div class="meta-info-blog">
							<span><i class="fa fa-calendar"></i> <a href="#"> plazo May 11, 2020</a> </span>
                            <span><i class="fa fa-tag"></i>  <a href="#">por realizar</a> </span>
                            <span><i class="fa fa-comments"></i> <a href="#">12 Comments</a></span>
						</div>
						<div class="blog-title">
							<h2><a href="#" title="">Estadística descriptiva datos no agrupados..</a></h2>
						</div>
						<div class="blog-desc">
							<p>
	Realizar consulta ,investigación sobre el tema tratado según la guía suministrada ,mucha suerte y espero un trabajo de calidad .
 </p>
						</div>
						<div class="blog-button">
                            <asp:Button class="hover-btn-new orange" ID="btnRealizar" runat="server" Text="Realizar" />
							
						</div>
					</div>
                </div><!-- end col -->

                <div class="col-lg-4 col-md-6 col-12">
                    <div class="blog-item">
						<div class="image-blog">
							<img src="images/blog_2.jpg" alt="" class="img-fluid">
						</div>
						<div class="meta-info-blog">
							<span><i class="fa fa-calendar"></i> <a href="#"> plazo May 11, 2015</a> </span>
                            <span><i class="fa fa-tag"></i>  <a href="#">Realizada</a> </span>
                            <span><i class="fa fa-comments"></i> <a href="#">12 Comments</a></span>
						</div>
						<div class="blog-title">
							<h2><a href="#" title="">Conjuntos Numéricos</a></h2>
						</div>
						<div class="blog-desc">
							<p> Realizar actividad de acuerdo a sus capacidades de aprendizaje y con base a los implementos suministrados </p>
						</div>
						<div class="blog-button">
						 <asp:Button class="hover-btn-new orange" ID="btnreali" runat="server" Text="Realizar" />

						</div>
					</div>
                </div><!-- end col -->

               
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->
	
           </form>
    </body>
   
    </html>
</asp:Content>

