using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace ProyectoPlataformaW.Entidades
{
    public class clEntidadAdministrador
    {
        public int IdAdministrador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Documento { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string Tipo { get; set; }
    }
}