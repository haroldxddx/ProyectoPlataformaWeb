using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;

namespace ProyectoPlataformaW.login
{
    public partial class recuperarContra : System.Web.UI.Page
    {

        List<clEntidadEstudianteE> listEestu = new List<clEntidadEstudianteE>();
        clRecuperarContra c = new clRecuperarContra();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdRecup();

            //string email = (objEstu.Email = txtCorreo.Text);
            string email = txtEmail.Text;
            List<clEntidadEstudianteE> listaEstuDos = new List<clEntidadEstudianteE>();
            //clEstudianteD objEstuD = new clEstudianteD();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == email)
                {
                    clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

                    objEstu.Email = listEestu[i].Email;

                    string contra = objEstu.Contrasena = listEestu[i].Contrasena;

                    string pass = Encrypt.GetSHA256(contra);



                    listaEstuDos.Add(objEstu);
                    c.enviarCorreo(email, pass);

                    Response.Redirect("~/login/login.aspx");
                    Response.Write("<script language=javascript>alert('Revise la bandeja de entrada de su correo electronico en breve recibira un correo con su contraseña');</script>");
                    //ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/login/login.aspx'", true);
                    txtEmail.Text = "";

                }
                else
                {
                    // lblError.Text = "error ";
                    Response.Write("<script language=javascript>alert('El correo ingresado no existe');</script>");
                    txtEmail.Text = "";

                }
            }
        }
    }
}