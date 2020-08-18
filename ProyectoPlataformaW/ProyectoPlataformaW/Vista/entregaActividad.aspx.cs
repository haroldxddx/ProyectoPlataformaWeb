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
    public partial class entregaActividad : System.Web.UI.Page
    {

        public static int idActi;
        public static int idEstu;

        public string o;
        public string Descripcion;

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

                    // Response.Redirect("~/inicio.aspx");

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

          

            Actividades objAct = new Actividades();

           
            string user = Session["usuario"].ToString();
            lblUser.Text = user;

            

            List<clEntidadActividadE> listaActividad = new List<clEntidadActividadE>();

            clEntidadActividadE objEs = new clEntidadActividadE();
            objEs.IdActividad = Actividades.id;

          // Response.Write("<script> alert(" + Actividades.q + ") </script>");

            clActividadL objActividad = new clActividadL();
            listaActividad = objActividad.mtdActividad(objEs);




            

            if (listaActividad.Count != 0 )
            {

               repeaterActividad.DataSource = listaActividad ;
                repeaterActividad.DataBind();


            }


            clEntidadEstudianteE obje = new clEntidadEstudianteE();
            obje.Email = user;
            List<clEntidadEstudianteE> listEestu = new List<clEntidadEstudianteE>();
            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdListaridEst(obje);


            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == user)
                {
                    clEntidadEstudianteE objEstu = new clEntidadEstudianteE();


                    int d = objEstu.IdEstudiante = int.Parse(listEestu[i].IdEstudiante.ToString());
                    lble.Text = (d).ToString();

                    lblnom.Text = objEstu.Nombres = listEestu[i].Nombres;
                    lblema.Text = objEstu.Apellidos = listEestu[i].Apellidos;


                }

            }
        }

        protected void repeaterActividad_ItemCommand(object source, RepeaterCommandEventArgs e)
        {


            o = repeaterActividad.Items[e.Item.ItemIndex].ItemIndex.ToString();

            Descripcion = ((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblDescripcion")).Text;
            idActi = int.Parse(((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblidActi")).Text);


           


        }

        protected void btnEntregaA_Click(object sender, EventArgs e)
        {



             clEntidadEntregaE objAct = new clEntidadEntregaE();

             objAct.Descripcion = Actividades.Descripcion;
             objAct.Archivos = (string)(Session["Archivos"] = "~/EntregaActividades/" + AdArchivo.FileName);
             objAct.IdActividad = Actividades.id;
             objAct.IdEstudiante = int.Parse(lble.Text);
             objAct.Vinculo = txtVinculo.Text;
             objAct.otraRespuesta = txtEvidencia.Text;
             objAct.Comentario = txtComentario.Text;


             clEntregaD objEntregaD = new clEntregaD();
             int result = objEntregaD.mtdAsignarEntrega(objAct);
             Response.Write("<script> alert("+"entrega con exito "+") </script>");
             
        }

    }
}