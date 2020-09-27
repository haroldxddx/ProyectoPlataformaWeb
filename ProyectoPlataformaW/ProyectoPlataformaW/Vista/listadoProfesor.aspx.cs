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
        List<clProfesorEEE> listaProf = new List<clProfesorEEE>();
        private void mtdCargarGrid()
        {
            clProfesorL objPrf = new clProfesorL();
            listaProf = objPrf.mtdListProf();

            gvProf.DataSource = listaProf;
            gvProf.DataBind();
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsera.Text = Session["usuario"].ToString();

            mtdCargarGrid();

            /*try
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

                Response.Write("<script> alert(" + "'modo edicion'" +") </script>");

                //si necesita editar la pagina de estudiante no descomentarear la siguiente linea :v by mao
                //Session.Clear();
                //redirigir a login //Response.Redirect("~/inicio.aspx");



            }*/


            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;


            List<clProfesorEEE> listaBuscar = new List<clProfesorEEE>();

            clProfesorEEE objProf = new clProfesorEEE();
            objProf.Nombres = nombre;

            clProfesorL objProfL = new clProfesorL();
            listaBuscar = objProfL.mtdBuscarProf(objProf);

            if (listaBuscar.Count != 0)
            {
                gvProf.DataSource = listaBuscar;
                gvProf.DataBind();

            }
        }

        protected void gvProf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
