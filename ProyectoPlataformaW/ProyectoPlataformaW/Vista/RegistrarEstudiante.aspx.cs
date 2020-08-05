using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;


namespace ProyectoPlataformaW.Vista
{
	public partial class RegistrarEstudiante : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnRegistrarE_Click(object sender, EventArgs e)
        {
            clEntidadEstudianteT objEEstu = new clEntidadEstudianteT();
            objEEstu.Nombres = txtNom.Text;
            objEEstu.Apellidos = txtApe.Text;
            objEEstu.Documento = int.Parse(txtDoc.Text);
            objEEstu.Email = txtEma.Text;
            objEEstu.Contrasena = Encrypt.GetSHA256(txtCon.Text);
            objEEstu.IdCurso = int.Parse(txtCur.Text);

            clEstudianteR objEstu = new clEstudianteR();
            int resultsql = objEstu.mtdRegistrarEstudiante(objEEstu);

        }
    }
}