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
    public partial class inicioAnuncio : System.Web.UI.Page
    {
        public string o;
        public static string Ruta;
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





            List<clAdminAnunciosE2> listP = new List<clAdminAnunciosE2>();
            List<clAdminAnunciosE2> listP2= new List<clAdminAnunciosE2>();

            clAnunciosL objCmL = new clAnunciosL();
            //listP2 = objCmL.mtdListAnunPr();
            listP = objCmL.mtdListAnunAd();

            if (listP.Count != 0)
            {
                repeaterAnuncio.DataSource = listP;
                repeaterAnuncio.DataBind();

            }
           
      
        }

        protected void repeaterAnuncio_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            o = repeaterAnuncio.Items[e.Item.ItemIndex].ItemIndex.ToString();
            Ruta = ((Label)repeaterAnuncio.Items[int.Parse(o)].FindControl("lblArch")).Text;




            if (Ruta != null)
            {
                Response.Redirect(inicioAnuncio.Ruta);

            }
            else
            {
                Response.Write("<script> alert(" + "Sin Archivos " + ") </script>");
            }
        }


        protected void DescargarAct(object sender, EventArgs e)
        {

        }

        protected void repeaterAnuncio_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}