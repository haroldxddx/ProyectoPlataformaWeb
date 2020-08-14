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
    public partial class calificarActividad : System.Web.UI.Page
    {
        List<clEntidadEntregaE> listEnt = new List<clEntidadEntregaE>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int idact = 4;
            int idest = 8;
            clEntregaL objEnt = new clEntregaL();
            clEntidadEntregaE objEntrega = new clEntidadEntregaE();
            objEntrega.IdActividad = idact;
            objEntrega.IdEstudiante = idest;
            listEnt = objEnt.mtdEntregaDetalle(objEntrega);

            for (int i = 0; i < listEnt.Count; i++)
            {
                //clEntidadEntregaE objEnt2 = new clEntidadEntregaE();
                lblDesc2.Text = objEntrega.Descripcion = listEnt[i].Descripcion;
                lblFecha2.Text = objEntrega.Fecha = listEnt[i].Fecha;
                lblArchivo2.Text = objEntrega.Archivos = listEnt[i].Archivos;
                lblEstado2.Text = objEntrega.Estado = listEnt[i].Estado;
            }
        }
    }
}