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
    public partial class reporteNotasEstud : System.Web.UI.Page
    {
        List<clEntidadEstudianteE> listEestu = new List<clEntidadEstudianteE>();
        List<clEntidadCursoMateriaE> listaCursoMa = new List<clEntidadCursoMateriaE>();
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

            clEstudianteL objEstudianteL = new clEstudianteL();
            clCursoMateriaL objCml = new clCursoMateriaL();
            clEntregaL objEL = new clEntregaL();

            clEntidadEstudianteE objEst = new clEntidadEstudianteE();
            objEst.Email = user;

            clEntidadCursoEE objCC = new clEntidadCursoEE();
            clEntidadEstudianteE objE = new clEntidadEstudianteE();
            clEntidadNotas objNOtas = new clEntidadNotas();
            clEstudianteL objELn = new clEstudianteL();
            objELn.mtdDatosEstu(objEst);

            clEstudianteD est = new clEstudianteD();
            int idcur = clEstudianteD.idCurso;

            //string user = Session["usuario"].ToString();
            objE.Email = user;
            objCC.IdCurso = idcur;
            

            listEestu = objEstudianteL.mtdInformeNotas(objE);
            listaCursoMa = objCml.mtdIdCursoMateria(objCC);
            


            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == user)
                {
                    clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

                    lblNombre.Text = objEstu.Nombres = listEestu[i].Nombres;
                    lblApellido.Text = objEstu.Apellidos = listEestu[i].Apellidos;
                    int d = objEstu.Documento = int.Parse(listEestu[i].Documento.ToString());
                    lblDocu.Text = (d).ToString();

                    lblEmail.Text = objEstu.Email = listEestu[i].Email;
                    lblCurso.Text = objEstu.Curso = listEestu[i].Curso;
                    lblGrado.Text = objEstu.Grado = listEestu[i].Grado;
                    lblFecha.Text = DateTime.Now.ToShortDateString();

                    for (int i2 = 0; i2 < listaCursoMa.Count; i2++)
                    {

                        //List<clNotasEstudE> listaNot = new List<clNotasEstudE>();
                        int idcurso = listaCursoMa[i2].IdCursoMateria;
                        objNOtas.IdCursoMateria = idcurso;


                        listNotas = objEL.mtdInformeNotas2(objNOtas);

                        repeaterNot.DataSource = listNotas;
                        repeaterNot.DataBind();

                        /*SqlDataSource1.SelectCommand = "DECLARE @query VARCHAR(4000) DECLARE @act VARCHAR(2000) SELECT @act = STUFF((SELECT DISTINCT '],[' + LTRIM([NombreActividad])FROM[dbo].[Actividad]inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria where CursoMateria.IdCursoMateria = '" + idcurso + "' ORDER BY '],[' + LTRIM([NombreActividad]) FOR XML PATH('') ),1,2,'') +']' SET @query = ' Select* from( select Actividad.NombreActividad as NombreAct , Entrega.Nota as Nota from Actividad inner join Entrega on Actividad.IdActividad = Entrega.IdActividad inner join Estudiante on Estudiante.IdEstudiante = Entrega.IdEstudiante inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria where CursoMateria.IdCursoMateria = " + idcurso + " and Estudiante.IdEstudiante = 8 ) T PIVOT( MAX(T.Nota) FOR T.NombreAct in ('+ @act +'))pivotrReport' EXECUTE(@query)";
                        SqlDataSource1.DataBind();

                    repeaterNot.DataBind();*/
                    }
                    }





                }

            }
        }
    }