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
        public static int id;
        public string o;
        public static int idAct;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            string user = Session["usuario"].ToString();

            inicioProfesor objPR = new inicioProfesor();
            //int vari = inicioProfesor.id;
            //lblIdCursoM.Text = Convert.ToString(vari);
            List<clEntidadActividadE> listAct = new List<clEntidadActividadE>();
            clActividadL objCurso = new clActividadL();
            clEntidadActividadE objAcE = new clEntidadActividadE();
            objAcE.Email = user;
            objAcE.IdCursoMateria = inicioProfesor.id;


            listAct = objCurso.mtdComboAct(objAcE);

            ddlAct.DataSource = listAct;
            ddlAct.DataTextField = "NombreActividad";
            ddlAct.DataValueField = "IdActividad";
            ddlAct.DataBind();
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            inicioProfesor objPR = new inicioProfesor();
            clEntidadActividadEstuE objEA = new clEntidadActividadEstuE();
            objEA.IdCursoMateria = inicioProfesor.id;
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
            o = repeaterEstud.Items[e.Item.ItemIndex].ItemIndex.ToString();
            id = int.Parse(((Label)repeaterEstud.Items[int.Parse(o)].FindControl("lblIdEstu")).Text);
            idAct = int.Parse(ddlAct.SelectedValue.ToString());
            Response.Redirect("/Vista/calificarActividad.aspx");
        }

        protected void btnVerEntrega_Click(object sender, EventArgs e)
        {
            


        }
    }
}