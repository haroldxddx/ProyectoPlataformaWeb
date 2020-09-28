using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoPlataformaW.Datos;
namespace ProyectoPlataformaW.Logica
{
    public class clEstudianteL
    {

        //List<clEstudianteE> listaEstudiante = new List<clEstudianteE>();

        public List<clEntidadEstudianteE> mtdListarApb1(clEntidadEstudianteE objDatos)
        {
            clEstudianteD objAsA = new clEstudianteD();
            List<clEntidadEstudianteE> listaApb1 = new List<clEntidadEstudianteE>();
            listaApb1 = objAsA.mtdListarlogin(objDatos);
            return listaApb1;
        }

        public List<clEntidadEstudianteE> mtdRecup()
        {
            clEstudianteD objEstu = new clEstudianteD();
            List<clEntidadEstudianteE> listE = new List<clEntidadEstudianteE>();
            listE = objEstu.mtdListar();
            return listE;
        }


        public List<clEstudianteEEE> mtdListadoComEs()
        {
            clEstudianteD objEst = new clEstudianteD();
            List<clEstudianteEEE> listaE = new List<clEstudianteEEE>();
            listaE = objEst.mtdListadoCompletoE();
            return listaE;

        }

        public List<clEstudianteEEE> mtdBuscarEstu(clEstudianteEEE objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEstudianteEEE> listaEst = new List<clEstudianteEEE>();
            listaEst = objEs.mtdBuscarPorNom(objDatos);
            return listaEst;
        }
        public List<clEntidadEstudianteEE> mtdBuscarEst(clEntidadEstudianteEE objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEntidadEstudianteEE> listaEst = new List<clEntidadEstudianteEE>();
            listaEst = objEs.mtdBuscarEst(objDatos);
            return listaEst;
        }

        public List<clEstudianteEEE> mtdFiltroE(clEntidadEstudianteE objDatos)
        {
            clEstudianteD objE = new clEstudianteD();
            List<clEstudianteEEE> listaEs = new List<clEstudianteEEE>();
            listaEs = objE.mtdFiltroCurso(objDatos);
            return listaEs;
        }

        public int mtdENom(clEntidadEstudianteE objE)
        {
            clEstudianteD e = new clEstudianteD();
            int ed = e.mtdEditarNom(objE);
            return ed;

        }

        public int mtdEAp(clEntidadEstudianteE objE)
        {
            clEstudianteD e = new clEstudianteD();
            int ed = e.mtdEditarAp(objE);
            return ed;

        }

        public int mtdEDoc(clEntidadEstudianteE objE)
        {
            clEstudianteD e = new clEstudianteD();
            int ed = e.mtdEditarDoc(objE);
            return ed;

        }

        public int mtdEemail(clEntidadEstudianteE objE)
        {
            clEstudianteD e = new clEstudianteD();
            int ed = e.mtdEditarEmail(objE);
            return ed;

        }

        public int mtdCambiarC(clEntidadEstudianteE objE)
        {
            clEstudianteD e = new clEstudianteD();
            int ed = e.mtdCambiarCo(objE);
            return ed;

        }


        public List<clEntidadEstudianteE> mtdListaridEst(clEntidadEstudianteE objDatos)
        {
            clEstudianteD objAsA = new clEstudianteD();
            List<clEntidadEstudianteE> listaApb1 = new List<clEntidadEstudianteE>();
            listaApb1 = objAsA.mtdBusEEmaiL(objDatos);
            return listaApb1;
        }

        public List<clEntidadEstudianteE> mtdDatosEstu(clEntidadEstudianteE objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEntidadEstudianteE> listaEst = new List<clEntidadEstudianteE>();
            listaEst = objEs.mtdDatosE(objDatos);
            return listaEst;
        }

        public List<clEntidadEstudianteEE> mtdDatosEstuProf(ClEntidadCursosE objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEntidadEstudianteEE> listaEst = new List<clEntidadEstudianteEE>();
            listaEst = objEs.mtdDatosEstuP(objDatos);
            return listaEst;
        }

        public List<clEntidadEstudianteEE> mtdCorreoMasivo(clEntidadCursoMateriaE objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEntidadEstudianteEE> listaEst = new List<clEntidadEstudianteEE>();
            listaEst = objEs.mtdCorreos(objDatos);
            return listaEst;
        }

        public List<clEntidadEstudianteE> mtdInformeNotas(clEntidadEstudianteE objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEntidadEstudianteE> listaEst = new List<clEntidadEstudianteE>();
            listaEst = objEs.mtdInforme(objDatos);
            return listaEst;
        }
    }
}