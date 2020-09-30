using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadParticipacionE
    {
        public int IdParticipacion { get; set; }
        public string Fecha { get; set; }
        public string Comentario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdEstudiante { get; set; }
        public int IdForo { get; set; }
        public int IdProfesor { get; set; }
    }
}