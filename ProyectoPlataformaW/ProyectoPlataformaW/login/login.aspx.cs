using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;

namespace ProyectoPlataformaW.login
{
    public partial class login : System.Web.UI.Page
    {
        List<clEstudianteE> listaPro = new List<clEstudianteE>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngrear_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;
            string usuario = txtUsuario.Text;


            List<clEstudianteE> listaBus = new List<clEstudianteE>();


            clEstudianteE objEstudiante = new clEstudianteE();
            objEstudiante.Contraseña = contraseña;
            objEstudiante.Email = usuario;

            clEstudianteL objEstudianteL = new clEstudianteL();
            listaBus = objEstudianteL.mtdListarApb1(objEstudiante);


            // dataGridView1.DataSource = listaVt;
            if (listaBus.Count !=0)
            {
                Session["usuario"] = txtUsuario.Text;
                Session["general"] = "estudiante";
                // Response.Write("<script> alert(" + "'Datos correctos'" + ") </script>");
                Response.Redirect("~/Estudiante.aspx");
               

            }
            else { Response.Write("<script> alert(" + "'Datos Incorrectos'" + ") </script>");
                txtContraseña.Text = "";
                txtUsuario.Text = "";


            }







            //Session["usuario"] = txtUsuario.Text;
            //Response.Redirect("~/Estudiante.aspx");





        }
    }
}