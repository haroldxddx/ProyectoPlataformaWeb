using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadEntregaE
    {
        public int IdEntrega { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string Archivos { get; set; }
        public string Nota { get; set; }
        public string Estado { get; set; }
        public int IdActividad { get; set; }
        public int IdEstudiante { get; set; }
        public string Vinculo { get; set; }
        public string otraRespuesta { get; set; }
        public string Comentario { get; set; }
    }
}