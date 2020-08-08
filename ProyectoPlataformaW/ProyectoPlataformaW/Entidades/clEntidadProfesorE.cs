using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadProfesorE:clEntidadMateriaE
    {
      
        public int idProfesor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Documento { get; set; }
        public string Email { get; set; }
        public string Especialidad { get; set; }
        public string Contrasena { get; set; }


    }
}