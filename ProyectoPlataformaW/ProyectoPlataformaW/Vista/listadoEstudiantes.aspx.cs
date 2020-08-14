using ProyectoPlataformaW.Datos;
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
    public partial class listadoEstudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdCargarGrid();
        }


        private void mtdCargarGrid()
        {
            List<clEntidadEstudianteE> list = new List<clEntidadEstudianteE>();
            clEstudianteD objEst = new clEstudianteD();
            list = objEst.mtdListadoCompletoE();

            gvlistEstudiante.DataSource = list;

            gvlistEstudiante.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            List<clEntidadEstudianteE> listaBuscar = new List<clEntidadEstudianteE>();

            clEntidadEstudianteE objEst = new clEntidadEstudianteE();
            objEst.Nombres = nombre;

            clEstudianteL objEstudianteL = new clEstudianteL();
            listaBuscar = objEstudianteL.mtdBuscarEstu(objEst);

            if (listaBuscar.Count != 0)
            {
                gvlistEstudiante.DataSource = listaBuscar;
                gvlistEstudiante.DataBind();

            }
        }
    }
}