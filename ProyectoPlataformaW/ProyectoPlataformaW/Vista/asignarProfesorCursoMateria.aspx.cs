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
    public partial class asignarProfesorCursoMateria : System.Web.UI.Page
    {
        List<clEntidadProfesorE> listaProfesor = new List<clEntidadProfesorE>();
        protected void Page_Load(object sender, EventArgs e)
        {

            List<ClEntidadCursosE> listaCurso = new List<ClEntidadCursosE>();
            clCursoD objCurso = new clCursoD();
            listaCurso = objCurso.mtdListarCurso();

            dpdIdCurso.DataSource = listaCurso;
            dpdIdCurso.DataTextField = "Curso";
            dpdIdCurso.DataValueField = "IdCurso";
            dpdIdCurso.DataBind();


            List<clEntidadMateriaE> listaMateria = new List<clEntidadMateriaE>();
            clMateriaD objMat = new clMateriaD();
            listaMateria = objMat.mtdListarMateria();

            dpdIdMateria.DataSource = listaMateria;
            dpdIdMateria.DataTextField = "NombreMateria";
            dpdIdMateria.DataValueField = "IdMateria";
            dpdIdMateria.DataBind();


            
            clProfesorD objProfe = new clProfesorD();
            listaProfesor = objProfe.mtdListarProfe();

            dpdIdProfe.DataSource = listaProfesor;
            dpdIdProfe.DataTextField = "Nombres" ;
            dpdIdProfe.DataValueField = "IdProfesor";
            dpdIdProfe.DataBind();
           
            
            mtdCargarGrid();
        }
    
        private void mtdCargarGrid()
            {
            clProfesorL objPrf = new clProfesorL();
            listaProfesor = objPrf.mtdListProfe();

             gvProf.DataSource = listaProfesor;
             gvProf.DataBind();

            }
        


        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                clEntidadCursoMateriaE objECM = new clEntidadCursoMateriaE();
           
                objECM.IdCurso = int.Parse(dpdIdCurso.Text); 
                objECM.IdMateria = int.Parse(dpdIdMateria.Text);
                objECM.IdProfesor = int.Parse(dpdIdProfe.Text);
                

                clCursoMateriaD objCM = new clCursoMateriaD();
                int resultsql = objCM.mtdAsignarCursoMateria(objECM);

            }

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}