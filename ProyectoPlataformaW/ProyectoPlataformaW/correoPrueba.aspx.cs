using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
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

        clRecuperarContra c = new clRecuperarContra();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            
            clEntidadEstudiante objEstu = new clEntidadEstudiante();
            objEstu.Email = txtCorreo.Text;

            clEstudianteD objEstuD = new clEstudianteD();
            int resultsql = int.Parse(objEstuD.mtdListar(objEstu).ToString());

            if (resultsql>0)
            {
                c.enviarCorreo(txtCorreo.Text);
            }
            else
            {
                lblError.Text = "No existe";
            }
        }
    }
}