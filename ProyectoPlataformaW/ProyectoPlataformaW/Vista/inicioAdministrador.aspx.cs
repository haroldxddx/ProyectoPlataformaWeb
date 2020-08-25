﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Datos;

namespace ProyectoPlataformaW
{
    public partial class inicioAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbluser.Text = Session["usuario"].ToString();

            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "administrador")
                {

                    // Response.Redirect("~/inicio.aspx");

                }
                else if (Session["general"].ToString() != "administrador")
                {

                    Response.Redirect("~/inicio.aspx");
                }
            }
            catch (Exception)
            {

                Response.Write("<script> alert(" + "'sitio deshabilitado favor redirijase a nuestra pagina'" + ") </script>");

                Session.Clear();
                Response.Redirect("~/inicio.aspx");

            }



            clRecuperarContra c = new clRecuperarContra();
            c.enviarCorreoIsecion(lbluser.Text);


        }
    }
}