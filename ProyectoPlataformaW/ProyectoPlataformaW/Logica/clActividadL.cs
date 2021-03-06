﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Datos;

namespace ProyectoPlataformaW.Logica
{
    public class clActividadL
    {
        public List<clEntidadActividadE> mtdActividades(clEntidadActividadE objE)
        {
            clActividadD objAc = new clActividadD();
            List<clEntidadActividadE> listaActi = new List<clEntidadActividadE>();
            listaActi = objAc.mtdListActividad(objE);
            return listaActi;
        }



        public List<clEntidadActividadE> mtdActividad(clEntidadActividadE objE)
        {
            clActividadD objAc = new clActividadD();
            List<clEntidadActividadE> listaActi = new List<clEntidadActividadE>();
            listaActi = objAc.mtdListActividadP(objE);
            return listaActi;
        }

        public List<clEntidadActividadE> mtdComboAct(clEntidadActividadE objE)
        {
            clActividadD objAc = new clActividadD();
            List<clEntidadActividadE> listaActi = new List<clEntidadActividadE>();
            listaActi = objAc.mtdCargarAct(objE);
            return listaActi;
        }

        public List<clEntidadActividadE> mtdComboact2(clEntidadActividadE objE)
        {
            clActividadD objAc = new clActividadD();
            List<clEntidadActividadE> listaActi = new List<clEntidadActividadE>();
            listaActi = objAc.mtdListActividadN(objE);
            return listaActi;
        }

    }
}