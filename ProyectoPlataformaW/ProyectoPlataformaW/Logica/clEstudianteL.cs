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


        public List<clEntidadEstudianteE> mtdListadoComEs()
        {
            clEstudianteD objEst = new clEstudianteD();
            List<clEntidadEstudianteE> listaE = new List<clEntidadEstudianteE>();
            listaE = objEst.mtdListadoCompletoE();
            return listaE;

        }

        public List<clEntidadEstudianteE> mtdBuscarEstu(clEntidadEstudianteE objDatos)
        {
            clEstudianteD objEs = new clEstudianteD();
            List<clEntidadEstudianteE> listaEst = new List<clEntidadEstudianteE>();
            listaEst = objEs.mtdBuscarPorNom(objDatos);
            return listaEst;
        }

        public List<clEntidadEstudianteE> mtdFiltroE(clEntidadEstudianteE objDatos)
        {
            clEstudianteD objE = new clEstudianteD();
            List<clEntidadEstudianteE> listaEs = new List<clEntidadEstudianteE>();
            listaEs = objE.mtdFiltroCurso(objDatos);
            return listaEs;
        }

        public int mtdEdit(clEntidadEstudianteE objE)
        {
            clEstudianteD e = new clEstudianteD();
            int ed = e.mtdActualizarInfo(objE);
            return ed;

        }

        public int mtdCambiarC(clEntidadEstudianteE objE)
        {
            clEstudianteD e = new clEstudianteD();
            int ed = e.mtdCambiarCo(objE);
            return ed;

        }

    }
}