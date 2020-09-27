using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;

namespace ProyectoPlataformaW.Vista
{
    public partial class editPerfil2 : System.Web.UI.Page
    {
        List<clEstudianteEEE> listEestu = new List<clEstudianteEEE>();
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






            //Activar Cajas de texto
            if (chbN.Checked == true)
            {
                txtNom.Enabled = true;
            }
            else if (chbA.Checked == true)
            {
                txtAp.Enabled = true;
            }
            else if (chbD.Checked == true)
            {
                txtDoc.Enabled = true;
            }
            else if (chbE.Checked == true)
            {
                txtEmail.Enabled = true;
            }
            else if (cbhC.Checked == true)
            {
                txtCo.Enabled = true;

            }

            //Llenar label con datos

            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdListadoComEs();
           // string user = Session["usuario"].ToString();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == user)
                {
                    clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

                    lblNom.Text = objEstu.Nombres = listEestu[i].Nombres;
                    lblAp.Text = objEstu.Apellidos = listEestu[i].Apellidos;
                    int d = objEstu.Documento = int.Parse(listEestu[i].Documento.ToString());
                    lblDoc.Text = (d).ToString();

                    lblEma.Text = objEstu.Email = listEestu[i].Email;

                }

            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clEntidadEstudianteE objEs = new clEntidadEstudianteE();
            
            /*objEs.Nombres = txtNom.Text;
            objEs.Apellidos = txtAp.Text;
            objEs.Documento = int.Parse(txtDoc.Text);*/
           
            clEstudianteL clE = new clEstudianteL();
               

            if (txtCo.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Contrasena = Encrypt.GetSHA256(txtCo.Text); ;
                int r = clE.mtdCambiarC(objEs);
                if (r > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/login/login.aspx'", true);
                   // Response.Redirect("~/Vista/inicioEstudiante.aspx");
                    //Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtCo.Text = "";
                    
                }

            }else if (txtNom.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Nombres = txtNom.Text;
                int r = clE.mtdENom(objEs);
                if (r > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/Vista/inicioEstudiante.aspx'", true);
                    //Response.Redirect("~/Vista/inicioEstudiante.aspx");
                    //Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtNom.Text = "";
                  
                }
            }
            else if (txtAp.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Apellidos = txtAp.Text;
                int r = clE.mtdEAp(objEs);
                if (r > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/Vista/inicioEstudiante.aspx'", true);
                    //Response.Redirect("~/Vista/inicioEstudiante.aspx");
                    //Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtAp.Text = "";
                }
            }
            else if (txtDoc.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Documento = int.Parse(txtDoc.Text);
                int r = clE.mtdEDoc(objEs);
                if (r > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/Vista/inicioEstudiante.aspx'", true);
                    //Response.Redirect("~/Vista/inicioEstudiante.aspx");
                    //Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtDoc.Text = "";
                }
            }
            else if (txtEmail.Text != "")
            {
                objEs.Documento = int.Parse(lblDoc.Text);
                objEs.Email = txtEmail.Text;
                int r = clE.mtdEemail(objEs);
                if (r > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/login/login.aspx'", true);
                    //Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    //Response.Redirect("~/Vista/login.aspx");
                    
                    txtEmail.Text = "";
                }
            }
           
                
            
        }
    }
}