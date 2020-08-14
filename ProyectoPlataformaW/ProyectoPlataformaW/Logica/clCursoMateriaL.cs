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
        public List<clEntidadCursoMateriaE> mtdCursosP()
        {
            clCursoMateriaD objCum = new clCursoMateriaD();
            List<clEntidadCursoMateriaE> listaCurM = new List<clEntidadCursoMateriaE>();
            listaCurM = objCum.mtdListCursoP();
            return listaCurM;
        }

        public List<clEntidadCursoMateriaE> mtdMateriasP(clEntidadEstudianteE objE)
        {
            clCursoMateriaD objCm = new clCursoMateriaD();
            List<clEntidadCursoMateriaE> listaCurM = new List<clEntidadCursoMateriaE>();
            listaCurM = objCm.mtdListMateriasE(objE);
            return listaCurM;
        }
       
    }
}