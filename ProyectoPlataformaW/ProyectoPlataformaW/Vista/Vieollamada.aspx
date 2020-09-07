<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vieollamada.aspx.cs" Inherits="ProyectoPlataformaW.Vista.Vieollamada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Video llamada</title>


  
    <link type="text/css" rel="stylesheet" href="node_modules/@zoomus/websdk/dist/css/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="node_modules/@zoomus/websdk/dist/css/react-select.css" />
    <meta name="format-detection" content="telephone=no"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"/>
     <link type="text/css" rel="stylesheet" href="https://source.zoom.us/1.7.9/css/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="https://source.zoom.us/1.7.9/css/react-select.css" />


 

</head>
<body class="ReactModal__Body--open"> 
    <form id="form1" runat="server">
        <div>


    <script src="node_modules/react/umd/react.production.min.js"></script>
    <script src="node_modules/react-dom/umd/react-dom.production.min.js"></script>
    <script src="node_modules/redux/dist/redux.min.js"></script>
    <script src="node_modules/redux-thunk/dist/redux-thunk.min.js"></script>
    <script src="node_modules/lodash/lodash.min.js"></script>
    <script src="node_modules/jquery/dist/jquery.min.js"></script>
    <script src="js/tool.js"></script>
    <script src="./static/meeting.min.js"></script>





    <script src="https://source.zoom.us/1.7.9/lib/vendor/react.min.js"></script>
    <script src="https://source.zoom.us/1.7.9/lib/vendor/react-dom.min.js"></script>
    <script src="https://source.zoom.us/1.7.9/lib/vendor/redux.min.js"></script>
    <script src="https://source.zoom.us/1.7.9/lib/vendor/redux-thunk.min.js"></script>
    <script src="https://source.zoom.us/1.7.9/lib/vendor/jquery.min.js"></script>
    <script src="https://source.zoom.us/1.7.9/lib/vendor/lodash.min.js"></script>

    <!-- import ZoomMtg -->
    <script src="https://source.zoom.us/zoom-meeting-1.7.9.min.js"></script>
    
    <!-- import local .js file -->
    <script src="js/index.js"></script>



      




    <div id="zmmtg-root"></div>
    <div id="aria-notify-area"></div>
    
    <!-- added on meeting init -->
    <div class="ReactModalPortal"></div>
    <div class="ReactModalPortal"></div>
    <div class="ReactModalPortal"></div>
    <div class="ReactModalPortal"></div>
    <div class="global-pop-up-box"></div>
    <div class="sharer-controlbar-container sharer-controlbar-container--hidden"></div>



        </div>
    </form>
</body>
</html>
