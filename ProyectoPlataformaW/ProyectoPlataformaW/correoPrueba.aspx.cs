using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW
{

    public partial class correoPrueba : System.Web.UI.Page
    {


        List<clEntidadEstudiante> listEestu = new List<clEntidadEstudiante>();
        clRecuperarContra c = new clRecuperarContra();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdRecup();

            //string email = (objEstu.Email = txtCorreo.Text);
            string email = txtCorreo.Text;
            List<clEntidadEstudiante> listaEstuDos = new List<clEntidadEstudiante>();
            clEstudianteD objEstuD = new clEstudianteD();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == email)
                {
                    clEntidadEstudiante objEstu = new clEntidadEstudiante();

                    objEstu.Email = listEestu[i].Email;
                    string contra = objEstu.Contrasena = listEestu[i].Contrasena;


                    listaEstuDos.Add(objEstu);
                    c.enviarCorreo(email,contra);

                }else
                {
                   // lblError.Text = "error ";

                }
            }


        }
    }
}