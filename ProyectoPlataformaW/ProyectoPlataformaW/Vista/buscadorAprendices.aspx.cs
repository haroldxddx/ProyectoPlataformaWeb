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
    public partial class buscadorAprendices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<clEntidadCursosE> listC = new List<clEntidadCursosE>();
            clCursoL objCurso = new clCursoL();

            listC = objCurso.mtdComboCur();
            cmbCurso.DataSource = listC;
            cmbCurso.DataTextField = "Curso";
            cmbCurso.DataValueField = "IdCurso";
            cmbCurso.DataBind();


        }
    }
}