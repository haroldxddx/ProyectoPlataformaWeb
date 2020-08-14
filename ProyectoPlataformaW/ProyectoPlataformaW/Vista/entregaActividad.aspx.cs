using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Datos;


namespace ProyectoPlataformaW.Vista
{
    public partial class entregaActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "estudiante")
                {

                    // Response.Redirect("~/inicio.aspx");

                }
                else if (Session["general"].ToString() != "estudiante")
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

          

            Actividades objAct = new Actividades();

            //Label var = Actividades.idA;
            //int X = Convert.ToInt32(var.Text);



            string user = Session["usuario"].ToString();

            

            List<clEntidadActividadE> listaActividad = new List<clEntidadActividadE>();

            clEntidadActividadE objEs = new clEntidadActividadE();
            objEs.IdActividad = int.Parse(Actividades.q);

          // Response.Write("<script> alert(" + Actividades.q + ") </script>");

            clActividadL objActividad = new clActividadL();
            listaActividad = objActividad.mtdActividad(objEs);

            if (listaActividad.Count != 0)
            {

                repeaterActividad.DataSource = listaActividad;
                repeaterActividad.DataBind();


            }

           



        }
    }
}