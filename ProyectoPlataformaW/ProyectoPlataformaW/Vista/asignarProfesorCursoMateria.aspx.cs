using DocumentFormat.OpenXml.Spreadsheet;
using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{
    public partial class asignarProfesorCursoMateria : System.Web.UI.Page
    {
        List<clEntidadProfesorEE> listaProfesor = new List<clEntidadProfesorEE>();
        List<clEntidadCursoEE> listaCurso = new List<clEntidadCursoEE>();
        List<clEntidadMateriaE> listaMateria = new List<clEntidadMateriaE>();

        clEntidadCursoMateriaE objECM = new clEntidadCursoMateriaE();
        clCursoMateriaD objCM = new clCursoMateriaD();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mtdCargarGridC();

                mtdCargarGrid();

                mtdCargarGridM();



            }

        }
        private void mtdCargarGridC()
        {
            clCursoD objCurso = new clCursoD();
            listaCurso = objCurso.mtdListarCursos();

            gvCurso.DataSource = listaCurso;

            gvCurso.DataBind();


        }
        private void mtdCargarGrid()
        {
            clProfesorD objPrf = new clProfesorD();
            listaProfesor = objPrf.mtdListarProfe();

            gvProfe.DataSource = listaProfesor;

            gvProfe.DataBind();


        }
        private void mtdCargarGridM()
        {
            clMateriaD objMat = new clMateriaD();
            listaMateria = objMat.mtdListarMateria();

            gvMateria.DataSource = listaMateria;

            gvMateria.DataBind();


        }




        protected void lnkGuardar_Click(object sender, EventArgs e)
        {
            CheckBox chbIdC;
            CheckBox chbIdM;
            CheckBox chbIdP;
            string idC = string.Empty;
            string idP = string.Empty;
            string idM = string.Empty;

            foreach (GridViewRow grvRowC in gvCurso.Rows)
            {
                chbIdC = (CheckBox)grvRowC.FindControl("chbItemC");
                if (chbIdC.Checked)
                {

                    idC = grvRowC.Cells[1].Text;


                    objECM.IdCurso = int.Parse(idC.ToString());

                }
            }
            foreach (GridViewRow grvRowP in gvProfe.Rows)
            {
                chbIdP = (CheckBox)grvRowP.FindControl("chbItem");
                if (chbIdP.Checked)
                {

                    idP = grvRowP.Cells[1].Text;


                    objECM.IdProfesor = int.Parse(idP.ToString());
                }
            }
            foreach (GridViewRow grvRowM in gvMateria.Rows)
            {
                chbIdM = (CheckBox)grvRowM.FindControl("chbItemM");
                if (chbIdM.Checked)
                {

                    idM = grvRowM.Cells[1].Text;


                    objECM.IdMateria = int.Parse(idM.ToString());


                }
            }
        
                    //    objECM.IdCurso = int.Parse(idC.ToString());
                     //   objECM.IdProfesor = int.Parse(idP.ToString());
                       // objECM.IdMateria = int.Parse(idM.ToString());
            int resultsql = objCM.mtdAsignarCursoMateria(objECM);
            lblMensajeC.Text = idC;
            lblMensaje.Text = idP;
            lblMensajeM.Text = idM;
        }

                        }
               

                    }
         













