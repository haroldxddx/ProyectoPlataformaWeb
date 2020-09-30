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
    public partial class registrarForoActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();

            // clForoL objFoL = new clForoL();
            //   clEntidadForoE objDatos = new clEntidadForoE();
            //    objFoL.mtdRegistrarFo(objDatos);

            List<clEntidadActividadE> listaAc = new List<clEntidadActividadE>();
            clActividadD objAct = new clActividadD();
            inicioProfesor objPR = new inicioProfesor();
            int vari = inicioProfesor.id;
            clEntidadActividadE objActiviE = new clEntidadActividadE();
            objActiviE.IdCursoMateria = vari;

            listaAc = objAct.mtdListActividadN(objActiviE);

            ddlActividad.DataSource = listaAc;
            ddlActividad.DataTextField = "NombreActividad";
            ddlActividad.DataValueField = "IdActividad";
            ddlActividad.DataBind();
        }

        protected void btnRegistrarP_Click(object sender, EventArgs e)
        {
            clForoD objD = new clForoD();
            // int id = clForoD.IdAdmin;

            clEntidadForoE objForoE = new clEntidadForoE();
            objForoE.Titulo = txtTitulo.Text;
            objForoE.Fecha = lblFecha.Text;
            objForoE.Descripcion = txtDesc.Text;
            objForoE.Imagen = (string)(Session["Imagen"] = "~/ForoImagen/" + fluImagen.FileName);
            objForoE.Archivo = (string)(Session["Archivos"] = "~/ForoImagen/" + fluArchivo.FileName);
            objForoE.Tipo = ddlTipo.SelectedValue;
            objForoE.IdActividad = int.Parse(ddlActividad.Text);

            fluImagen.SaveAs(Server.MapPath("~/ForoImagen/") + fluImagen.FileName);
            fluArchivo.SaveAs(Server.MapPath("~/ForoImagen/") + fluArchivo.FileName);


            clForoL objForoL = new clForoL();
            int result = objForoL.mtdRegistrarFo(objForoE);


            if (result > 0)
               {
            
             ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/inicioProfesor.aspx'", true);
             //Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");
             txtTitulo.Text = "";


              }
        }
    }
}