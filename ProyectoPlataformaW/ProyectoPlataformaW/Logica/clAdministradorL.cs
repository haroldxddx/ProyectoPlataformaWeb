using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Datos;

namespace ProyectoPlataformaW.Logica
{
    public class clAdministradorL
    {

        public int mtdEnvioDatos(clEntidadAdministradorE objDatos)
        {
            clAdministradorD objAdministradorD = new clAdministradorD();
            int regi = objAdministradorD.mtdRegistrar(objDatos);
            return regi;
        }




        public List<clEntidadAdministradorE> mtdListarApb1(clEntidadAdministradorE objDatos)
        {
            clAdministradorD objAsA = new clAdministradorD();
            List<clEntidadAdministradorE> listaApb1 = new List<clEntidadAdministradorE>();
            listaApb1 = objAsA.mtdListarlogin(objDatos);
            return listaApb1;
        }


    }
}