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
    public partial class RegistrarMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarE_Click(object sender, EventArgs e)
        {
            
                clEntidadMateriaE objEMateria = new clEntidadMateriaE();
                objEMateria.NombreMateria = txtNomM.Text;
                objEMateria.NivelAcademico = dplNivel.SelectedValue;

                clMateriaD objMateria = new clMateriaD();
                int result = objMateria.mtdRegistrarMateria(objEMateria);

            txtNomM.Text = "";

            
        }
    }
}