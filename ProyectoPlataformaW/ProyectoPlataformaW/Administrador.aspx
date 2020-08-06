<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="ProyectoPlataformaW.Administrador" %>
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

    <!-- Modernizer for Portfolio -->
    <script src="Vista/js/modernizer.js"></script>

    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->



    </head>
    <body>

        <!-- LOADER -->
	<div id="preloader">
		<div class="loader-container">
			<div class="progress-br float shadow">
				<div class="progress__item"></div>
			</div>
		</div>
	</div>
	<!-- END LOADER -->	

          <a href="#" id="scroll-to-top" class="dmtop global-radius"><i class="fa fa-angle-up"></i></a>

        <!-- ALL JS FILES -->
    <script src="Visata/js/all.js"></script>
    <!-- ALL PLUGINS -->
    <script src="Vista/js/custom.js"></script>
	<script src="Vista/js/timeline.min.js"></script>
	<script>
		timeline(document.querySelectorAll('.timeline'), {
			forceVerticalMode: 700,
			mode: 'horizontal',
			verticalStartPosition: 'left',
			visibleItems: 4
		});
	</script>

    </body>
    </html>
</asp:Content>

