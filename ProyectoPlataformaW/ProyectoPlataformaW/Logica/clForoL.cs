using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clForoL
    {
        public int mtdRegistrarFo(clEntidadForoE objDatos)
        {
            clForoD objAnunciosD = new clForoD();
            int regi = objAnunciosD.mtdRegistrarForo(objDatos);
            return regi;
        }
        public List<clEntidadParticipacionE> mtdComent(clEntidadParticipacionE objDatos)
        {
            clForoD objEs = new clForoD();
            List<clEntidadParticipacionE> listaEst = new List<clEntidadParticipacionE>();
            listaEst = objEs.mtdComentsForo(objDatos);
            return listaEst;
        }
        public List<clEntidadForoE> mtdForosD(clEntidadForoE objDatos)
        {
            clForoD objEs = new clForoD();
            List<clEntidadForoE> listaEst = new List<clEntidadForoE>();
            listaEst = objEs.mtdForosDisp(objDatos);
            return listaEst;
        }
        public int mtdComentarioT(clEntidadParticipacionE objDatos)
        {
            clForoD objAnunciosD = new clForoD();
            int regi = objAnunciosD.mtdComentar(objDatos);
            return regi;
        }
        public List<clEntidadParticipacionE> mtdComentP(clEntidadParticipacionE objDatos)
        {
            clForoD objEs = new clForoD();
            List<clEntidadParticipacionE> listaEst = new List<clEntidadParticipacionE>();
            listaEst = objEs.mtdComentsForoP(objDatos);
            return listaEst;
        }
        public int mtdComentarioEE(clEntidadParticipacionE objDatos)
        {
            clForoD objAnunciosD = new clForoD();
            int regi = objAnunciosD.mtdComentarE(objDatos);
            return regi;
        }
        public List<clEntidadForoE> mtdForosDESC()
        {
            clForoD objEs = new clForoD();
            List<clEntidadForoE> listaEst = new List<clEntidadForoE>();
            listaEst = objEs.mtdForosDesc();
            return listaEst;
        }
    }
}