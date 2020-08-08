using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW
{
    public partial class MasterPageAdmin : System.Web.UI.MasterPage
    {

      
        protected void Page_Load(object sender, EventArgs e)


        {

            lblAdmin.Text = Session["usuario"].ToString();
            if (Session["usuario"] == null)
            {
                //PARA LOGIN 
                // Response.Redirect("~/inicio.aspx");
            }
            else
            {

              
            }
        }
        protected void lblcerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/inicio.aspx");
        }

    }
}