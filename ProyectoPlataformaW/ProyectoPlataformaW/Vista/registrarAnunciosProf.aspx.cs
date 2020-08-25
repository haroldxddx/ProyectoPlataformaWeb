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
    public partial class registrarAnunciosProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["usuario"].ToString();
            clEntidadProfesorE objproE = new clEntidadProfesorE();
            objproE.Email = user;

            clProfesorL objAdminL = new clProfesorL();
            objAdminL.mtdDatosEstu(objproE);
        }

        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            clProfesorD objA = new clProfesorD();
            int id = clProfesorD.IdProfesor;

            clEntidadAnunciosE objAnunE = new clEntidadAnunciosE();
            objAnunE.Titulo = txtTitulo.Text;
            objAnunE.Descripcion = txtDesc.Text;
            objAnunE.Archivos = (string)(Session["Archivos"] = "~/Anuncios/" + fluArchivo.FileName);
            objAnunE.IdProfesor = id;


            clAnunciosL objAnunL = new clAnunciosL();
            int result = objAnunL.mtdEnvioDatos2(objAnunE);

            if (result > 0)
            {
                fluArchivo.SaveAs(Server.MapPath("~/Anuncios/") + fluArchivo.FileName);
                Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                txtTitulo.Text = "";
                txtDesc.Text = "";

            }
        }
    }
}