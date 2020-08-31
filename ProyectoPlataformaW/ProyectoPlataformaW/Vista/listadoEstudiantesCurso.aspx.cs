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
    public partial class listadoEstudiantesCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<clEntidadEstudianteEE> listaBuscar = new List<clEntidadEstudianteEE>();

            inicioProfesor prof = new inicioProfesor();

            ClEntidadCursosE objCur = new ClEntidadCursosE();
            objCur.Curso = inicioProfesor.cur;

            clEstudianteL objEstL = new clEstudianteL();
            listaBuscar = objEstL.mtdDatosEstuProf(objCur);

            if (listaBuscar.Count != 0)
            {
                gvlistEstudiante.DataSource = listaBuscar;
                gvlistEstudiante.DataBind();

            }



        }
    }
}