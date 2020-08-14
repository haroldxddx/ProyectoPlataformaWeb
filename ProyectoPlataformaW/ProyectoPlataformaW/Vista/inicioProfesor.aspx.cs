using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{

    public partial class inicioProfesor : System.Web.UI.Page

    {
        public static int idCursoM;

        protected void lbtCurso_Click(object sender, EventArgs e)
        {

            foreach (RepeaterItem item in repeaterPrueba.Items)
            {
                Label lblda = (Label)item.FindControl("lblIdCursoMateria");
                int idcur = int.Parse(lblda.Text);
                Response.Redirect("/Vista/asignarActividadesP.aspx?id=" + idcur);

            }
            // Label lblprueba = ((Label)repeaterPrueba.Items[1].FindControl("lblIdCursoMateria"));
            //string xd = lblprueba.Text;
            // clCursoMateriaD objCm = new clCursoMateriaD();
            //int var2 = clCursoMateriaD.idCursoMat;
            //idCursoM = var2;
            //Response.Redirect("/Vista/asignarActividadesP.aspx");

            //  Response.Redirect("/Vista/asignarActividadesP.aspx?id="+ id);

           



        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<clEntidadCursoMateriaE> listP = new List<clEntidadCursoMateriaE>();
            string user = Session["usuario"].ToString();

            clEntidadCursoMateriaE objpro = new clEntidadCursoMateriaE();
            objpro.Email = user;

            clCursoMateriaL objCmL = new clCursoMateriaL();
            listP = objCmL.mtdCursosP(objpro);

            if (listP.Count != 0)
            {
                repeaterPrueba.DataSource = listP;
                repeaterPrueba.DataBind();

                clCursoMateriaD objCm = new clCursoMateriaD();
                int var2 = clCursoMateriaD.idCursoMat;
                idCursoM = var2;

            }
            /*for (int i = 0; i < listP.Count; i++)
            {
                if (listP[i].Email == user)
                {
                    
                    repeaterPrueba.DataSource = listP;
                    repeaterPrueba.DataBind();
                     clCursoMateriaD objCm = new clCursoMateriaD();
                    int var2 = clCursoMateriaD.idCursoMat;
                    idCursoM = var2;

                }

            }*/


        }


      

        protected void repeaterPrueba_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label lb = (Label)e.Item.FindControl("IdCursoMateria");

        }
    }
}