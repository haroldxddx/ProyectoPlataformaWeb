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
        public List<clEntidadProfesorE> mtdListProf()
        {
            clProfesorD objProf = new clProfesorD();
            List<clEntidadProfesorE> listP = new List<clEntidadProfesorE>();
            listP = objProf.mtdListarProf();
            return listP;
        }

    }
}