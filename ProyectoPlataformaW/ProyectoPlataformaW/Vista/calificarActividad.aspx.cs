﻿using ProyectoPlataformaW.Entidades;
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


            verEntregasEstudiantes objEntrE = new verEntregasEstudiantes();

            clEntregaL objEnt = new clEntregaL();
            clEntidadEntregaE objEntrega = new clEntidadEntregaE();
            objEntrega.IdActividad = verEntregasEstudiantes.idAct;
            objEntrega.IdEstudiante = verEntregasEstudiantes.id;
            listEnt = objEnt.mtdEntregaDetalle(objEntrega);

            for (int i = 0; i < listEnt.Count; i++)
            {
                //clEntidadEntregaE objEnt2 = new clEntidadEntregaE();
                lblDesc2.Text = objEntrega.Descripcion = listEnt[i].Descripcion;
                lblFecha2.Text = objEntrega.Fecha = listEnt[i].Fecha;
                lblArchivo2.Text = objEntrega.Archivos = listEnt[i].Archivos;
                lblEstado2.Text = objEntrega.Estado = listEnt[i].Estado;
                int d = objEntrega.IdEntrega = int.Parse(listEnt[i].IdEntrega.ToString());
                lblIdEntrega.Text = (d).ToString();

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            clEntidadEntregaE objEnt = new clEntidadEntregaE();
            clEntregaL entL = new clEntregaL();


            objEnt.Nota = txtCalificar.Text;
            objEnt.IdEntrega = int.Parse(lblIdEntrega.Text);

            int result = entL.mtdActNota(objEnt);

            if (result >0)
            {
                clEntidadEntregaE objEnt2 = new clEntidadEntregaE();
                objEnt2.IdEntrega = int.Parse(lblIdEntrega.Text);
                entL.mtdCambEst(objEnt2);

                Response.Write("<script> alert(" + "'Actividad Calificada Con exito'" + ") </script>");
                string javas = "swalDefaultSuccess();";
                ScriptManager.RegisterStartupScript(this, this.GetType(),"script", javas, true);

            }

        }
    }
}