using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadForoE
    {
        public int IdForo { get; set; }
        public string Titulo { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public string Archivo { get; set; }
        public string Tipo { get; set; }
        public int IdActividad { get; set; }

    }
}