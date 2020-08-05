using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;


namespace ProyectoPlataformaW
{
    public partial class RegistrarProfesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            clEntidadProfesor objEProfe = new clEntidadProfesor();
            objEProfe.Nombres = txtNom.Text;
            objEProfe.Apellidos = txtApe.Text;
            objEProfe.Documento = int.Parse(txtDoc.Text);
            objEProfe.Email = txtEma.Text;
            objEProfe.Contrasena = Encrypt.GetSHA256(txtCon.Text);
            objEProfe.Especialidad = txtEsp.Text;

            clProfesorR objProfe = new clProfesorR();
            int result = objProfe.mtdRegistrarProfesor(objEProfe);

        }
    }
}