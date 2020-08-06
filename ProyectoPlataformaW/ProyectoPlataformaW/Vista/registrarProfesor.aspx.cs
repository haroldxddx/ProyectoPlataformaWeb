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

            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "profesor")
                {

                    

                }
                else if (Session["general"].ToString() != "profesor")
                {

                    Response.Redirect("~/inicio.aspx");
                }
            }
            catch (Exception)
            {

                Response.Write("<script> alert(" + "'sitio deshabilitado favor redirijase a nuestra pagina'" + ") </script>");

                //si necesita editar la pagina de estudiante no descomentarear la siguiente linea :v by mao
                //redirigir a login //

                Session.Clear();
                Response.Redirect("~/inicio.aspx");

            }




        }



        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            clEntidadProfesorE objEProfe = new clEntidadProfesorE();
            objEProfe.Nombres = txtNom.Text;
            objEProfe.Apellidos = txtApe.Text;
            objEProfe.Documento = int.Parse(txtDoc.Text);
            objEProfe.Email = txtEma.Text;
            objEProfe.Contrasena = Encrypt.GetSHA256(txtCon.Text);
            objEProfe.Especialidad = txtEsp.Text;

            clProfesorD objProfe = new clProfesorD();
            int result = objProfe.mtdRegistrarProfesor(objEProfe);

        }
    }
}