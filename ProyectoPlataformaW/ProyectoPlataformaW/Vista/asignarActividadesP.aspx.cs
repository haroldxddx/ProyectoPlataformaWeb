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
    public partial class asignarActividadesP : System.Web.UI.Page
    {
        List<clEntidadEstudianteEE> listEestu = new List<clEntidadEstudianteEE>();
        clRecuperarContra c = new clRecuperarContra();
        protected void Page_Load(object sender, EventArgs e)
        {

            /*if (Request.Params["id"] != null)
            {
                lblCursoM.Text = Request.Params["id"];
            }*/
            inicioProfesor objPR = new inicioProfesor();
            int vari = inicioProfesor.id;
            lblCursoM.Text = Convert.ToString(vari);


        }

       
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            /*clEntidadCursoMateriaE OBJE = new clEntidadCursoMateriaE();
            OBJE.IdCursoMateria = 1;

            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdCorreoMasivo(OBJE);*/

            //

            clEntidadActividadE objAct = new clEntidadActividadE();
            objAct.NombreActividad = txtNomAc.Text;
            objAct.Descripcion = txtDesc.Text;          
            objAct.Archivos = (string)(Session["Archivos"] = "~/Archivo/" + fluArchivo.FileName);
            objAct.FechaInicio = txtFechaIni.Text;
            objAct.FechaFinal = txtFechaFn.Text;
            objAct.IdCursoMateria = int.Parse(lblCursoM.Text);

            clActividadD objActividadD = new clActividadD();
            int result = objActividadD.mtdAsignarActividad(objAct);
           

            if (result>0)
            {
                /*for (int i = 0; i < listEestu.Count; i++)
                {
                    clEntidadEstudianteE objEstu = new clEntidadEstudianteE();
                    string correos = objEstu.Email = listEestu[i].Email;

                    while (listEestu.Count != 0)
                    {
                        c.enviarCorreoMasivo(correos);
                    }
                    //Response.Redirect("~/login/login.aspx");
                    //Response.Write("<script language=javascript>alert('Revise la bandeja de entrada de su correo electronico en breve recibira un correo con su contraseña');</script>");
                    //ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='~/login/login.aspx'", true);
                }*/
                //Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
                fluArchivo.SaveAs(Server.MapPath("~/Archivo/") + fluArchivo.FileName);
                ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();", true);
                txtNomAc.Text = "";
                txtDesc.Text = "";
                txtFechaIni.Text = "";
                txtFechaFn.Text = "";

            }




        }
    }
}