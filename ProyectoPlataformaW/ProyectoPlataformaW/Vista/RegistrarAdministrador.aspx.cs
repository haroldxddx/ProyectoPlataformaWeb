using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW
{
    public partial class RegistrarAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            clEntidadAdministrador objEAdmin = new clEntidadAdministrador();
            objEAdmin.Nombres = txtNom.Text;
            objEAdmin.Apellidos = txtApe.Text;
            objEAdmin.Documento = int.Parse(txtDoc.Text);
            objEAdmin.Email = txtEma.Text;
            objEAdmin.Contrasena = txtCon.Text;
            objEAdmin.Tipo = dpdTipo.Text;

            clAdministradorR objAdmin = new clAdministradorR();
            int result = objAdmin.mtdRegistrarAdministrador(objEAdmin);

            txtNom.Text = "";
            txtApe.Text = "";
            txtDoc.Text = "";
            txtEma.Text = "";
            txtCon.Text = "";
           

        }
    }
}