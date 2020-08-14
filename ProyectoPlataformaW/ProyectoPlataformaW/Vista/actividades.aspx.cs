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
        public static int idAct;
        public static Label idA;
        public static Label w;
        public static string q;
       

        protected void Page_Load(object sender, EventArgs e)

        {

            clCursoMateriaD objcmd = new clCursoMateriaD();
            int var = clCursoMateriaD.datoDT;


            





            string user = Session["usuario"].ToString();

            List<clEntidadActividadE> listaActividad = new List<clEntidadActividadE>();

            clEntidadActividadE objEs = new clEntidadActividadE();
            objEs.IdMateria =  var;

            clActividadL objActividad = new clActividadL();
            listaActividad = objActividad.mtdActividades(objEs);


            if (listaActividad.Count != 0)
            {
                repeaterActividad.DataSource = listaActividad;
                repeaterActividad.DataBind();

                clActividadD objact = new clActividadD();
                int var2 = clActividadD.idActividad;
                idAct = var2;



            }
       

        
        }

        protected void repeaterActividad_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
           idA = (Label)e.Item.FindControl("lblidActi");
            int x = 1;

            


        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {


            Label Label1 = (Label)item.FindControl("Label ID");


            //  Response.Redirect("~/Vista/entregaActividad.aspx");
            foreach (RepeaterItem item in repeaterActividad.Items)
            {
                Label CountryLabel = (Label)item.FindControl("lblidActi");
               //TextBox CountryCommentTB = (TextBox)item.FindControl("CountryCommentTB");


                string countryName = CountryLabel.Text;
                //string countryComment = CountryCommentTB.Text;
                Response.Write("<script> alert(" + countryName + ") </script>");

                // Do something with the data...
            }

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