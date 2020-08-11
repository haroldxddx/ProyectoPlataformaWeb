using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadActividadE
    {
        public int IdActividad { get; set; }
        public string NombreActividad { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Descripcion { get; set; }
        public string Archivos { get; set; }
        public int IdCursoMateria { get; set; }
    }
}