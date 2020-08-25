using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadAnunciosE
    {
        public int IdAnuncio { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Archivos { get; set; }
        public int IdAdministrador { get; set; }
        public int IdProfesor { get; set; }
    }
}