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
    public partial class listadoMateriasAsignadoaACurso : System.Web.UI.Page


    {
        protected void Page_Load(object sender, EventArgs e)
        {
           mtdCargarGrid();
        }

        protected void btnBuscarC_Click(object sender, EventArgs e)
        {
                string Curso= txtBuscarC.Text;


             List<clEntidadProfesorCursoMateriaE> listaBuscar = new List<clEntidadProfesorCursoMateriaE>();

              clEntidadProfesorCursoMateriaE objCm = new clEntidadProfesorCursoMateriaE();
                objCm.Curso = Curso;

                clCursoMateriaL objCuMa = new clCursoMateriaL();
                listaBuscar = objCuMa.mtdBuscarMC(objCm);

                if (listaBuscar.Count != 0)
                {
                GridView1.DataSource = listaBuscar;
                GridView1.DataBind();

                }
            }
        
        
        private void mtdCargarGrid()
        {
        List<clEntidadProfesorCursoMateriaE> listaMCP = new List<clEntidadProfesorCursoMateriaE>();
        clCursoMateriaL objCMP = new clCursoMateriaL();
            listaMCP = objCMP.mtdListarMC();
            GridView1.DataSource = listaMCP;
            GridView1.DataBind();

        }
    }
}
