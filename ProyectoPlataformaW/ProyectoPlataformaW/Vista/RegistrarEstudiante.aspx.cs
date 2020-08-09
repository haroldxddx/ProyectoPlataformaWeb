using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;


namespace ProyectoPlataformaW.Vista
{
	public partial class RegistrarEstudiante : System.Web.UI.Page
	{
        private string path = @"C:\Users\USUARIO\source\repos\ProyectoPlataformaWeb\ProyectoPlataformaW\Excel_BD.xlsx";
        protected void Page_Load(object sender, EventArgs e)
        {
        

            List<clEntidadCursosE> listaCurso = new List<clEntidadCursosE>();
            clCursoD objCurso = new clCursoD();
            listaCurso = objCurso.mtdListarCurso();

            dpdCurso.DataSource = listaCurso;
            dpdCurso.DataTextField = "Curso";
            dpdCurso.DataValueField = "IdCurso";
            dpdCurso.DataBind();

            
            
            SLDocument sl = new SLDocument(path);

            int iRow = 2;
            List<estudiantesViewModel> listaEs = new List<estudiantesViewModel>();
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow,1))) ;
            {
                estudiantesViewModel objEVM = new estudiantesViewModel();
                objEVM.Nombres = sl.GetCellValueAsString(iRow, 1);
                objEVM.Apellidos = sl.GetCellValueAsString(iRow, 2);
                objEVM.Documento = sl.GetCellValueAsInt32(iRow, 3);
                objEVM.Email = sl.GetCellValueAsString(iRow, 4);
                objEVM.Contrasena = sl.GetCellValueAsString(iRow, 5);
                objEVM.IdCurso = sl.GetCellValueAsInt32(iRow, 6);

                listaEs.Add(objEVM);



                iRow++;
            }
            dtgExcel.DataSource = listaEs;
                

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

        }

        protected void dpdCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubirAr_Click(object sender, EventArgs e)
        {
           
        }
    }
}