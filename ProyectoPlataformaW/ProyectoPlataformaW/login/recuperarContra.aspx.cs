using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using static ProyectoPlataformaW.Datos.clEncrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            string email = txtEmail.Text;
            string conGen = clEncrypt.GenerarPassword(5);
            int documento = int.Parse(txtDocumento.Text);


            clEntidadEstudianteE objEstu0 = new clEntidadEstudianteE();
            objEstu0.Contrasena = Encrypt.GetSHA256(conGen);
            objEstu0.Documento = documento;
            objEstu0.Email = email;

            clEstudianteD objEstu1 = new clEstudianteD();
            int result = objEstu1.mtdEditarContra(objEstu0);



            clEntidadAdministradorE objAdmin0 = new clEntidadAdministradorE();
            objAdmin0.Contrasena = Encrypt.GetSHA256(conGen);
            objAdmin0.Documento = documento;
            objAdmin0.Email = email;

            clEstudianteD objAdmin1 = new clEstudianteD();
            int result1 = objAdmin1.mtdEditarContraA(objAdmin0);


            clEntidadProfesorE objPro0 = new clEntidadProfesorE();
            objPro0.Contrasena = Encrypt.GetSHA256(conGen);
            objPro0.Documento = documento;
            objPro0.Email = email;

            clEstudianteD obJPro1 = new clEstudianteD();
            int result2 = obJPro1.mtdEditarContraP(objPro0);

            if (result  != 0)
            {

                c.enviarCorreo(email, conGen);

               
                Response.Write("<script language=javascript>alert('Revise la bandeja de entrada de su correo electronico en breve recibira un correo con su contraseña');</script>");
                txtEmail.Text = "";
                txtDocumento.Text = "";
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/login/login.aspx'", true);
                

            }else if(result1!=0){

                Response.Write("<script language=javascript>alert('Revise la bandeja de entrada de su correo electronico en breve recibira un correo con su contraseña');</script>");
                txtEmail.Text = "";
                txtDocumento.Text = "";
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/login/login.aspx'", true);


            }
            else if(result2!=0){

                Response.Write("<script language=javascript>alert('Revise la bandeja de entrada de su correo electronico en breve recibira un correo con su contraseña');</script>");
                txtEmail.Text = "";
                txtDocumento.Text = "";
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/login/login.aspx'", true);


            }

            else
            {
                Response.Write("<script language=javascript>alert('Datos incorrectos');</script>");
            }


        }
    }
}