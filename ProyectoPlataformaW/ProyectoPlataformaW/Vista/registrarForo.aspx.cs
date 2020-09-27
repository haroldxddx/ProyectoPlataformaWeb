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
    public partial class registrarForo : System.Web.UI.Page
    { 
     protected void Page_Load(object sender, EventArgs e)
    {
        lblFecha.Text = DateTime.Now.ToShortDateString();

       // clForoL objFoL = new clForoL();
         //   clEntidadForoE objDatos = new clEntidadForoE();
        //    objFoL.mtdRegistrarFo(objDatos);

            List<clEntidadActividadE> listaAc = new List<clEntidadActividadE>();
            clActividadD objAct = new clActividadD();
            listaAc = objAct.mtdListActividadN();

            dpdActividad.DataSource = listaAc;
            dpdActividad.DataTextField = "NombreActividad";
            dpdActividad.DataValueField = "IdActividad";
            dpdActividad.DataBind();

        }

       

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
          
                clForoD objD = new clForoD();
                // int id = clForoD.IdAdmin;

                clEntidadForoE objForoE = new clEntidadForoE();
                objForoE.Titulo = txtTitulo.Text;
                objForoE.Fecha = lblFecha.Text;
                objForoE.Descripcion = txtDescripcion.Text;
                objForoE.Imagen = (string)(Session["Imagen"] = "~/Foro/" + flupImagen.FileName);
                objForoE.Archivo = (string)(Session["Archivo"] = "~/Foro/" + flupArchivo.FileName);
                objForoE.Tipo = dpdTipo.SelectedValue;
                objForoE.IdActividad = int.Parse(dpdActividad.Text);
            

            clForoL objForoL = new clForoL();
                int result = objForoL.mtdRegistrarFo(objForoE);


           // if (result > 0)
         //   {
          //      flupArchivo.SaveAs(Server.MapPath("~/Foro/") + flupArchivo.FileName);
           //     flupImagen.SaveAs(Server.MapPath("~/Foro/") + flupImagen.FileName);
               // ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/inicioAnuncio.aspx'", true);
            //     Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
              //  txtTitulo.Text = "";
               

          //  }
            //Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");

                }
            }

        }
    
