using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Datos;
using static ProyectoPlataformaW.Datos.clEncrypt;

namespace ProyectoPlataformaW.Vista
{
    public partial class adminregistro : System.Web.UI.Page
    {
        List<clEntidadAdministradorE> listaPro = new List<clEntidadAdministradorE>();
       // clEncrypt Encrypt = new clEncrypt();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            clEntidadAdministradorE objAdministradorE = new clEntidadAdministradorE();
            objAdministradorE.Nombres = txtnombre.Text;
            objAdministradorE.Apellidos = txtapellido.Text;
            objAdministradorE.Documento = int.Parse(txtdocumento.Text);
            objAdministradorE.Email = txtemail.Text;
            objAdministradorE.Contrasena = Encrypt.GetSHA256(txtcontrasena.Text);
            objAdministradorE.Tipo = txttipo.Text;

           

            clAdministradorL objAdministradorL = new clAdministradorL();
            int reslut = objAdministradorL.mtdEnvioDatos(objAdministradorE);
            if (reslut > 0)
            {
                Response.Write("<script> alert(" + "'Datos guardados '" + ") </script>");
                txtnombre.Text = "";
                txtapellido.Text = "";
                txtdocumento.Text = "";
                txtemail.Text = "";
                txtcontrasena.Text = "";
                txttipo.Text = "";
            }



        }
    }
}