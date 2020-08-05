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
    public partial class editPerfil2 : System.Web.UI.Page
    {
        List<clEntidadEstudiante> listEestu = new List<clEntidadEstudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {
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

            clEstudianteL objEstudianteL = new clEstudianteL();
            listEestu = objEstudianteL.mtdListadoComEs();
            string user = Session["usuario"].ToString();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].Email == user)
                {
                    clEntidadEstudiante objEstu = new clEntidadEstudiante();

                    txtNom.Text = objEstu.Nombres = listEestu[i].Nombres;
                    txtAp.Text = objEstu.Apellidos = listEestu[i].Apellidos;
                    int d = objEstu.Documento = int.Parse(listEestu[i].Documento.ToString());
                    txtDoc.Text = (d).ToString();

                    txtEmail.Text = objEstu.Email = listEestu[i].Email;

                }

            }
        }
    }
}