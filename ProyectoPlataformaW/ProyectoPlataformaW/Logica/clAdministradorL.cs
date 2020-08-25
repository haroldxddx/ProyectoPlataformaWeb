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

        public List<clEntidadAdministradorE> mtdListAdm()
        {
            clAdministradorD objProff = new clAdministradorD();
            List<clEntidadAdministradorE> listA = new List<clEntidadAdministradorE>();
            listA = objProff.mtdListarAdmin();
            return listA;
        }

        public int mtdENom(clEntidadAdministradorE objE)
        {
            clAdministradorD e = new clAdministradorD();
            int ed = e.mtdEditarNom(objE);
            return ed;

        }

        public int mtdEAp(clEntidadAdministradorE objE)
        {
            clAdministradorD e = new clAdministradorD();
            int ed = e.mtdEditarAp(objE);
            return ed;

        }

        public int mtdEDoc(clEntidadAdministradorE objE)
        {
            clAdministradorD e = new clAdministradorD();
            int ed = e.mtdEditarDoc(objE);
            return ed;

        }

        public int mtdEemail(clEntidadAdministradorE objE)
        {
            clAdministradorD e = new clAdministradorD();
            int ed = e.mtdEditarEmail(objE);
            return ed;

        }

        public int mtdCambiarC(clEntidadAdministradorE objE)
        {
            clAdministradorD e = new clAdministradorD();
            int ed = e.mtdEditarCo(objE);
            return ed;

        }
        public List<clEntidadAdministradorE> mtdDatosEstu(clEntidadAdministradorE objDatos)
        {
            clAdministradorD objEs = new clAdministradorD();
            List<clEntidadAdministradorE> listaEst = new List<clEntidadAdministradorE>();
            listaEst = objEs.mtdDatosE(objDatos);
            return listaEst;
        }
    }
}