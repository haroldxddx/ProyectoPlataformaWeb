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

        public int mtdActNota(clEntidadEntregaE objE)
        {
            clEntregaD e = new clEntregaD();
            int ed = e.mtdAsigNota(objE);
            return ed;

        }
        public int mtdCambEst(clEntidadEntregaE objE)
        {
            clEntregaD e = new clEntregaD();
            int ed = e.mtdCambiarEstadoEnt(objE);
            return ed;

        }
    }
}