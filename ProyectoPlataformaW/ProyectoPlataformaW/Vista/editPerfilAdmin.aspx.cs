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
    public partial class editPerfilAdmin : System.Web.UI.Page
    {
        List<clEntidadAdministradorE> listEestu = new List<clEntidadAdministradorE>();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["general"].ToString() == null)
                {
                    Response.Write("<script> alert(" + "'sitio deshabilitado'" + ") </script>");
                }

                if (Session["general"].ToString() == "administrador")
                {



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

            clAdministradorL objAdminL = new clAdministradorL();
            listEestu = objAdminL.mtdListAdm();
            string user = Session["usuario"].ToString();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == user)
                {
                    clEntidadAdministradorE objEstu = new clEntidadAdministradorE();

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
            clEntidadAdministradorE objEs = new clEntidadAdministradorE();

            /*objEs.Nombres = txtNom.Text;
            objEs.Apellidos = txtAp.Text;
            objEs.Documento = int.Parse(txtDoc.Text);*/

            clAdministradorL clE = new clAdministradorL();


            if (txtCo.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Contrasena = Encrypt.GetSHA256(txtCo.Text); ;
                int r = clE.mtdCambiarC(objEs);
                if (r > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/login/login.aspx'", true);
                   // Response.Redirect("~/Vista/inicioAdministrador.aspx");
                    //Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    txtCo.Text = "";

                }

            }
            else if (txtNom.Text != "")
            {
                objEs.Email = lblEma.Text;
                objEs.Nombres = txtNom.Text;
                int r = clE.mtdENom(objEs);
                if (r > 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/Vista/inicioAdministrador.aspx'", true);
                    //Response.Redirect("~/Vista/inicioAdministrador.aspx");
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
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/Vista/inicioAdministrador.aspx'", true);
                    //Response.Redirect("~/Vista/inicioAdministrador.aspx");
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
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/Vista/inicioAdministrador.aspx'", true);
                    //Response.Redirect("~/Vista/inicioAdministrador.aspx");
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
                    ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/login/login.aspx'", true);
                    //Response.Write("<script> alert(" + "'Informacion Actualizada Correctamente'" + ") </script>");
                    //Response.Redirect("~/Vista/login.aspx");

                    txtEmail.Text = "";
                }
            }
        }
    }
}