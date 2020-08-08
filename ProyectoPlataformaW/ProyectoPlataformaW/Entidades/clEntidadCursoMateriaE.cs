using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadCursoMateriaE:clEntidadCursosE
    {
        public int IdCursoMateria { get; set; }
        public int IdCurso { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
    }
}