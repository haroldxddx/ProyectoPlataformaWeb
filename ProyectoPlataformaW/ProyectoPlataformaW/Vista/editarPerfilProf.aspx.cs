using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProyectoPlataformaW.Datos.clEncrypt;

namespace ProyectoPlataformaW.Vista
{
    public partial class editarPerfilProf : System.Web.UI.Page
    {
        List<clEntidadProfesorE> listEestu = new List<clEntidadProfesorE>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "estudiante")
                {



                }
                else if (Session["general"].ToString() != "estudiante")
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

            clProfesorL objProfL = new clProfesorL();
            listEestu = objProfL.mtdListProf();
            string user = Session["usuario"].ToString();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == user)
                {
                    clEntidadProfesorE objprf = new clEntidadProfesorE();

                    lblNom.Text = objprf.Nombres = listEestu[i].Nombres;
                    lblAp.Text = objprf.Apellidos = listEestu[i].Apellidos;
                    int d = objprf.Documento = int.Parse(listEestu[i].Documento.ToString());
                    lblDoc.Text = (d).ToString();

                    lblEma.Text = objprf.Email = listEestu[i].Email;

                }

            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clEntidadProfesorE objEs = new clEntidadProfesorE();

            /*objEs.Nombres = txtNom.Text;
            objEs.Apellidos = txtAp.Text;
            objEs.Documento = int.Parse(txtDoc.Text);*/

            clProfesorL clE = new clProfesorL();


            if (txtCo.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Contrasena = Encrypt.GetSHA256(txtCo.Text); ;
                int r = clE.mtdEcoP(objEs);
                if (r > 0)
                {
                    Response.Redirect("~/Vista/login.aspx");
                    Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtCo.Text = "";

                }

            }
            else if (txtNom.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Nombres = txtNom.Text;
                int r = clE.mtdENomP(objEs);
                if (r > 0)
                {
                    Response.Redirect("~/Vista/inicioProfesor.aspx");
                    Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtNom.Text = "";

                }
            }
            else if (txtAp.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Apellidos = txtAp.Text;
                int r = clE.mtdEApellP(objEs);
                if (r > 0)
                {
                    Response.Redirect("~/Vista/inicioProfesor.aspx");
                    Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtAp.Text = "";
                }
            }
            else if (txtDoc.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Documento = int.Parse(txtDoc.Text);
                int r = clE.mtdEDocuP(objEs);
                if (r > 0)
                {
                    Response.Redirect("~/Vista/inicioProfesor.aspx");
                    Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtDoc.Text = "";
                }
            }
            else if (txtEmail.Text != "")
            {
                objEs.Documento = int.Parse(lblDoc.Text);
                objEs.Email = txtEmail.Text;
                int r = clE.mtdEemailP(objEs);
                if (r > 0)
                {
                    Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    Response.Redirect("~/Vista/login.aspx");

                    txtEmail.Text = "";
                }
            }
        }
    }
}