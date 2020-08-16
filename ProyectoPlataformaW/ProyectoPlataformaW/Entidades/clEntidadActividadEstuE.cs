using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadActividadEstuE
    {
        public int IdCursoMateria { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Descripcion { get; set; }
        public string NombreMateria { get; set; }
        public string Curso { get; set; }
        public int IdActividad { get; set; }
        public int IdEstudiante { get; set; }
    }
}