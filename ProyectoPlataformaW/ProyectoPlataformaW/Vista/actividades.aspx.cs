using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Datos;


namespace ProyectoPlataformaW.Vista
{
    public partial class Actividades : System.Web.UI.Page
    {
        public static int idAct;
        protected void Page_Load(object sender, EventArgs e)

        {

            clCursoMateriaD objcmd = new clCursoMateriaD();
            int var = clCursoMateriaD.datoDT;

            





            string user = Session["usuario"].ToString();

            List<clEntidadActividadE> listaActividad = new List<clEntidadActividadE>();

            clEntidadActividadE objEs = new clEntidadActividadE();
            objEs.IdMateria =  var;

            clActividadL objActividad = new clActividadL();
            listaActividad = objActividad.mtdActividades(objEs);

            if (listaActividad.Count != 0)
            {
                repeaterActividad.DataSource = listaActividad;
                repeaterActividad.DataBind();

                clActividadD objact = new clActividadD();
                int var2 = clActividadD.idActividad;
                idAct = var2;

            }
       

        
        }

        protected void repeaterActividad_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

       
        }
       
        protected void btnRealizar_Click(object sender, EventArgs e)
        {

            clActividadD objact = new clActividadD();
           int var2 = clActividadD.idActividad;
            idAct = var2;
            Response.Redirect("~/entregaActividad.aspx");

        }
    }
}