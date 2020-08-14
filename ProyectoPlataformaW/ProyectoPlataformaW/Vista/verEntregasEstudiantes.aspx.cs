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
    public partial class verEntregasEstudiantes : System.Web.UI.Page
    {
        List<clEntidadActividadEstuE> listActAsig = new List<clEntidadActividadEstuE>();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            string user = Session["usuario"].ToString();


            List<clEntidadActividadE> listAct = new List<clEntidadActividadE>();
            clActividadL objCurso = new clActividadL();
            clEntidadActividadE objAcE = new clEntidadActividadE();
            objAcE.Email = user;
            objAcE.IdCursoMateria = int.Parse(lblIdCursoM.Text);


            listAct = objCurso.mtdComboAct(objAcE);

            ddlAct.DataSource = listAct;
            ddlAct.DataTextField = "NombreActividad";
            ddlAct.DataValueField = "IdActividad";
            ddlAct.DataBind();
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            clEntidadActividadEstuE objEA = new clEntidadActividadEstuE();
            objEA.IdCursoMateria = int.Parse(lblIdCursoM.Text);
            objEA.IdActividad = int.Parse(ddlAct.SelectedValue.ToString());

            clCursoMateriaL objcurL = new clCursoMateriaL();
            listActAsig = objcurL.mtdListEstudiantesActivi(objEA);

            if (listActAsig.Count != 0)
            {
                repeaterEstud.DataSource = listActAsig;
                repeaterEstud.DataBind();

            }


        }

        protected void repeaterEstud_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void btnVerEntrega_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Vista/calificarActividad.aspx");


        }
    }
}