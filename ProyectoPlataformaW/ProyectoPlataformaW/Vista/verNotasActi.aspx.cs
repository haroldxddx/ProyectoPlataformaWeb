using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoPlataformaW.Vista
{
    public partial class verNotasActi : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            string user = Session["usuario"].ToString();

            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "profesor")
                {
                    clRecuperarContra c = new clRecuperarContra();
                    c.enviarCorreoIsecion(user);
                }
                else if (Session["general"].ToString() != "profesor")
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






            inicioProfesor objPR = new inicioProfesor();
            lblIdCurso.Text = Convert.ToString(inicioProfesor.id);
            //int id = inicioProfesor.id;

            SqlDataSource1.SelectCommand = "DECLARE @query VARCHAR(4000) DECLARE @act VARCHAR(2000) SELECT @act = STUFF((SELECT DISTINCT '],[' + LTRIM([NombreActividad])FROM[dbo].[Actividad]inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria where CursoMateria.IdCursoMateria = '" + inicioProfesor.id + "' ORDER BY '],[' + LTRIM([NombreActividad]) FOR XML PATH('') ),1,2,'') +']' SET @query = ' Select * from( select Estudiante.Nombres, Estudiante.Apellidos, Actividad.NombreActividad as NombreAct , Entrega.Nota as Nota from Actividad inner join Entrega on Actividad.IdActividad = Entrega.IdActividad inner join Estudiante on Estudiante.IdEstudiante = Entrega.IdEstudiante inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria where CursoMateria.IdCursoMateria = " + inicioProfesor.id + " ) T PIVOT( MAX(T.Nota) FOR T.NombreAct in ('+ @act +'))pivotrReport' EXECUTE(@query)";
            SqlDataSource1.DataBind();



        }
    }
}