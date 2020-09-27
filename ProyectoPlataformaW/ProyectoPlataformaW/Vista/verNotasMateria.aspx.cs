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
    public partial class verNotasMateria : System.Web.UI.Page
    {
        List<clEntidadNotas> listNotas = new List<clEntidadNotas>();
        protected void Page_Load(object sender, EventArgs e)
        {

            string user = Session["usuario"].ToString();

            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "estudiante")
                {
                    clRecuperarContra c = new clRecuperarContra();
                    c.enviarCorreoIsecion(user);
                }
                else if (Session["general"].ToString() != "estudiante")
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

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            string user = Session["usuario"].ToString();

            clEntidadEstudianteE objEst = new clEntidadEstudianteE();
            objEst.Email = user;

            clEstudianteL objEL = new clEstudianteL();
            objEL.mtdDatosEstu(objEst);

            clEstudianteD est = new clEstudianteD();
            int idcur = clEstudianteD.idCurso;

            List<clNotasEstudE> listNot = new List<clNotasEstudE>();
            clMateriaL objMat = new clMateriaL();
            clNotasEstudE objNot = new clNotasEstudE();

            objNot.IdCurso = idcur;


            listNot = objMat.mtdCargarComboMat(objNot);

            ddlMateria.DataSource = listNot;
            ddlMateria.DataTextField = "NombreMateria";
            ddlMateria.DataValueField = "IdCursoMateria";
            ddlMateria.DataBind();

     

        }


        protected void ddlMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            clEstudianteD est = new clEstudianteD();
            int idcurs = clEstudianteD.idEstudiante;

            SqlDataSource1.SelectCommand = "DECLARE @query VARCHAR(4000) DECLARE @act VARCHAR(2000) SELECT @act = STUFF((SELECT DISTINCT '],[' + LTRIM([NombreActividad])FROM[dbo].[Actividad]inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria where CursoMateria.IdCursoMateria = '" + ddlMateria.SelectedValue + "' ORDER BY '],[' + LTRIM([NombreActividad]) FOR XML PATH('') ),1,2,'') +']' SET @query = ' Select* from( select Actividad.NombreActividad as NombreAct , Entrega.Nota as Nota from Actividad inner join Entrega on Actividad.IdActividad = Entrega.IdActividad inner join Estudiante on Estudiante.IdEstudiante = Entrega.IdEstudiante inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria where CursoMateria.IdCursoMateria = " + ddlMateria.SelectedValue + " and Estudiante.IdEstudiante = " + idcurs + " ) T PIVOT( MAX(T.Nota) FOR T.NombreAct in ('+ @act +'))pivotrReport' EXECUTE(@query)";
            SqlDataSource1.DataBind();
        }
    }
}