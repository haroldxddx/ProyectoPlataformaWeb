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
    public partial class listadoProfesor : System.Web.UI.Page
    {
        List<clEntidadProfesorE> listaProf = new List<clEntidadProfesorE>();
        private void mtdCargarGrid()
        {
            clProfesorL objPrf = new clProfesorL();
            listaProf = objPrf.mtdListProf();

            gvProf.DataSource = listaProf;
            gvProf.DataBind();
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {



            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "administrador")
                {
                    mtdCargarGrid();
                    // Response.Redirect("~/inicio.aspx");

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
        





    }
}