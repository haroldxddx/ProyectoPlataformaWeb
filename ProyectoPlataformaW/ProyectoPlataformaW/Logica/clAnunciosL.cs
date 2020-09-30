using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clAnunciosL
    {
        public int mtdEnvioDatos(clEntidadAnunciosE objDatos)
        {
            clAnunciosD objAnunciosD = new clAnunciosD();
            int regi = objAnunciosD.mtdRegistrarA(objDatos);
            return regi;
        }
        public int mtdEnvioDatos2(clEntidadAnunciosE objDatos)
        {
            clAnunciosD objAnunciosD = new clAnunciosD();
            int regi = objAnunciosD.mtdRegistrarAProf(objDatos);
            return regi;
        }
        public List<clAdminAnunciosE2> mtdListAnunAd()
        {
            clAnunciosD objEs = new clAnunciosD();
            List<clAdminAnunciosE2> listaEst = new List<clAdminAnunciosE2>();
            listaEst = objEs.mtdListAnunAdm();
            return listaEst;
        }
        public List<clAdminAnunciosE2> mtdListAnunPr()
        {
            clAnunciosD objEs = new clAnunciosD();
            List<clAdminAnunciosE2> listaEst = new List<clAdminAnunciosE2>();
            listaEst = objEs.mtdListAnunProf();
            return listaEst;
        }
        public int mtdGeneInfo(clEntidadAnunciosE objDatos)
        {
            clAnunciosD objAnunciosD = new clAnunciosD();
            int regi = objAnunciosD.mtdGenerarInforme(objDatos);
            return regi;
        }
    }
}