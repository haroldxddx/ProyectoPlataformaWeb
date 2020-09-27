using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Datos;
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




            lblUsera.Text = Session["usuario"].ToString();

            mtdCargarGrid();

            
            
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
