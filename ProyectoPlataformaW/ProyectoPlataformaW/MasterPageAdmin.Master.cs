﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW
{
    public partial class MasterPageAdmin : System.Web.UI.MasterPage
    {

        public string val;
        protected void Page_Load(object sender, EventArgs e)
        {

            //val = Session["usuario"].ToString();
        }
        protected void lblcerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/inicio.aspx");
        }

    }
}