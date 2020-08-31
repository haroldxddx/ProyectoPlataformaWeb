using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadNotas
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreActividad { get; set; }
        public string Descripcion { get; set; }
        public string Nota { get; set; }
        public int IdCursoMateria { get; set; }
        public int IdEstudiante { get; set; }

    }
}