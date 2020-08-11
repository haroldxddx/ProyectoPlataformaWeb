using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{
    public partial class asignarActividadesP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                lblCursoM.Text = Request.QueryString["idCm"].ToString();
            }*/
            

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            clEntidadActividadE objAct = new clEntidadActividadE();
            objAct.NombreActividad = txtNomAc.Text;
            objAct.Descripcion = txtDesc.Text;          
            objAct.Archivos = (string)(Session["Archivos"] = "~/Archivo/" + fluArchivo.FileName);
            objAct.FechaInicio = txtFechaIni.Text;
            objAct.FechaFinal = txtFechaFn.Text;
            objAct.IdCursoMateria = int.Parse(lblCursoM.Text);

            clActividadD objActividadD = new clActividadD();
            int result = objActividadD.mtdAsignarActividad(objAct);
            fluArchivo.SaveAs(Server.MapPath("~/Archivo/") + fluArchivo.FileName);

            if (result>0)
            {
                Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                
            }




        }
    }
}