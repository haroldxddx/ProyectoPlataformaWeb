<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEstud.Master" AutoEventWireup="true" CodeBehind="foroTot2.aspx.cs" Inherits="ProyectoPlataformaW.Vista.foroTot2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Entregas de Estudiantes</title>
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
    </head>
    <body class="hold-transition sidebar-mini">
        <!-- Site wrapper -->
        <div class="wrapper">
            <!-- Navbar -->
            <!-- Content Wrapper. Contains page content -->
            <div class="content-wrapper">


                <!-- Main content -->
                <section class="content">

                    <!-- Default box -->
                     <section class="content">
                    <div class="card">
                        <div class="card-header">
                            <h1 class="card-title">
                                <br />
                                <h3 class="center">
                                    <br />
                                    Foros</h3>
                            <br />


                        </div>


                        <div class="card-body p-0">
                            <table class="table table-striped projects">
                                <thead>
                                    <tr>
                                        <th style="width: 1%">Titulo
                                        </th>
                                        <th style="width: 20%">Fecha
                                        </th>
                                        <th style="width: 30%">Descripcion
                                        </th>
                                        <th>Tipo
                                        </th>

                                        <th style="width: 20%"></th>
                                    </tr>
                                </thead>

                                <asp:Repeater ID="repeaterEstud" runat="server" OnItemCommand="repeaterEstud_ItemCommand">

                                    <ItemTemplate>
                                        <tbody>
                                            <tr>

                                                <td>
                                                    <asp:Label ID="lblTitulo" runat="server" Text='<%# Eval("Titulo") %>'></asp:Label><asp:Label ID="lblIdForo" runat="server" Text='<%# Eval("IdForo") %>'></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblFecha" runat="server" Text='<%# Eval("Fecha") %>'></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblDesc" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblTipo" runat="server" Text='<%# Eval("Tipo") %>'></asp:Label>
                                                </td>

                                                <td class="project-actions text-right">


                                                    <asp:Button ID="btnVerEntrega" runat="server" Text="Entrar " class="btn btn-info btn-sm" />

                                                </td>
                                            </tr>
                                        </tbody>

                                    </ItemTemplate>

                                </asp:Repeater>

                            </table>
                            <br />
                            <br />
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->

                </section>
                <!-- /.content -->
            </div>
            <!-- /.content-wrapper -->


            <!-- /.control-sidebar -->
        </div>
        <!-- ./wrapper -->

        <!-- jQuery -->
        <script src="/Vista/plugins/jquery/jquery.min.js"></script>
        <!-- Bootstrap 4 -->
        <script src="/Vista/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
        <!-- AdminLTE App -->
        <script src="/Vista/dist/js/adminlte.min.js"></script>
        <!-- AdminLTE for demo purposes -->
        <script src="/Vista/dist/js/demo.js"></script>
    </body>
    </html>
</asp:Content>
