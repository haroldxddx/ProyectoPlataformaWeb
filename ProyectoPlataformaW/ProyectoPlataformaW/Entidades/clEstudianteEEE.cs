using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEstudianteEEE
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Documento { get; set; }
        public string Email { get; set; }
        public string Grado { get; set; }
        public string Curso { get; set; }
    }
}