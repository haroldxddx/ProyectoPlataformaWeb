using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using static ProyectoPlataformaW.Datos.clEncrypt;
using ProyectoPlataformaW.Datos;


namespace ProyectoPlataformaW.login
{
    public partial class login : System.Web.UI.Page
    {
        List<clEntidadEstudianteE> listaPro = new List<clEntidadEstudianteE>();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnIngrear_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;
            string usuario = txtUsuario.Text;

            //Desencriptar
            string pass = Encrypt.GetSHA256(contraseña);


            List<clEntidadEstudianteE> listaBus = new List<clEntidadEstudianteE>();
            List<clEntidadProfesorE> listaBusp = new List<clEntidadProfesorE>();
            List<clEntidadAdministradorE> listaBusa = new List<clEntidadAdministradorE>();

            

            clEntidadEstudianteE objEstudiante = new clEntidadEstudianteE();
            objEstudiante.Contrasena = pass;
            objEstudiante.Email = usuario;

            clEntidadProfesorE objProfesor = new clEntidadProfesorE();
            objProfesor.Contrasena = pass;
            objProfesor.Email = usuario;


         

            clEntidadAdministradorE objAdministrador = new clEntidadAdministradorE();
            objAdministrador.Contrasena = pass;
            objAdministrador.Email = usuario;



            clEstudianteL objEstudianteL = new clEstudianteL();
            listaBus = objEstudianteL.mtdListarApb1(objEstudiante);

            clProfesorL objProfesorL = new clProfesorL();
            listaBusp = objProfesorL.mtdListarApb1(objProfesor);

            clAdministradorL objAdministradorL = new clAdministradorL();
            listaBusa = objAdministradorL.mtdListarApb1(objAdministrador);

          
                   

                
                    if (listaBusp.Count != 0)
                    {
                        Session["usuario"] = txtUsuario.Text;
                        Session["general"] = "profesor";
                        // Response.Write("<script> alert(" + "'Datos correctos'" + ") </script>");
                        Response.Redirect("~/Vista/inicioProfesor.aspx");


                    }
                    else if(listaBusa.Count != 0)
                    {
                Session["usuario"] = txtUsuario.Text;
                Session["general"] = "administrador";
                // Response.Write("<script> alert(" + "'Datos correctos'" + ") </script>");
                Response.Redirect("~/Vista/inicioAdministrador.aspx");


            } else if (listaBus.Count != 0)
            {
                Session["usuario"] = txtUsuario.Text;
                Session["general"] = "estudiante";
                // Response.Write("<script> alert(" + "'Datos correctos'" + ") </script>");
                Response.Redirect("~/Vista/inicioEstudiante.aspx");

            }
            else {
                Response.Write("<script> alert(" + "'Datos Incorrectos'" + ") </script>");
                txtContraseña.Text = "";
                txtUsuario.Text = "";
            }


            try
            {

            }
            catch (Exception error)
            {
                clErrores.save(this, error);
                throw;
            }






        }
    }
}