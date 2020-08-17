using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clCursoL
    {
        public List<ClEntidadCursosE> mtdComboCur()
        {
            clCursoD objCur = new clCursoD();
            List<ClEntidadCursosE> listC = new List<ClEntidadCursosE>();
            listC = objCur.mtdListarCurso();
            return listC;
        }

        public List<ClEntidadCursosE> mtdListarCur()
        {
            clCursoD objCurs = new clCursoD();
            List<ClEntidadCursosE> listCu = new List<ClEntidadCursosE>();
            listCu = objCurs.mtdListarCurso();
            return listCu;
        }
       /* public List<clEntidadACursoMateriaE> mtdListarCurso()
        {
            clCursoD objCurs = new clCursoD();
            List<clEntidadACursoMateriaE> listCu = new List<clEntidadACursoMateriaE>();
            listCu = objCurs.mtdListarCursos();
            return listCu;
        }*/
    }
}