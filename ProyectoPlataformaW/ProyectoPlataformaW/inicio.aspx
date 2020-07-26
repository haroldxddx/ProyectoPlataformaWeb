<%@ Page Title="" Language="C#" MasterPageFile="~/MaterPage.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="ProyectoPlataformaW.inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <!DOCTYPE html>
  <html lang="en">
  <head runat="server">
     <meta charset="utf-8" />
  <meta http-equiv="Content-Type" content="text/html"/>

  <meta http-equiv="X-UA-Compatible" content="IE=edge">


  <!-- Mobile Metas -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

   <!-- Site Metas -->
  <title>GLVschool</title>
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
        <div class="carousel-item active">
          <div id="home" class="first-section" style="background-image:url('images/slider-01.jpg');">
            <div class="dtab">
              <div class="container">
                <div class="row">
                  <div class="col-md-12 col-sm-12 text-right">
                    <div class="big-tagline">
                      <h2><strong>GLVClasroom</strong> Una Comunidad de Puertas Abiertas</h2>
                      <p class="lead">Somos el hogar de estudiantes, profesores y personal experto, una comunidad que representa con orgullo a la ciudad de Duitama.</p>
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
          <div id="home" class="first-section" style="background-image:url('images/slider-02.jpg');">
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
          <div id="home" class="first-section" style="background-image:url('images/slider-03.jpg');">
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
  </body>
  </html>
</asp:Content>
