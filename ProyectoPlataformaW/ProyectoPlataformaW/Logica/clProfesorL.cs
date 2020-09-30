using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clProfesorL
    {
        public List<clProfesorEEE> mtdNomProfe(clProfesorEEE objjaas)
        {
            clProfesorD objProff = new clProfesorD();
            List<clProfesorEEE> listP = new List<clProfesorEEE>();
            listP = objProff.mtdNombrePro(objjaas);
            return listP;
        }

        public List<clEntidadProfesorE> mtdListarApb1(clEntidadProfesorE objDatos)
        {
            clProfesorD objAsA = new clProfesorD();
            List<clEntidadProfesorE> listaApb1 = new List<clEntidadProfesorE>();
            listaApb1 = objAsA.mtdListarlogin(objDatos);
            return listaApb1;
        }

        public List<clProfesorEEE> mtdListProf()
        {
            clProfesorD objProff = new clProfesorD();
            List<clProfesorEEE> listP = new List<clProfesorEEE>();
            listP = objProff.mtdListarProf();
            return listP;
        }

        public List<clProfesorEEE> mtdBuscarProf(clProfesorEEE objProf)
        {
            clProfesorD objProff = new clProfesorD();
            List<clProfesorEEE> listP = new List<clProfesorEEE>();
            listP = objProff.mtdBuscarProf(objProf);
            return listP;
        }
        public List<clEntidadProfesorEE> mtdListProfe()
        {
            clProfesorD objProfe = new clProfesorD();
            List<clEntidadProfesorEE> listP = new List<clEntidadProfesorEE>();
            listP = objProfe.mtdListarProfe();
            return listP;
        }

        public int mtdENomP(clEntidadProfesorE objPr)
        {
            clProfesorD p = new clProfesorD();
            int pro = p.mtdEditarNomP(objPr);
            return pro;

        }

        public int mtdEApellP(clEntidadProfesorE objPr)
        {
            clProfesorD p = new clProfesorD();
            int pro = p.mtdEditarApellidoP(objPr);
            return pro;

        }

        public int mtdEDocuP(clEntidadProfesorE objPr)
        {
            clProfesorD p = new clProfesorD();
            int pro = p.mtdEditarDocP(objPr);
            return pro;

        }

        public int mtdEemailP(clEntidadProfesorE objPr)
        {
            clProfesorD p = new clProfesorD();
            int pro = p.mtdEditarEmaP(objPr);
            return pro;

        }
        public int mtdEespeP(clEntidadProfesorE objPr)
        {
            clProfesorD p = new clProfesorD();
            int pro = p.mtdEditarEspecialidadP(objPr);
            return pro;

        }

        public int mtdEcoP(clEntidadProfesorE objPr)
        {
            clProfesorD p = new clProfesorD();
            int pro = p.mtdEditarContP(objPr);
            return pro;

        }
        public List<clEntidadProfesorE> mtdDatosEstu(clEntidadProfesorE objDatos)
        {
            clProfesorD objEs = new clProfesorD();
            List<clEntidadProfesorE> listaEst = new List<clEntidadProfesorE>();
            listaEst = objEs.mtdDatosProf(objDatos);
            return listaEst;
        }
    }
}