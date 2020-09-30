using ProyectoPlataformaW.Datos;
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
    public partial class registrarAnuncios : System.Web.UI.Page
    {
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



            lblFecha.Text = DateTime.Now.ToShortDateString();
            
           // string user = Session["usuario"].ToString();
            clEntidadAdministradorE objAdminE = new clEntidadAdministradorE();
            objAdminE.Email = user;

            clAdministradorL objAdminL = new clAdministradorL();
            objAdminL.mtdDatosEstu(objAdminE);

        }

        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            clAdministradorD objA = new clAdministradorD();
            int id = clAdministradorD.IdAdmin;

            clEntidadAnunciosE objAnunE = new clEntidadAnunciosE();
            objAnunE.Titulo = txtTitulo.Text;
            objAnunE.Fecha = lblFecha.Text;
            objAnunE.Descripcion = txtDesc.Text;
            objAnunE.Archivos = (string)(Session["Archivos"] = "~/Anuncios/" + fluArchivo.FileName); 
            objAnunE.IdAdministrador = id;
            

            clAnunciosL objAnunL = new clAnunciosL();
            int result = objAnunL.mtdEnvioDatos(objAnunE);

            if (result > 0)
            {
                fluArchivo.SaveAs(Server.MapPath("~/Anuncios/") + fluArchivo.FileName);
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/inicioAnuncio.aspx'", true);
               // Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                txtTitulo.Text = "";
                txtDesc.Text = "";
                
            }
        }

        protected void btnInforme_Click(object sender, EventArgs e)
        {
            clAdministradorD objA = new clAdministradorD();
            int id = clAdministradorD.IdAdmin;

            clEntidadAnunciosE objAnunE = new clEntidadAnunciosE();
            objAnunE.Fecha = lblFecha.Text;
            objAnunE.IdAdministrador = id;

            clAnunciosL objAnunL = new clAnunciosL();
            int result1 = objAnunL.mtdGeneInfo(objAnunE);

            if (result1 > 0)
            {
                //fluArchivo.SaveAs(Server.MapPath("~/Anuncios/") + fluArchivo.FileName);
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/inicioAnuncio.aspx'", true);
                // Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
             

            }
        }
    }
}