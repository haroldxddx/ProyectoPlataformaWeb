using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW
{
    public partial class MasterPageEstud : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["usuario"]==null)
            {
                //PARA LOGIN 
               // Response.Redirect("~/inicio.aspx");
            }
            else
            {   
                lblUser.Text = Session["usuario"].ToString();
            }

        }
        protected void lblcerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/inicio.aspx");
        }
       
    }
}