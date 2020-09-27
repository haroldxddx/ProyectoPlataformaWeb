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
        List<clEntidadProfesorEE> listaP = new List<clEntidadProfesorEE>();
        List<clEntidadCursoEE> listaC = new List<clEntidadCursoEE>();
        List<clEntidadMateriaE> listaM = new List<clEntidadMateriaE>();



        clEntidadCursoMateriaE objECM = new clEntidadCursoMateriaE();
        clCursoMateriaD objCM = new clCursoMateriaD();

        protected void Page_Load(object sender, EventArgs e) 
        {
            string user = Session["usuario"].ToString();

            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "administrador")
                {
                    clRecuperarContra c = new clRecuperarContra();
                    c.enviarCorreoIsecion(user);
                }
                else if (Session["general"].ToString() != "administrador")
                {

                    Response.Redirect("~/inicio.aspx");
                }
            }
            catch (Exception error)
            {

                Response.Write("<script> alert(" + "'sitio deshabilitado favor redirijase a nuestra pagina'" + ") </script>");
                clErrores.save(this, error);
                Session.Clear();
                Response.Redirect("~/inicio.aspx");

            }






            if (!Page.IsPostBack) //CargarGrids
            {
                mtdCargarGridC();

                mtdCargarGrid();

                mtdCargarGridM();



            }

        }
        private void mtdCargarGridC()
        {
           
            clCursoL objCurso = new clCursoL();
            listaC = objCurso.mtdListarCurso();

            gvCurso.DataSource = listaC;

            gvCurso.DataBind();


        }
        private void mtdCargarGrid()
        {
            clProfesorL objPrf = new clProfesorL();
            listaP = objPrf.mtdListProfe();

            gvProfe.DataSource = listaP;

            gvProfe.DataBind();


        }
        private void mtdCargarGridM()
        {
            clMateriaL objMat = new clMateriaL();
            listaM = objMat.mtdListMat();

            gvMateria.DataSource = listaM;

            gvMateria.DataBind();


        }

        protected void lnkGuardar_Click(object sender, EventArgs e) //Recorer grids y guardar los id si encuentra checkeado guardarlod
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

            int resultsql = objCM.mtdAsignarCursoMateria(objECM);
            lblMensajeC.Text = idC;
            lblMensaje.Text = idP;
            lblMensajeM.Text = idM;
        }

    }


}














