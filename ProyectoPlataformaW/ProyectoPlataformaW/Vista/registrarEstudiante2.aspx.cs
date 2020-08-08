using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;

namespace ProyectoPlataformaW.Vista
{
    public partial class registrarEstudiante2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<clEntidadCursosE> listaCurso = new List<clEntidadCursosE>();
            clCursoD objCurso = new clCursoD();
            listaCurso = objCurso.mtdListarCurso();

            dpdCurso.DataSource = listaCurso;
            dpdCurso.DataTextField = "Curso";
            dpdCurso.DataValueField = "IdCurso";
            dpdCurso.DataBind();
        }

        protected void btnRegistrarE_Click(object sender, EventArgs e)
        {
            clEntidadEstudianteE objEEstu = new clEntidadEstudianteE();
            objEEstu.Nombres = txtNom.Text;
            objEEstu.Apellidos = txtApe.Text;
            objEEstu.Documento = int.Parse(txtDoc.Text);
            objEEstu.Email = txtEma.Text;
            objEEstu.Contrasena = Encrypt.GetSHA256(txtCon.Text);
            objEEstu.IdCurso = int.Parse(dpdCurso.Text);

            clEstudianteD objEstu = new clEstudianteD();
            int resultsql = objEstu.mtdRegistrarEstudiante(objEEstu);

            if (resultsql > 0)
            {
                Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                txtNom.Text = "";
                txtApe.Text = "";
                txtDoc.Text = "";
                txtEma.Text = "";
                txtCon.Text = "";
            }
                
            }
        }
    }
