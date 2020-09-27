using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{
    public partial class registrarCurso2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["usuario"].ToString();

            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "administrador")
                {
                    clRecuperarContra c = new clRecuperarContra();
                    c.enviarCorreoIsecion(user);
                }
                else if (Session["general"].ToString() != "administrador")
                {

                    Response.Redirect("~/inicio.aspx");
                }
            }
            catch (Exception error)
            {

                Response.Write("<script> alert(" + "'sitio deshabilitado favor redirijase a nuestra pagina'" + ") </script>");
                clErrores.save(this, error);
                Session.Clear();
                Response.Redirect("~/inicio.aspx");

            }

        }

        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            ClEntidadCursosE objECurso = new ClEntidadCursosE();
            objECurso.Curso = txtCur.Text;
            objECurso.Grado = dplGrado.SelectedValue;

            clCursoD objCurso = new clCursoD();
            int result = objCurso.mtdRegistrarCurso(objECurso);

            if (result>0)
            {
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/inicioAnuncio.aspx'", true);
                //Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                txtCur.Text = "";
            }
        }
    }
}