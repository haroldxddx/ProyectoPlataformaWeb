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

        public List<clEntidadEstudiante> mtdListarApb1(clEntidadEstudiante objDatos)
        {
            clEstudianteD objAsA = new clEstudianteD();
            List<clEntidadEstudiante> listaApb1 = new List<clEntidadEstudiante>();
            listaApb1 = objAsA.mtdListarlogin(objDatos);
            return listaApb1;
        }

        public List<clEntidadEstudiante> mtdRecup()
        {
            clEstudianteD objEstu = new clEstudianteD();
            List<clEntidadEstudiante> listE = new List<clEntidadEstudiante>();
            listE = objEstu.mtdListar();
            return listE;
        }


        public List<clEntidadEstudiante> mtdListadoComEs()
        {
            clEstudianteD objEst = new clEstudianteD();
            List<clEntidadEstudiante> listaE = new List<clEntidadEstudiante>();
            listaE = objEst.mtdListadoCompletoE();
            return listaE;

        }

        public List<clEntidadEstudiante> mtdBuscarEstu(clEntidadEstudiante objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEntidadEstudiante> listaEst = new List<clEntidadEstudiante>();
            listaEst = objEs.mtdBuscarPorNom(objDatos);
            return listaEst;
        }

        public List<clEntidadEstudiante> mtdFiltroE(clEntidadEstudiante objDatos)
        {
            clEstudianteD objE = new clEstudianteD();
            List<clEntidadEstudiante> listaEs = new List<clEntidadEstudiante>();
            listaEs = objE.mtdFiltroCurso(objDatos);
            return listaEs;
        }

    }
}