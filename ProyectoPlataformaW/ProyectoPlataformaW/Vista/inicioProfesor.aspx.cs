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

    public partial class inicioProfesor : System.Web.UI.Page

    {
        
        List<clEntidadCursoMateriaE> listP = new List<clEntidadCursoMateriaE>();


        protected void Page_Load(object sender, EventArgs e)
        {

            clCursoMateriaL objCmL = new clCursoMateriaL();
            listP = objCmL.mtdCursosP();
            string user = Session["usuario"].ToString();

            for (int i = 0; i < listP.Count; i++)
            {
                if (listP[i].Email == user)
                {
                    
                    repeaterPrueba.DataSource = listP;
                    repeaterPrueba.DataBind();
                }

            }


        }
    }
}