using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Datos;




namespace ProyectoPlataformaW.Vista
{
    public partial class Actividades : System.Web.UI.Page
    {
        
        public static int id;
        public static string Descripcion;
      
        public string o;

        protected void Page_Load(object sender, EventArgs e)

        {

            clCursoMateriaD objcmd = new clCursoMateriaD();
            int var = clCursoMateriaD.datoDT;

            
            





            string user = Session["usuario"].ToString();

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

            Response.Write("<script> alert(" + id + ") </script>");

            Response.Redirect("~/Vista/entregaActividad.aspx");

         

        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox TextBox1 = (TextBox)sender;
            RepeaterItem item = (RepeaterItem)TextBox1.NamingContainer;
            Label Label1 = (Label)item.FindControl("Label ID");
            //get value here
            string strValue = Label1.Text;
        }

    }
}