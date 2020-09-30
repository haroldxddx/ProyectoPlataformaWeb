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
    public partial class forosTotalesAct : System.Web.UI.Page
    {
        List<clEntidadForoE> listActAsig = new List<clEntidadForoE>();
        public static int id;
        public string o;
        public static int idAct;
       
        protected void Page_Init(object sender, EventArgs e)
        {
            string user = Session["usuario"].ToString();

            inicioProfesor objPR = new inicioProfesor();

            //int vari = inicioProfesor.id;
            //lblIdCursoM.Text = Convert.ToString(vari);
            List<clEntidadActividadE> listAct = new List<clEntidadActividadE>();
            clActividadL objCurso = new clActividadL();
            clEntidadActividadE objAcE = new clEntidadActividadE();
            
            objAcE.IdCursoMateria = inicioProfesor.id;


            listAct = objCurso.mtdComboact2(objAcE);

            ddlAct.DataSource = listAct;
            ddlAct.DataTextField = "NombreActividad";
            ddlAct.DataValueField = "IdActividad";
            ddlAct.DataBind();

        }

        protected void btnVerEntrega_Click(object sender, EventArgs e)
        {

        }

        protected void ddlAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            inicioProfesor objPR = new inicioProfesor();
            clEntidadForoE objEA = new clEntidadForoE();
           
            objEA.IdActividad = int.Parse(ddlAct.SelectedValue.ToString());


            clForoL objcurL = new clForoL();
            listActAsig = objcurL.mtdForosD(objEA);

            if (listActAsig.Count != 0)
            {
                repeaterEstud.DataSource = listActAsig;
                repeaterEstud.DataBind();

            }
        }

        protected void repeaterEstud_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            o = repeaterEstud.Items[e.Item.ItemIndex].ItemIndex.ToString();
            id = int.Parse(((Label)repeaterEstud.Items[int.Parse(o)].FindControl("lblIdForo")).Text);
            Response.Redirect("/Vista/foroActividad.aspx");
        }
    }
}