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
    public partial class registrarAdministrador2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            clEntidadAdministradorE objEAdmin = new clEntidadAdministradorE();
            objEAdmin.Nombres = txtNom.Text;
            objEAdmin.Apellidos = txtApe.Text;
            objEAdmin.Documento = int.Parse(txtDoc.Text);
            objEAdmin.Email = txtEma.Text;
            objEAdmin.Contrasena = Encrypt.GetSHA256(txtCon.Text);
            objEAdmin.Tipo = dpdTipo.Text;

            clAdministradorD objAdmin = new clAdministradorD();
            int result = objAdmin.mtdRegistrarAdministrador(objEAdmin);

            if (result>0)
            {
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/inicioAnuncio.aspx'", true);
                //Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                txtNom.Text = "";
                txtApe.Text = "";
                txtDoc.Text = "";
                txtEma.Text = "";
                txtCon.Text = "";
            }

           
        }
    }
}