﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="buscadorEstudiantes.aspx.cs" Inherits="ProyectoPlataformaW.Vista.buscadorEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
         * {
            padding: 0;
            margin: 0;
        }

        body {
            font: 11px Tahoma;
        }

        h1 {
            font: bold 32px Times;
            color: #666;
            text-align: center;
            padding: 20px 0;
        }



        .mGrid td {
            padding: 2px;
            border: solid 1px #c1c1c1;
            color: #2C3038;
        }

        .mGrid th {
            padding: 4px 2px;
            color: #fff;
            background: #001F3F url(grd_head.png) repeat-x top;
            border-left: solid 1px #525252;
            font-size: 0.9em;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Buscador de Estudiantes</title>
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
                            <h1 class="card-title">
                                <br />
                                <h3 class="center">
                                    <br />
                                    BUSCADOR DE ESTUDIANTES</h3>                 
                </div>
                <!-- /.card-header -->
                <div class="card-body">
                    
                    <br />
                    <div class="input-group input-group-sm">
                          
                        <asp:TextBox ID="txtNombreE" runat="server" class="form-control form-control-navbar" type="search" placeholder="Ingrese el nombre a buscar" aria-label="Search" OnTextChanged="txtNombreE_TextChanged" Width="60%"></asp:TextBox>
                          
                        </div>
                    
                    <br />
                    <asp:DropDownList ID="cmbCurso" class="form-control" runat="server" Width="60%" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="cmbCurso_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Seleccione el curso</asp:ListItem>
                    </asp:DropDownList>
                    
                    <br />
                    
                    <br />
                    <asp:GridView ID="gvEstu" class="jsgrid"  runat="server" ClientIDMode="Static" AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" PageSize="7" Width="818px"></asp:GridView>
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
