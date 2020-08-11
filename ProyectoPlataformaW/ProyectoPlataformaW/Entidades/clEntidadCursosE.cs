using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class ClEntidadCursosE:clEntidadProfesorE
    {
        public int IdCurso { get; set; }
        public string Grado { get; set; }
        public string Curso { get; set; }

    }
}