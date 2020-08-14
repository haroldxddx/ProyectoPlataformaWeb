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
        List<clEntidadEstudianteE> listEestu = new List<clEntidadEstudianteE>();
        protected void Page_Load(object sender, EventArgs e)
        {

            //para editar esta pagina descomentarear esta linea by mao
           // Session["general"] = "administrador";




    

        }

        protected void Page_Init(object sender, EventArgs e)
        {

            //para editar esta pagina descomentarear esta linea by mao
            // Session["general"] = "administrador";


            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "administrador")
                {
                    List<ClEntidadCursosE> listC = new List<ClEntidadCursosE>();
                    List<clEntidadEstudianteE> listE = new List<clEntidadEstudianteE>();

                    clCursoL objCurso = new clCursoL();
                    clEstudianteL objEstud = new clEstudianteL();

                    listC = objCurso.mtdComboCur();
                    listE = objEstud.mtdListadoComEs();
                    cmbCurso.DataSource = listC;
                    cmbCurso.DataTextField = "Curso";
                    cmbCurso.DataValueField = "IdCurso";
                    cmbCurso.DataBind();

                    gvEstu.DataSource = listE;
                    gvEstu.DataBind();


                }
                else if (Session["general"].ToString() != "administrador")
                {

                    Response.Redirect("~/inicio.aspx");
                }
            }
            catch (Exception)
            {

                Response.Write("<script> alert(" + "'sitio deshabilitado favor redirijase a nuestra pagina'" + ") </script>");

                //si necesita editar la pagina de estudiante no descomentarear la siguiente linea :v by mao
                //redirigir a login //

                Session.Clear();
                Response.Redirect("~/inicio.aspx");





            }




        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomAP = txtNombreE.Text;

            List<clEntidadEstudianteE> listaBuscar = new List<clEntidadEstudianteE>();

            clEntidadEstudianteE objEstudiante = new clEntidadEstudianteE();
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
            string cu = cmbCurso.Text;
            List<clEntidadEstudianteE> listaEstuDos = new List<clEntidadEstudianteE>();
            clEstudianteD objEstuD = new clEstudianteD();
            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdListadoComEs();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Curso == cu)
                {

                    clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

                    objEstu.Nombres = listEestu[i].Nombres;
                    objEstu.Apellidos = listEestu[i].Apellidos;
                    objEstu.Documento = int.Parse(listEestu[i].Documento.ToString());
                    objEstu.Email = listEestu[i].Email;
                    objEstu.Grado = listEestu[i].Grado;
                    objEstu.Curso = listEestu[i].Curso;
                    
                    gvEstu.DataSource = listaEstuDos;
                    gvEstu.DataBind();

                    listaEstuDos.Add(objEstu);
                    

                }
               
            }
        }

        protected void txtNombreE_TextChanged(object sender, EventArgs e)
        {
            string nomAP = txtNombreE.Text;

            List<clEntidadEstudianteE> listaBuscar = new List<clEntidadEstudianteE>();

            clEntidadEstudianteE objEstudiante = new clEntidadEstudianteE();
            objEstudiante.Nombres = nomAP;

            clEstudianteL objEstudianteL = new clEstudianteL();
            listaBuscar = objEstudianteL.mtdBuscarEstu(objEstudiante);

            if (listaBuscar.Count != 0)
            {
                gvEstu.DataSource = listaBuscar;
                gvEstu.DataBind();

            }
        }

        protected void lbtCurso_Click(object sender, EventArgs e)
        {


        }

        protected void gvEstu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}