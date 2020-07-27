<%@ Page Title="" Language="C#" MasterPageFile="~/MaterPage.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="ProyectoPlataformaW.inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
        }
        .auto-style2 {
            width: 98%;
            height: 515px;
        }
        .auto-style3 {
            width: 99%;
            height: 370px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
  <html lang="en">
  <head >
     <meta charset="utf-8" />
  <meta http-equiv="Content-Type" content="text/html"/>

  <meta http-equiv="X-UA-Compatible" content="IE=edge">


  <!-- Mobile Metas -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

   <!-- Site Metas -->
  <title>GlvClassroom</title>
  <meta name="keywords" content="">
  <meta name="description" content="">
  <meta name="author" content="">


  <!-- Site Icons -->
  <link rel="shortcut icon" href="Vista/images/favicon.ico" type="image/x-icon" />
  <link rel="apple-touch-icon" href="Vista/images/apple-touch-icon.png">

  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="Vista/css/bootstrap.min.css">
  <!-- Site CSS -->
  <link rel="stylesheet" href="Vista/style.css">
  <!-- ALL VERSION CSS -->
  <link rel="stylesheet" href="Vista/css/versions.css">
  <!-- Responsive CSS -->
  <link rel="stylesheet" href="Vista/css/responsive.css">
  <!-- Custom CSS -->
  <link rel="stylesheet" href="Vista/css/custom.css">


    <script src="Vista/js/modernizer.js"></script>
    </head>
    <body class="host_version">
    <div id="carouselExampleControls" class="carousel slide bs-slider box-slider" data-ride="carousel" data-pause="hover" data-interval="false" >
      <!-- Indicators -->
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleControls" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleControls" data-slide-to="1"></li>
        <li data-target="#carouselExampleControls" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner" role="listbox">
        <div class="carousel-item active" style="left: 0px; top: 0px; height: 402px">
          <div id="home" class="first-section" style="background-image:url('Vista/images/slider-01.jpg');">
            <div class="dtab">
              <div class="container">
                <div class="row">
                  <div class="col-md-12 col-sm-12 text-right">
                    <div class="big-tagline">
                      <h2><strong>GLVClassroom</strong> Una Comunidad de Puertas Abiertas</h2>
                      <p class="lead">&nbsp;Somos el hogar de estudiantes, profesores y personal experto, una comunidad que representa con orgullo a la ciudad de Duitama.</p>
                        <a href="#" class="hover-btn-new"><span>Contactanos</span></a>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <a href="#" class="hover-btn-new"><span>Ver mas</span></a>
                    </div>
                  </div>
                </div><!-- end row -->
              </div><!-- end container -->
            </div>
          </div><!-- end section -->
        </div>
        <div class="carousel-item style="left: 0px; top: 0px; height: 402px">
          <div id="home" class="first-section" style="background-image:url('Vista/images/slider-02.jpg');">
            <div class="dtab">
              <div class="container">
                <div class="row">
                  <div class="col-md-12 col-sm-12 text-left">
                    <div class="big-tagline">
                      <h2 data-animation="animated zoomInRight">GLVClasroom <strong>educacion virtual</strong></h2>
                      <p class="lead" data-animation="animated fadeInLeft">Mas de 50 años generando estudiantes de calidad  </p>
                        <a href="#" class="hover-btn-new"><span>Contactanos</span></a>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <a href="#" class="hover-btn-new"><span>Ver mas</span></a>
                    </div>
                  </div>
                </div><!-- end row -->
              </div><!-- end container -->
            </div>
          </div><!-- end section -->
        </div>
        <div class="carousel-item">
          <div id="home" class="first-section" style="background-image:url('Vista/images/slider-03.jpg');">
            <div class="dtab">
              <div class="container">
                <div class="row">
                  <div class="col-md-12 col-sm-12 text-center">
                    <div class="big-tagline">
                      <h2 data-animation="animated zoomInRight"><strong>Ciencia con educación </strong> integral</h2>
                      <p class="lead" data-animation="animated fadeInLeft">Tenemos la convicción de que el entrenamiento en el uso de estas herramientas tecnológicas que promueven las competencias digitales necesarias entre docentes y estudiantes

                        </p>
                        <a href="#" class="hover-btn-new"><span>Contactanos</span></a>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <a href="#" class="hover-btn-new"><span>Ver mas</span></a>
                    </div>
                  </div>
                </div><!-- end row -->
              </div><!-- end container -->
            </div>
          </div><!-- end section -->
        </div>
        <!-- Left Control -->
        <a class="new-effect carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
          <span class="fa fa-angle-left" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>

        <!-- Right Control -->
        <a class="new-effect carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
          <span class="fa fa-angle-right" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>
    <div id="overviews" class="section wb">
        <div class="container">
            <div class="section-title row text-center">
                <div class="col-md-8 offset-md-2">
                    <h3>Conoce</h3>
                    <p class="lead">Explore CGLV</p>
                </div>
            </div><!-- end title -->

            <div class="row align-items-center">
                <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12">
                    <div class="message-box">
                        <h4>2020 el año de la nueva educación </h4>
                        <h2>Bienvenido a GLVclasroom   una educación de calidad </h2>
                        <p>Siempre hay algo sorprendente sucediendo en El Colegio Guillermo León Valencia de Duitama. Ya sea en alguna de nuestras sedes o en Duitama, nuestros estudiantes, Profesores ex alumnos y demás personal aprovechan el día como se muestra a continuación.</p>


                        <a href="#" class="hover-btn-new orange"><span>Ver mas </span></a>
                    </div><!-- end messagebox -->
                </div><!-- end col -->

        <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12">
                    <div class="post-media wow fadeIn">
                        &nbsp;<img alt="colegioport" class="auto-style2" src="Imagenes/colegioporteria%20(2).jpg" /></div><!-- end media -->
                </div><!-- end col -->
      </div>
      <div class="row align-items-center">
        <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12">
                    <div class="post-media wow fadeIn">
                        &nbsp;<img alt="estudiantes" class="auto-style3" src="Imagenes/colegioestu.jpeg" /></div><!-- end media -->
                </div><!-- end col -->

        <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12">
                    <div class="message-box">
                        <h2>Una Comunidad de Puertas Abiertas</h2>
                        <p>Durante mas de 50 años de existencia, el Colegio Guillermo León Valencia de Duitama ha implementado programas académicos y técnicos orientando un proceso de formación integral de la más alta calidad al servicio de la niñez y la juventud. Somos el hogar de estudiantes, profesores y personal experto, una comunidad que representa con orgullo a la ciudad de Duitama</p>


                        <a href="#" class="hover-btn-new orange"><span>Ver mas</span></a>
                    </div><!-- end messagebox -->
                </div><!-- end col -->

            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->

  <div class="section cl">
    <div class="container">
      <div class="row text-left stat-wrap">
        <div class="col-md-4 col-sm-4 col-xs-12">
          <span data-scroll class="global-radius icon_wrap effect-1 alignleft"><i class="flaticon-study"></i></span>
          <p class="stat_count">4000</p>
          <h3>Estudiantes </h3>
        </div><!-- end col -->

        <div class="col-md-4 col-sm-4 col-xs-12">
          <span data-scroll class="global-radius icon_wrap effect-1 alignleft"><i class="flaticon-online"></i></span>
          <p class="stat_count">540</p>
          <h3>cursos</h3>
        </div><!-- end col -->

        <div class="col-md-4 col-sm-4 col-xs-12">
          <span data-scroll class="global-radius icon_wrap effect-1 alignleft"><i class="flaticon-years"></i></span>
          <p class="stat_count">55</p>
          <h3>Años educando</h3>
        </div><!-- end col -->
      </div><!-- end row -->
    </div><!-- end container -->
  </div><!-- end section -->

  <div class="parallax section dbcolor">
      <div class="container">
          <div class="row logos">
              <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                  <a href="#"><img src="Vista/images/logo_01.png" alt="" class="img-repsonsive"></a>
              </div>
              <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                  <a href="#"><img src="Vista/images/logo_02.png" alt="" class="img-repsonsive"></a>
              </div>
              <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                  <a href="#"><img src="Vista/images/logo_03.png" alt="" class="img-repsonsive"></a>
              </div>
              <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                  <a href="#"><img src="Vista/images/logo_04.png" alt="" class="img-repsonsive"></a>
              </div>
              <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                  <a href="#"><img src="Vista/images/logo_05.png" alt="" class="img-repsonsive"></a>
              </div>
              <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                  <a href="#"><img src="Vista/images/logo_06.png" alt="" class="img-repsonsive"></a>
              </div>
          </div><!-- end row -->
      </div><!-- end container -->
  </div><!-- end section -->




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
                  <p class="footer-company-name">All Rights Reserved. © 2020 <a href="#"><span class="auto-style1">GlvClassroom</span></a> Design By : <a href="https://html.design/">G<span class="auto-style1">rupo 4</span></a></p>
              </div>
          </div>
      </div><!-- end container -->
  </div><!-- end copyrights -->


  </body>
  </html>
</asp:Content>
