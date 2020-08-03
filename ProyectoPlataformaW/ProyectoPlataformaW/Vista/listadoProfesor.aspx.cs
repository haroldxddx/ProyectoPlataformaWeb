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
    public partial class listadoProfesor : System.Web.UI.Page
    {
        List<clEntidadProfesorE> listaProf = new List<clEntidadProfesorE>();
        private void mtdCargarGrid()
        {
            clProfesorL objPrf = new clProfesorL();
            listaProf = objPrf.mtdListProf();

            gvProf.DataSource = listaProf;
            gvProf.DataBind();
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdCargarGrid();
        }

        
    }
}