using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clCursoMateriaL
    {
        public List<clEntidadCursoMateriaE> mtdCursosP(clEntidadCursoMateriaE objprofe)
        
        {
            clCursoMateriaD objCm = new clCursoMateriaD();
            clCursoMateriaD objCum = new clCursoMateriaD();
            List<clEntidadCursoMateriaE> listaCurM = new List<clEntidadCursoMateriaE>();
            listaCurM = objCm.mtdListCursoP(objprofe);
            
            return listaCurM;
        }

        public List<clEntidadCursoMateriaE> mtdMateriasP(clEntidadEstudianteE objE)
        {
            clCursoMateriaD objCm = new clCursoMateriaD();
            List<clEntidadCursoMateriaE> listaCurM = new List<clEntidadCursoMateriaE>();
            listaCurM = objCm.mtdListMateriasE(objE);
            return listaCurM;
        }
        public List<clEntidadProfesorCursoMateriaE> mtdBuscarMC (clEntidadProfesorCursoMateriaE objCm)
        {
            clCursoMateriaD objCum = new clCursoMateriaD();
            List<clEntidadProfesorCursoMateriaE> listaCurM = new List<clEntidadProfesorCursoMateriaE>();
            listaCurM = objCum.mtdBuscarrMatProfCurso(objCm);
            return listaCurM;
        }
        public List<clEntidadProfesorCursoMateriaE> mtdListarMC()
        {
            clCursoMateriaD objCum = new clCursoMateriaD();
            List<clEntidadProfesorCursoMateriaE> listaCurM = new List<clEntidadProfesorCursoMateriaE>();
            listaCurM = objCum.mtdListarMatProfCurso();
            return listaCurM;
        }

        public List<clEntidadActividadEstuE> mtdListEstudiantesActivi(clEntidadActividadEstuE objE)
        {
            clCursoMateriaD objCm = new clCursoMateriaD();
            List<clEntidadActividadEstuE> listaEstAc = new List<clEntidadActividadEstuE>();
            listaEstAc = objCm.mtdMostrarEst(objE);
            return listaEstAc;
        }

    }
}