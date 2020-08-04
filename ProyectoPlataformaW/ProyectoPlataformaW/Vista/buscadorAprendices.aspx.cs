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
    public partial class buscadorAprendices : System.Web.UI.Page
    {
        List<clEntidadEstudiante> listEestu = new List<clEntidadEstudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<clEntidadCursosE> listC = new List<clEntidadCursosE>();
            List<clEntidadEstudiante> listE = new List<clEntidadEstudiante>();

            clCursoL objCurso = new clCursoL();
            clEstudianteL objEstud = new clEstudianteL();

            listC = objCurso.mtdComboCur();
            listE = objEstud.mtdListadoComEs();
            cmbCurso.DataSource = listC;
            cmbCurso.DataTextField = "Curso";
            cmbCurso.DataValueField = "IdCurso";
            cmbCurso.DataBind();

            gvEstu.DataSource= listE;
            gvEstu.DataBind();


        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomAP = txtNombreE.Text;

            List<clEntidadEstudiante> listaBuscar = new List<clEntidadEstudiante>();

            clEntidadEstudiante objEstudiante = new clEntidadEstudiante();
            objEstudiante.Nombres = nomAP;
            
            clEstudianteL objEstudianteL = new clEstudianteL();
            listaBuscar = objEstudianteL.mtdBuscarEstu(objEstudiante);
            
            if (listaBuscar.Count !=0)
            {
                gvEstu.DataSource = listaBuscar;
                gvEstu.DataBind();

            }
        }

        protected void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*string cur = cmbCurso.SelectedIndex.ToString();


            List<clEntidadEstudiante> listaFilt = new List<clEntidadEstudiante>();

            clEntidadEstudiante objEstudiante = new clEntidadEstudiante();
            objEstudiante.Curso = cur;

            clEstudianteL objEstudianteL = new clEstudianteL();
            listaFilt = objEstudianteL.mtdFiltroE(objEstudiante);

            if (listaFilt.Count != 0)
            {
                gvEstu.DataSource = listaFilt;
                gvEstu.DataBind();

            }*/

           

            //string email = (objEstu.Email = txtCorreo.Text);
            string cu = cmbCurso.SelectedIndex.ToString();
            List<clEntidadEstudiante> listaEstuDos = new List<clEntidadEstudiante>();
            clEstudianteD objEstuD = new clEstudianteD();
            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdListadoComEs();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Curso == cu)
                {
                    clEntidadEstudiante objEstu = new clEntidadEstudiante();

                    objEstu.Nombres = listEestu[i].Nombres;
                    objEstu.Apellidos = listEestu[i].Apellidos;
                    objEstu.Documento = int.Parse(listEestu[i].Documento.ToString());
                    objEstu.Email = listEestu[i].Email;
                    objEstu.Grado = listEestu[i].Grado;
                    objEstu.Curso = listEestu[i].Curso;
                    
                    gvEstu.DataSource = listEestu;
                    gvEstu.DataBind();

                    listaEstuDos.Add(objEstu);
                    

                }
               
            }
        }
    }
}