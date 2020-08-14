using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clEntregaL
    {
        public List<clEntidadEntregaE> mtdEntregaDetalle(clEntidadEntregaE objE)
        {
            clEntregaD objEnt = new clEntregaD();
            List<clEntidadEntregaE> listaEntre = new List<clEntidadEntregaE>();
            listaEntre = objEnt.mtdEntregaEst(objE);
            return listaEntre;
        }
    }
}