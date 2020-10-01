using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadProfesorEE
    {
        public int IdProfesor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Especialidad { get; set; }

        public int Documento { get; set; }
        public string Email { get; set; }
    }
}