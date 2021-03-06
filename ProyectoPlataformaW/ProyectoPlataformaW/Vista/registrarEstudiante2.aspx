﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="registrarEstudiante2.aspx.cs" Inherits="ProyectoPlataformaW.Vista.registrarEstudiante2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            position: relative;
            width: 100%;
            min-height: 1px;
            -ms-flex: 0 0 100%;
            flex: 0 0 100%;
            max-width: 100%;
            left: 0px;
            top: 0px;
            padding-left: 7.5px;
            padding-right: 7.5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Registrar Estudiantes</title>
        <!-- Tell the browser to be responsive to screen width -->
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <!-- Font Awesome -->
        <link rel="stylesheet" href="/Vista/plugins/fontawesome-free/css/all.min.css">
        <!-- Ionicons -->
        <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
        <!-- overlayScrollbars -->
        <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
        <!-- Google Font: Source Sans Pro -->
        <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
        <!-- overlayScrollbars -->
        <link rel="stylesheet" href="/Vista/dist/css/adminlte.min.css">
        <!-- SweetAlert2 -->
        <link rel="stylesheet" href="/Vista/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css">
        <!-- Toastr -->
        <link rel="stylesheet" href="/Vista/plugins/toastr/toastr.min.css">
    </head>
    <body class="hold-transition sidebar-mini">
        <!-- Site wrapper -->
        <div class="wrapper">

            <!-- Content Wrapper. Contains page content -->
            <div class="content-wrapper">
                <!-- Content Header (Page header) -->
                <section class="content-header">
                    <div class="container-fluid">
                        <div class="row mb-2">
                            <div class="col-sm-6">
                                <h1>Registros</h1>
                            </div>

                        </div>
                    </div>
                    <!-- /.container-fluid -->
                </section>

                <!-- Main content -->
                <section class="content">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="card card-dark">
                                <div class="card-header">
                                    <h3 class="card-title">Registrar Estudiante</h3>


                                </div>
                                <div class="card-body">
                                    <div class="form-group">
                                        <label for="inputName">Nombres</label>

                                        <asp:TextBox ID="txtNom" runat="server" placeholder="Ingrese Nombre" class="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputDescription">Apellidos</label>
                                        <asp:TextBox ID="txtApe" runat="server" placeholder="Ingrese Apellido" class="form-control"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <label for="inputClientCompany">Documento</label>
                                        <asp:TextBox ID="txtDoc" runat="server" placeholder="Ingrese Documento" class="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputProjectLeader">Email</label>
                                        <asp:TextBox ID="txtEma" runat="server" placeholder="Ingrese Email" class="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputClientCompany">Contraseña</label>
                                        <asp:TextBox ID="txtCon" runat="server" type="password" placeholder="Ingrese Contraseña" class="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputClientCompany">Curso</label>

                                        <br />

                                        <asp:DropDownList ID="dpdCurso" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="row">


                                        <div class="col-12">

                                            <asp:Button ID="btnRegistrarE" type="submit" runat="server" class="btn btn-outline-warning float-right " Text="Registrar" OnClick="btnRegistrarE_Click" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                                            &nbsp;<asp:Label ID="lblEstado" runat="server" Text=""></asp:Label>
                                            <asp:FileUpload ID="FileUpload1" runat="server" />
                                            <asp:GridView ID="dtgExc" runat="server" AutoGenerateColumns="False" EmptyDataText="No hay registros de datos para mostrar." Visible="False">
                                                <Columns>
                                                    <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
                                                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                                                    <asp:BoundField DataField="Documento" HeaderText="Documento" SortExpression="Documento" />
                                                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                                    <asp:BoundField DataField="Contrasena" HeaderText="Contrasena" SortExpression="Contrasena" />
                                                    <asp:BoundField DataField="IdCurso" HeaderText="IdCurso" SortExpression="IdCurso" />
                                                </Columns>
                                            </asp:GridView>
                                            &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-outline-warning float-right" OnClick="LinkButton1_Click1">Guardar Archivo</asp:LinkButton>
                                            <br />
                                            <br />
                                            <br />
                                        </div>
                                    </div>
                                    <div class="row">


                                        <div class="auto-style2">
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                    </div>

                                </div>
                                <!-- /.card-body -->
                            </div>
                            <!-- /.card -->
                        </div>


                    </div>

                </section>
            </div>
        </div>
        <!-- jQuery -->
        <script src="/Vista/plugins/jquery/jquery.min.js"></script>
        <!-- Bootstrap 4 -->
        <script src="/Vista/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
        <!-- AdminLTE App -->
        <script src="/Vista/dist/js/adminlte.min.js"></script>
        <!-- AdminLTE for demo purposes -->
        <script src="/Vista/dist/js/demo.js"></script>
        <!-- SweetAlert2 -->
        <script src="/Vista/plugins/sweetalert2/sweetalert2.min.js"></script>
        <!-- Toastr -->
        <script src="/Vista/plugins/toastr/toastr.min.js"></script>

        <script type="text/javascript">
            function registro() {
                const Toast = Swal.mixin({
                    toast: true,
                    position: 'top-end',
                    showConfirmButton: false,
                    timer: 2000
                });

                Toast.fire({
                    icon: 'success',
                    title: 'Registro Realizado Correctamente'
                });

            };

        </script>
    </body>
    </html>
    <br />
</asp:Content>
