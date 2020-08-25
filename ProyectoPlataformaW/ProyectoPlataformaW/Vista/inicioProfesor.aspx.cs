using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{

    public partial class inicioProfesor : System.Web.UI.Page

    {
        public static int id;
        public string o;


        protected void lbtCurso_Click(object sender, EventArgs e)
        {

            
            // Label lblprueba = ((Label)repeaterPrueba.Items[1].FindControl("lblIdCursoMateria"));
            //string xd = lblprueba.Text;
            // clCursoMateriaD objCm = new clCursoMateriaD();
            //int var2 = clCursoMateriaD.idCursoMat;
            //idCursoM = var2;
            //Response.Redirect("/Vista/asignarActividadesP.aspx");

            //  Response.Redirect("/Vista/asignarActividadesP.aspx?id="+ id);

           



        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<clEntidadCursoMateriaE> listP = new List<clEntidadCursoMateriaE>();
            string user = Session["usuario"].ToString();

            clEntidadCursoMateriaE objpro = new clEntidadCursoMateriaE();
            objpro.Email = user;

            clCursoMateriaL objCmL = new clCursoMateriaL();
            listP = objCmL.mtdCursosP(objpro);

            if (listP.Count != 0)
            {
                repeaterPrueba.DataSource = listP;
                repeaterPrueba.DataBind();

                

            }
            /*for (int i = 0; i < listP.Count; i++)
            {
                if (listP[i].Email == user)
                {
                    
                    repeaterPrueba.DataSource = listP;
                    repeaterPrueba.DataBind();
                     clCursoMateriaD objCm = new clCursoMateriaD();
                    int var2 = clCursoMateriaD.idCursoMat;
                    idCursoM = var2;

                }

            }*/


            clRecuperarContra c = new clRecuperarContra();
            c.enviarCorreoIsecion(user);





        }


      

        protected void repeaterPrueba_ItemCommand(object source, RepeaterCommandEventArgs e)
        {


            //o = repeaterActividad.Items[e.Item.ItemIndex].ItemIndex.ToString();

//            id = int.Parse(((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblidActi")).Text);
            o = repeaterPrueba.Items[e.Item.ItemIndex].ItemIndex.ToString();
            id = int.Parse(((Label)repeaterPrueba.Items[int.Parse(o)].FindControl("lblIdCursoMateria")).Text);

            Response.Redirect("/Vista/asignarActividadesP.aspx");
            //Label lb = (Label)e.Item.FindControl("IdCursoMateria");

        }
    }
}