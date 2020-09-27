using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{
    public partial class buscadorEstudiantes : System.Web.UI.Page
    {
        List<clEntidadEstudianteE> listEestu = new List<clEntidadEstudianteE>();
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
        protected void Page_Init(object sender, EventArgs e)
        {

            //para editar esta pagina descomentarear esta linea by mao
            // Session["general"] = "administrador";


            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "administrador")
                {
                    List<ClEntidadCursosE> listC = new List<ClEntidadCursosE>();
                    List<clEstudianteEEE> listE = new List<clEstudianteEEE>();

                    clCursoL objCurso = new clCursoL();
                    clEstudianteL objEstud = new clEstudianteL();

                    listC = objCurso.mtdComboCur();
                    listE = objEstud.mtdListadoComEs();
                    cmbCurso.DataSource = listC;
                    cmbCurso.DataTextField = "Curso";
                    cmbCurso.DataValueField = "IdCurso";
                    cmbCurso.DataBind();

                    gvEstu.DataSource = listE;
                    gvEstu.DataBind();


                }
                else if (Session["general"].ToString() != "administrador")
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

        protected void txtNombreE_TextChanged(object sender, EventArgs e)
        {
            string nomAP = txtNombreE.Text;

            List<clEstudianteEEE> listaBuscar = new List<clEstudianteEEE>();

            clEstudianteEEE objEstudiante = new clEstudianteEEE();
            objEstudiante.Nombres = nomAP;

            clEstudianteL objEstudianteL = new clEstudianteL();
            listaBuscar = objEstudianteL.mtdBuscarEstu(objEstudiante);

            if (listaBuscar.Count != 0)
            {
                gvEstu.DataSource = listaBuscar;
                gvEstu.DataBind();

            }
        }

        protected void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string cur = cmbCurso.SelectedIndex.ToString();


            List<clEstudianteEEE> listaFilt = new List<clEstudianteEEE>();

            clEntidadEstudianteE objEstudiante = new clEntidadEstudianteE();
            objEstudiante.IdCurso = int.Parse(cmbCurso.SelectedValue);

            clEstudianteL objEstudianteL = new clEstudianteL();
            listaFilt = objEstudianteL.mtdFiltroE(objEstudiante);

            if (listaFilt.Count != 0)
            {
                gvEstu.DataSource = listaFilt;
                gvEstu.DataBind();

            }
        }
    }
}