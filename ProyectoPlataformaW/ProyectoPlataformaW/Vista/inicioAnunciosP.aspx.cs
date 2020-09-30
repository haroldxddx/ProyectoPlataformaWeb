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
    public partial class inicioAnunciosP : System.Web.UI.Page
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

                if (Session["general"].ToString() == "profesor")
                {
                    clRecuperarContra c = new clRecuperarContra();
                    c.enviarCorreoIsecion(user);
                }
                else if (Session["general"].ToString() != "profesor")
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
            //List<clAdminAnunciosE2> listP2 = new List<clAdminAnunciosE2>();

            clAnunciosL objCmL = new clAnunciosL();
            clProfesorL objProfL = new clProfesorL();

            clProfesorEEE objEp = new clProfesorEEE();
           /* objEp.Email = user;
            objProfL.mtdNomProfe(objEp);*/
           
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
                Response.Redirect(inicioAnunciosP.Ruta);

            }
            else
            {
                Response.Write("<script> alert(" + "Sin Archivos " + ") </script>");
            }
        }


        protected void DescargarAct(object sender, EventArgs e)
        {

        }
    }
}