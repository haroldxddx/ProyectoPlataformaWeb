<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="listadoProfesor.aspx.cs" Inherits="ProyectoPlataformaW.Vista.listadoProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            position: center;
            height: 100%;
            width: 100%;
            left: -1px;
            top: 2px;
        }
        .auto-style5 {
            float: left;
            font-size: 1.1rem;
            font-weight: 400;
            left: 0px;
            top: 0px;
            width: 410px;
            margin: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Listado de Profesores</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <!-- Font Awesome -->
  <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
  <!-- jsGrid -->
  <link rel="stylesheet" href="/Vista/plugins/jsgrid/jsgrid.min.css">
  <link rel="stylesheet" href="/Vista/plugins/jsgrid/jsgrid-theme.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
  <!-- Google Font: Source Sans Pro -->
  <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition sidebar-mini">

<div class="wrapper">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
       

        <section class="content">
            <div class="card">
                <div class="card-header">
                    <h3 class="card-title">
                        <br />
                        Listado de Profesores</h3>
                    <br />
                    <asp:Label ID="lblUsera" runat="server" Text="Label" Visible="False"></asp:Label>
                   
                    <br />
                    <br />
                </div>
                <section class="content">
            <div class="card">
                <div class="card-header">
                    <h3 class="auto-style5">
                        <br />
                        Ingrese el nombre de profesor que desee buscar : </h3>
                    <br />
                    <asp:TextBox ID="txtBuscar" runat="server" Width="217px"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" OnClick="btnBuscar_Click" />
                    <br />
                    <br />
                </div>
                <!-- /.card-header -->
                <div class="card-body">
                    <asp:GridView ID="gvProf" class="jsgrid" runat="server" CssClass="table table-striped" OnSelectedIndexChanged="gvProf_SelectedIndexChanged"></asp:GridView>
                    <br />
                </div>
                <!-- /.card-body -->
            </div>
            <!-- /.card -->
        </section>
    </div>
</div>

    <br />

<!-- jQuery -->
<script src="/Vista/plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="/Vista/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- jsGrid -->
<script src="/Vista/plugins/jsgrid/demos/db.js"></script>
<script src="/Vista/plugins/jsgrid/jsgrid.min.js"></script>
<!-- AdminLTE App -->
<script src="/Vista/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="/Vista/dist/js/demo.js"></script>
<!-- page script -->
<script>
  $(function () {
    $("#jsGrid1").jsGrid({
        height: "100%",
        width: "100%",
 
        sorting: true,
        paging: true,
 
        data: db.clients,
 
        fields: [
            { name: "Name", type: "text", width: 150 },
            { name: "Age", type: "number", width: 50 },
            { name: "Address", type: "text", width: 200 },
            { name: "Country", type: "select", items: db.countries, valueField: "Id", textField: "Name" },
            { name: "Married", type: "checkbox", title: "Is Married" }
        ]
    });
  });
</script>
</body>
</html>
</asp:Content>
