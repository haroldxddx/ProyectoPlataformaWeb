using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class EntidadEstudianteXlsx
    {
        public int IdEstudiante { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Documento { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public int IdCurso { get; set; }

    }
}