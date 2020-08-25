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
    }
}