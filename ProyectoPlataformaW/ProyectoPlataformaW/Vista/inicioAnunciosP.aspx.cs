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
    public partial class inicioAnunciosP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<clAdminAnunciosE2> listP = new List<clAdminAnunciosE2>();
            //List<clAdminAnunciosE2> listP2 = new List<clAdminAnunciosE2>();

            clAnunciosL objCmL = new clAnunciosL();
           
            listP = objCmL.mtdListAnunAd();

            if (listP.Count != 0)
            {
                repeaterAnuncio.DataSource = listP;
                repeaterAnuncio.DataBind();


            }
            
        }
    }
}