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
            List<clEntidadEstudianteEE> list = new List<clEntidadEstudianteEE>();
            clEstudianteD objEst = new clEstudianteD();
            list = objEst.mtdListadoCompletoEE();

            gvlistEstudiante.DataSource = list;

            gvlistEstudiante.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;


            List<clEntidadEstudianteEE> listaBuscar = new List<clEntidadEstudianteEE>();

            clEntidadEstudianteEE objEst = new clEntidadEstudianteEE();
            objEst.Nombres = nombre;

            clEstudianteL objEstudianteL = new clEstudianteL();
            listaBuscar = objEstudianteL.mtdBuscarEst(objEst);

            if (listaBuscar.Count != 0)
            {
                gvlistEstudiante.DataSource = listaBuscar;
                gvlistEstudiante.DataBind();

            }
        }

      
        }
    }
