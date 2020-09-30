<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="asignarProfesorCursoMateria.aspx.cs" Inherits="ProyectoPlataformaW.Vista.asignarProfesorCursoMateria" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            line-height: 150%;
            text-align: center;
        }

        .auto-style5 {
            left: 0px;
            top: 0px;
        }
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

#container {
    width: 700px;
    margin: 10px auto;
}

.mGrid {
    width: 100%;
    background-color: #fff;
    margin: 5px 0 10px 0;
    border: solid 1px #;
    border-collapse: collapse;
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

    .mGrid .alt {
        background: #fcfcfc url(grd_alt.png) repeat-x top;
    }

    .mGrid .pgr {
        background: #001F3F url(grd_pgr.png) repeat-x top;
    }

   .mGrid .pgr table {
            margin: 5px 0;
        }

        .mGrid .pgr td {
            border-width: 0;
            padding: 0 6px;
            border-left: solid 1px #666;
            font-weight: bold;
            color: #fff;
            line-height: 12px;
        }

        .mGrid .pgr a {
            color: #666;
            text-decoration: none;
        }

            .mGrid .pgr a:hover {
                color: #000;
                text-decoration: none;
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
        <!--  -->
        <link href="Estilo.css" rel="stylesheet" />
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
                                   
                                    ASIGNACIÓN DE PROFESOR A CURSO Y MATERIA</h3>
                               <div class="card">
                
                                    <br />

                                <div class="card-body">

                                    <table style="width: 100%;">
                                        <tr>
                                            <td>&nbsp;<h6 class="auto-style5">Marque una casilla con el curso a seleccionar:</h6>
                                                <td>&nbsp;&nbsp;<asp:GridView ID="gvCurso" runat="server" class="jsgrid" ClientIDMode="Static" Width="432px"  AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" PageSize="7" >
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
                                            <td>&nbsp;<h6>Marque una casilla con el profesor a seleccionar:</h6>
                                            </td>
                                            <td>

                                                <asp:GridView ID="gvProfe" runat="server" class="jsgrid" background-color="#a9c673" ClientIDMode="Static"  AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" PageSize="7"  Width="432px" >
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

                                                <br />

                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;<h6>Marque una casilla con la materia a seleccionar:</h6>
                                            </td>
                                            <td>
                                                <asp:GridView ID="gvMateria" runat="server" class="jsgrid" ClientIDMode="Static"  AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" PageSize="7"  Width="432px" >
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
                                        <asp:LinkButton ID="lnkGuardar" runat="server" class="btn btn-outline-warning float-right" OnClick="lnkGuardar_Click" Height="16px" Width="114px" >GUARDAR SELECCIÒN</asp:LinkButton>
                                        &nbsp;
                                    </p>

                                    <br />
                                </div>

                                <br />
                                <br />
                        </div>

                        <section class="content">
                            <div class="card">

                                <!-- /.card-header -->
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
