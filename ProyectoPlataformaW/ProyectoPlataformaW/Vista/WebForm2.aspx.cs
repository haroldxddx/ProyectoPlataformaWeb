using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<estudiantesViewModel> listaEs = new List<estudiantesViewModel>();
        estudiantesViewModel objEVM = new estudiantesViewModel();
        protected void Page_Load(object sender, EventArgs e)
        {

            mtdCargarGrid();

        }
        private void mtdCargarGrid()
        {
          //  if (FileUpload1.HasFile && Path.GetExtension(FileUpload1.FileName) == ".xlsx")
          //  {

                   //    Class1 objEst = new Class1();
            //    listaEs = objEst.mtdlis();

            //    dtgExc.DataSource = listaEs;

            //    dtgExc.DataBind();

           // }

        }
        protected void UploadButton_Click(object sender, EventArgs e)
        {
         
        }

        DataTable dt1 = new DataTable();

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            //Verificar si el FileUpload con tiene un Archivo
            if (FileUpload1.HasFile)
            {

                //Colocar el nombre del Archivo en una Variable String
                string filename = FileUpload1.FileName;

                //Enviar el Archivo a un Directorio de forma Temporal
                FileUpload1.SaveAs(Server.MapPath("//" + filename));



                //Importar el Archivo Excel a un Gridview con el Metodo ExportToGrid
                ExportToGrid(Server.MapPath("//" + filename), Path.GetExtension(Server.MapPath("/Uploads/" + filename)));

            }
        }
        public void ExportToGrid(String path, String Extension)
        {
            OleDbConnection MiConexion = null;
            DataSet DtSet = null;
            OleDbDataAdapter MiComando = null;


            if (Extension == ".xls")
            {
                //Conexion para Formato .xls 2003
                MiConexion = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; Data Source='" + path + "';Extended Properties=Excel 8.0;");
            }

            else if (Extension == ".xlsx")
            {
                //Conexion para Formato .xlsx 2007 o 2010
                MiConexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties=Excel 12.0 Xml;");
            }

            //Seleccionar el archivo Excel
            MiConexion.Open();
            DataTable Datable = new DataTable();

            //Seleccionar la Hoja que Esta Activa
            Datable = MiConexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            String Nombre_Hoja = Datable.Rows[0]["TABLE_NAME"].ToString();


            MiComando = new System.Data.OleDb.OleDbDataAdapter("select * from [" + Nombre_Hoja + "]", MiConexion);
            DtSet = new System.Data.DataSet();
            //Bindear todo el Contenido del Excel a un Dataset
       //     MiComando.Fill(DtSet, "[" + Nombre_Hoja + "]");
     //       dt1 = DtSet.Tables[0];
       //     MiConexion.Close();
            //Verificar si el Datatable Contiene Valores
            if (dt1.Rows.Count > 0)
            {
                GridView GridView2 = new GridView();
                GridView2.DataSource = dt1;
                GridView2.DataBind();
                Label1.Text = "Cantidad de Cuentas a Actualizar: <b><font color=red>" + GridView2.Rows.Count.ToString() + "</font></b>";
                //Panel_Modificaciones.Controls.Add(GridView2);
            }
            //Eliminar el Archivo Excel del Directorio Temporal
        //    if (System.IO.File.Exists(path))
         //   {
                System.IO.File.Delete(path);
        //    }
            //Vaciar El Dataset y los Datatable
            dt1 = null;
        //    DtSet = null;
            Datable = null;
        }

    }

        }
  
    
