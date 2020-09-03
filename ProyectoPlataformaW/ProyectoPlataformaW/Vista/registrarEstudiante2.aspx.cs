using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;

namespace ProyectoPlataformaW.Vista
{
    public partial class registrarEstudiante2 : System.Web.UI.Page
    {
        List<EntidadEstudianteXlsx> listaEs = new List<EntidadEstudianteXlsx>();
        DataTable dt1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ClEntidadCursosE> listaCurso = new List<ClEntidadCursosE>();
            clCursoD objCurso = new clCursoD();
            listaCurso = objCurso.mtdListarCurso();

            dpdCurso.DataSource = listaCurso;
            dpdCurso.DataTextField = "Curso";
            dpdCurso.DataValueField = "IdCurso";
            dpdCurso.DataBind();
            mtdCargarGrid();


        }

        private void mtdCargarGrid()
        {
            dtgExc.DataSource = listaEs;
            dtgExc.DataBind();

        }

        protected void btnRegistrarE_Click(object sender, EventArgs e)
        {
            clEntidadEstudianteE objEEstu = new clEntidadEstudianteE();
            objEEstu.Nombres = txtNom.Text;
            objEEstu.Apellidos = txtApe.Text;
            objEEstu.Documento = int.Parse(txtDoc.Text);
            objEEstu.Email = txtEma.Text;
            objEEstu.Contrasena = Encrypt.GetSHA256(txtCon.Text);
            objEEstu.IdCurso = int.Parse(dpdCurso.Text);

            clEstudianteD objEstu = new clEstudianteD();
            int resultsql = objEstu.mtdRegistrarEstudiante(objEEstu);

            if (resultsql > 0)
            {
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/inicioAnuncio.aspx'", true);
               // Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                txtNom.Text = "";
                txtApe.Text = "";
                txtDoc.Text = "";
                txtEma.Text = "";
                txtCon.Text = "";
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Verificar si el FileUpload contiene un Archivo
            if (FileUpload1.HasFile)
            {

                //Colocar el nombre del Archivo 
                string filename = FileUpload1.FileName;

                //Enviar el Archivo a un Directorio de forma Temporal
                FileUpload1.SaveAs(Server.MapPath("//" + filename));


                //Importar el Archivo Excel a un Gridview 
                ExportToGrid(Server.MapPath("//" + filename), System.IO.Path.GetExtension(Server.MapPath("/Uploads/" + filename)));

            }
        }
            protected void UploadButton_Click(object sender, EventArgs e)
            {

            // Verifica si existe algun archivo cargado
            
            if (FileUpload1.HasFile)
            {
                lblEstado.Text = "Se cargo correctamente el archivo.";

            }
            else
            {
      
                lblEstado.Text = "Especifique un archivo.";
            }

           

        }
        public void ExportToGrid(String path, String Extension)
        {
            OleDbConnection Conexion = null;
            DataSet DtSet = null;
            OleDbDataAdapter Comando = null;


            if (Extension == ".xls")
            {
                //Conexion para Formato .xls 2003
                Conexion = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0; Data Source='" + path + "';Extended Properties=Excel 8.0;");
            }

            else if (Extension == ".xlsx")
            {
                //Conexion para Formato .xlsx 2007 o 2010
                Conexion = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties=Excel 12.0 Xml;");
            }

            //Seleccionar el archivo Excel
            Conexion.Open();
            DataTable Datable = new DataTable();

            //Seleccionar la Hoja 
            Datable = Conexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            String Hoja = Datable.Rows[0]["TABLE_NAME"].ToString();
       
            Comando = new System.Data.OleDb.OleDbDataAdapter("select * from [" + Hoja + "]", Conexion);
            DtSet = new System.Data.DataSet();
            
            //  Contenido de Excel a un Dataset
            Comando.Fill(DtSet, "[" + Hoja + "]");
            dt1 = DtSet.Tables[0];
            Conexion.Close();

            //  Verificar si el Datatable Contiene Valores
            if (dt1.Rows.Count > 0)
            { 
              // GridView dtgExc = new GridView();
                dtgExc.DataSource = dt1;

                dtgExc.DataBind();

                // Label1.Text = "holi: <b><font color=red>" + dtgExc.Rows.Count.ToString() + "</font></b>";
               
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

