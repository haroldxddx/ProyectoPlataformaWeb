using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace ProyectoPlataformaW
{
    public partial class inicioEstu : System.Web.UI.Page
    {
        public static int id;

        public string o;

        protected void Page_Load(object sender, EventArgs e)
        {


            // Session["general"] = "estudiante";

            /*try
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

            }*/

         



            string user = Session["usuario"].ToString();

            List<clEntidadCursoMateriaE> listaCm = new List<clEntidadCursoMateriaE>();

            clEntidadEstudianteE objEs = new clEntidadEstudianteE();
            objEs.Email = user;

            clCursoMateriaL objCursoM = new clCursoMateriaL();
            listaCm = objCursoM.mtdMateriasP(objEs);

            if (listaCm.Count != 0)
            {
                repeaterMateria.DataSource = listaCm;
                repeaterMateria.DataBind();

                

            }


        }
      
      protected void repeaterMateria_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
          
            o = repeaterMateria.Items[e.Item.ItemIndex].ItemIndex.ToString();

           id = int.Parse(((Label)repeaterMateria.Items[int.Parse(o)].FindControl("lblidMateria")).Text);
      

            Response.Write("<script> alert(" + id + ") </script>");

            Response.Redirect("~/Vista/actividades.aspx");

         

        }

        protected void btnEntregaA_Click(object sender, EventArgs e)
        {

        }
    }
}