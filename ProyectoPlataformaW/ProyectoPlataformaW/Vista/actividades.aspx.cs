using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Datos;
using System.IO;
using System.Security.Permissions;

namespace ProyectoPlataformaW.Vista
{
    public partial class Actividades : System.Web.UI.Page
    {
        
        public static int id;
        public static string Descripcion;
      
        public string o;
        public static  string Ruta;

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









            clCursoMateriaD objcmd = new clCursoMateriaD();
            int var = clCursoMateriaD.datoDT;

            

            //string user = Session["usuario"].ToString();

            List<clEntidadActividadE> listaActividad = new List<clEntidadActividadE>();

            clEntidadActividadE objEs = new clEntidadActividadE();
            objEs.IdMateria =  inicioEstu.id;

            clActividadL objActividad = new clActividadL();
            listaActividad = objActividad.mtdActividades(objEs);


            if (listaActividad.Count != 0)
            {
                repeaterActividad.DataSource = listaActividad;
                repeaterActividad.DataBind();

                clActividadD objact = new clActividadD();
                int var2 = clActividadD.idActividad;
               



            }



        }

        protected void repeaterActividad_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
          
            o = repeaterActividad.Items[e.Item.ItemIndex].ItemIndex.ToString();

            
            id = int.Parse(((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblidActi")).Text);
            Descripcion = ((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblDescripcion")).Text;
            Ruta = ((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblArchivos")).Text;
        
            Response.Redirect("~/Vista/entregaActividad.aspx");

         

        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {
         
        }
        protected void Archivos(object sender, EventArgs e)
        {
           // Response.Write("<script> alert(" + Ruta + ") </script>");

           Response.Redirect(Ruta);
        }

       

     

    }
}