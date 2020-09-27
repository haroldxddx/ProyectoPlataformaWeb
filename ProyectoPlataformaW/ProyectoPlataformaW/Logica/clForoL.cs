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
    }
}