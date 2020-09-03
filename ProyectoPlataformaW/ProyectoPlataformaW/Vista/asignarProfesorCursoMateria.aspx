<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="asignarProfesorCursoMateria.aspx.cs" Inherits="ProyectoPlataformaW.Vista.asignarProfesorCursoMateria" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            line-height: 150%;
            text-align: center;
        }
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
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Asignar Profesor A Curso Materia</title>
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
                                Asignar Profesor a Curso Materia</h3>
                            <br />

                            <br />
                            <br />
                        </div>
                        
                        <section class="content">
                            <div class="card">
                                
                                <!-- /.card-header -->
                                <div class="card-body">
                                    <p class="auto-style3">
        &nbsp;
        &nbsp;
    </p>

    <table style="width: 100%;">
        <tr>
            <td>&nbsp; SELECCIONE UN CURSO<td>&nbsp;&nbsp;<asp:GridView ID="gvCurso" runat="server" class="jsgrid" ClientIDMode="Static" Width="432px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chbItemC" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

        <asp:Label ID="lblMensajeC" runat="server" Visible="False"></asp:Label>

            <br />

            <br />

            </td>
            </td>
        </tr>
        <tr>
            <td>&nbsp;SELECCIONE UN PROFESOR</td>
            <td>

                <asp:GridView ID="gvProfe" runat="server" class="jsgrid" ClientIDMode="Static" CssClass="auto-style4" Width="432px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chbItem" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

        <asp:Label ID="lblMensaje" runat="server" Visible="False"></asp:Label>

                <br />

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp; SELECCIONE UN MATERIA</td>
            <td><asp:GridView ID="gvMateria" runat="server" class="jsgrid" ClientIDMode="Static" Width="427px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chbItemM" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

        <asp:Label ID="lblMensajeM" runat="server" Visible="False"></asp:Label>

            </td>

        </tr>
    </table>
    <p class="auto-style3">
        &nbsp;
    </p>
    <p class="auto-style3">
        &nbsp;
    </p>

    <p class="auto-style3">
        <asp:LinkButton ID="lnkGuardar" runat="server" OnClick="lnkGuardar_Click">GUARDAR</asp:LinkButton>
        &nbsp;
    </p>
                                    
                                    <br />
                                </div>
                                <!-- /.card-body -->
                            </div>
                            <!-- /.card -->
                        </section>
                    </div>
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
