<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="verNotasMateria.aspx.cs" Inherits="ProyectoPlataformaW.Vista.verNotasMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            position: center;
            height: 100%;
            width: 100%;
            left: -1px;
            top: 2px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html>

  


<head>
  <meta charset="utf-8">

    <meta name="viewport" content="width=device-width, initial-scale=1">

  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Notas por materias</title>
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

 <!-- Bootstrap -->
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
 
    <!-- Datatables-->
    <link href="bootstrap/vendors/datatables.net-bs4/css/dataTables.bootstrap4.min.css" 

     rel="stylesheet" />

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

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
                        Notas Por Materias</h3>
                    <br />
                    &nbsp;<br />
                    <br />
                </div>
                <!-- /.card-header -->
                <div class="card-body">
                    
                    <br />
                    <asp:DropDownList ID="ddlMateria" class="form-control" runat="server" Width="60%" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="ddlMateria_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Seleccione la materia</asp:ListItem>
                    </asp:DropDownList>
                    
                    <br />
                    
                    <br />
                    <asp:GridView ID="gvProf" class="jsgrid" CssClass="table table-striped" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbProyectoPlataformaConnectionString1 %>" ProviderName="<%$ ConnectionStrings:dbProyectoPlataformaConnectionString1.ProviderName %>">
                    </asp:SqlDataSource>
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
