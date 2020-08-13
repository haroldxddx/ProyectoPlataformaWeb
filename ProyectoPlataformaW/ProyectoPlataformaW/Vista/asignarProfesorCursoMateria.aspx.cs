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
        clEntidadCursoMateriaE objECM = new clEntidadCursoMateriaE();
        clCursoMateriaD objCM = new clCursoMateriaD();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mtdCargarGrid();

            



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

            clProfesorD objPrfe = new clProfesorD();
           listaProfesor = objPrfe.mtdListarProfesor(Request.QueryString["IdProfesor"]);


            }
            
        }

        private void mtdCargarGrid()
        {
            clProfesorD objPrf = new clProfesorD();
            listaProfesor = objPrf.mtdListarProfe();

            gvProfe.DataSource = listaProfesor;

            gvProfe.DataBind();


        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // if (!Page.IsPostBack)
            {
                //    var datosFila = e.ToString().Split(',');

                //La pocisión va de acuerdo a como construiste el Command Argument en nuestro caso es:




                //Asignas cada variable con tu control de texto respectivamente

                //   TextBox1.Text = campoColumnaUno;


                // y Listo!!! la información de la fila seleccionada ya está en tus controles
            }
        }

    //    protected void lnkContar_Click(object sender, EventArgs e)

   //     {
            // foreach (GridViewRow gvrow in gvProfe.Rows)

            // {
            //     string id = gvrow.Cells[1].Text;
            //   var checkbox = gvrow.FindControl("CheckBox1") as CheckBox;
            //  if (checkbox.Checked)
            // {

            //       var lblID = gvrow.FindControl("Label1") as Label;

            // foreach (GridViewRow gr in gvProfe.Rows)
            //{
            //    CheckBox check = (CheckBox)gr.FindControl("CheckBox1");

            //  check.Checked= "IdProfesor";
            //  check. = "IdCurso";
            //         if (check.Checked == true)
            //     {
            //   }
            // string cell_2_Value = gvProfe.Rows[gr.RowIndex].Cells[1].Text;
            //do what you want with the value

            // CheckBox chkId;
            // int contador = 0;
            // string val = string.Empty;
            // foreach (GridViewRow grvRow in gvProfe.Rows)
          //  {
                //  chkId = (CheckBox)grvRow.FindControl("chbItem");
                //    if (chkId.Checked)
                //   {
                //     val = grvRow.Cells[0].Text;
                //     contador++;
              

                // objECM.IdCurso = int.Parse(dpdIdCurso.Text);
                // objECM.IdMateria = int.Parse(dpdIdMateria.Text);
                //  objECM.IdProfesor = int.Parse(TextBox1.Text);



                // int resultsql = objCM.mtdAsignarCursoMateria(objECM);


                //  if (resultsql > 0)
                //  {
                //      Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");

                //  }

                //   Response.Write("<script> alert(" + "'ptos'" + ") </script>");

           // }


        protected void gvProfe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lnkMostrar_Click(object sender, EventArgs e)
        {
           CheckBox chbId;
            int contador = 0;
            string val = string.Empty;
            foreach (GridViewRow grvRow in gvProfe.Rows)
            {
                chbId = (CheckBox)grvRow.FindControl("chbItem");
                if (chbId.Checked)
                {

                     val = grvRow.Cells[2].Text;
                    //    contador++;

                     objECM.IdCurso = int.Parse(dpdIdCurso.Text);
                     objECM.IdMateria = int.Parse(dpdIdMateria.Text);
                     objECM.IdProfesor = val.Length;
                     int resultsql = objCM.mtdAsignarCursoMateria(objECM);

                }

            }
             lblMensaje.Text = "xd " + val.ToString();

            }
        }

        }
  //  }
   // }












