﻿using ProyectoPlataformaW.Datos;
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
    public partial class foroActividad : System.Web.UI.Page
    {
        List<clEntidadForoE> listEestu = new List<clEntidadForoE>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["usuario"].ToString();
            lblFecha.Text = DateTime.Now.ToShortDateString();

            clEntidadProfesorE objProfe = new clEntidadProfesorE();
            clProfesorL objprofL = new clProfesorL();

            objProfe.Email = user;
            objprofL.mtdDatosEstu(objProfe);

            
           



            List<clEntidadParticipacionE> listP = new List<clEntidadParticipacionE>();
            List<clEntidadParticipacionE> listP2 = new List<clEntidadParticipacionE>();
            clForoL objCmL = new clForoL();
            forosTotalesAct xd = new forosTotalesAct();
            int vari = forosTotalesAct.id;

            clEntidadForoE objFore = new clEntidadForoE();
            objFore.IdForo = vari;


            clEntidadParticipacionE objPe = new clEntidadParticipacionE();
            objPe.IdForo = vari;

            clEntidadForoE objFora = new clEntidadForoE();
            listEestu = objCmL.mtdForosDESC();

            for (int i = 0; i < listEestu.Count; i++)
            {
                if (listEestu[i].IdForo == vari)
                {
                    clEntidadForoE objEstu = new clEntidadForoE();

                    lblTitulo.Text = objEstu.Titulo = listEestu[i].Titulo;
                    lblTipo.Text = objEstu.Tipo = listEestu[i].Tipo;                 
                    lblDesc.Text = objEstu.Descripcion = listEestu[i].Descripcion;
                }

            }
            //listP2 = objCmL.mtdListAnunPr();
            listP = objCmL.mtdComent(objPe);
            listP2 = objCmL.mtdComentP(objPe);

            if (listP.Count != 0)
            {
                repeaterComent.DataSource = listP;
                repeaterComent.DataBind();

            }
            if (listP2.Count != 0)
            {
                repeaterProfesor.DataSource = listP2;
                repeaterProfesor.DataBind();

            }
        }

        

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            clEntidadParticipacionE objPeF = new clEntidadParticipacionE();
            clProfesorD objPD = new clProfesorD();
            clForoL objFor = new clForoL();
            int variable = forosTotalesAct.id;

            objPeF.Fecha = lblFecha.Text;
            objPeF.Comentario = txtComent.Text;
            objPeF.IdProfesor = clProfesorD.IdProfesor;
            objPeF.IdForo = variable;

            int result = objFor.mtdComentarioT(objPeF);

            if (result > 0)
            {
                 ClientScript.RegisterStartupScript(GetType(), "Mijs", "registro();window.location.href='/Vista/foroActividad.aspx'", true);
               // Response.Write("<script> alert(" + "'Registro Realizado Correctamente'" + ") </script>");

            }
        }
    }
}