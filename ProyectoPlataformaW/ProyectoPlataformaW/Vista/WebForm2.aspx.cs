using DocumentFormat.OpenXml.Drawing;
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
        List<EntidadEstudianteXlsx> listaEs = new List<EntidadEstudianteXlsx>();
        DataTable dt1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

          mtdCargarGrid();

        }
        private void mtdCargarGrid()
        {
           // SLDocument sl = new SLDocument(path);
           //  if (FileUpload1.HasFile && Path.GetExtension(FileUpload1.FileName) == ".xlsx")
            // {


            //    Class1 objEst = new Class1();
             //  listaEs = objEst.mtdlis();
            
              dtgExc.DataSource = listaEs;

              dtgExc.DataBind();

           //}

        }
       
            protected void UploadButton_Click(object sender, EventArgs e)
            {

                // Specify the path on the server to
                // save the uploaded file to.
                string savePath = @"c:\temp\uploads\";

                // Before attempting to save the file, verify
                // that the FileUpload control contains a file.
                if (FileUpload1.HasFile)
                {
                    // Get the size in bytes of the file to upload.
                    int fileSize = FileUpload1.PostedFile.ContentLength;

                    // Allow only files less than 2,100,000 bytes (approximately 2 MB) to be uploaded.
                    if (fileSize < 2100000)
                    {

                        // Append the name of the uploaded file to the path.
                        savePath += Server.HtmlEncode(FileUpload1.FileName);

                        // Call the SaveAs method to save the 
                        // uploaded file to the specified path.
                        // This example does not perform all
                        // the necessary error checking.               
                        // If a file with the same name
                        // already exists in the specified path,  
                        // the uploaded file overwrites it.
                        FileUpload1.SaveAs(savePath);

                        // Notify the user that the file was uploaded successfully.
                        UploadStatusLabel.Text = "Your file was uploaded successfully.";
                    }
                    else
                    {
                        // Notify the user why their file was not uploaded.
                        UploadStatusLabel.Text = "Your file was not uploaded because " +
                                                 "it exceeds the 2 MB size limit.";
                    }
                }
                else
                {
                    // Notify the user that a file was not uploaded.
                    UploadStatusLabel.Text = "You did not specify a file to upload.";
                }
            }



    


        protected void LinkButton1_Click(object sender, EventArgs e)
          {
             //Verificar si el FileUpload con tiene un Archivo
             if (FileUpload1.HasFile)
             {

                 //Colocar el nombre del Archivo en una Variable String
                 string filename = FileUpload1.FileName;

                 //Enviar el Archivo a un Directorio de forma Temporal
                 FileUpload1.SaveAs(Server.MapPath("//" + filename));



                 //Importar el Archivo Excel a un Gridview con el Metodo ExportToGrid
                 ExportToGrid(Server.MapPath("//" + filename), System.IO.Path.GetExtension(Server.MapPath("/Uploads/" + filename)));

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
                 MiConexion = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0; Data Source='" + path + "';Extended Properties=Excel 8.0;");
             }

             else if (Extension == ".xlsx")
             {
                 //Conexion para Formato .xlsx 2007 o 2010
                 MiConexion = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties=Excel 12.0 Xml;");
             }

             //Seleccionar el archivo Excel
             MiConexion.Open();
             DataTable Datable = new DataTable();

            //Seleccionar la Hoja que Esta Activa


             Datable = MiConexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
             String Nombres = Datable.Rows[0]["TABLE_NAME"].ToString();
            //    SLDocument sl = new SLDocument(MiConexion);

            MiComando = new System.Data.OleDb.OleDbDataAdapter("select * from [" + Nombres + "]", MiConexion);
            DtSet = new System.Data.DataSet();
            // Bindear todo el Contenido del Excel a un Dataset
             MiComando.Fill(DtSet, "[" + Nombres + "]");
            dt1 = DtSet.Tables[0];
             MiConexion.Close();
           //  Verificar si el Datatable Contiene Valores
             if (dt1.Rows.Count > 0)
             {
                // GridView dtgExc = new GridView();
                dtgExc.DataSource = dt1;

                 dtgExc.DataBind();
               
                // Label1.Text = "Cantidad de Cuentas a Actualizar: <b><font color=red>" + dtgExc.Rows.Count.ToString() + "</font></b>";
                //Controls.Add(GridView2);
             }
             //Eliminar el Archivo Excel del Directorio Temporal
           if (System.IO.File.Exists(path))
             {
                 System.IO.File.Delete(path);
                }
            //Vaciar El Dataset y los Datatable
            dt1 = null;
             DtSet = null;
             Datable = null;
         }
    }

}


