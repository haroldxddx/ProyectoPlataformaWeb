using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clProfesorR
    {
        public int mtdRegistrarProfesor (clEntidadProfesor objProfe)
        {
            string sqlInsert = "insert into Profesor (Nombres,Apellidos,Documento,Email,Contrasena,Especialidad)" +
                "values('" + objProfe.Nombres + "' , '" + objProfe.Apellidos + "' , " + objProfe.Documento + " , '" + objProfe.Email + "' , '" + objProfe.Contrasena + "' , '" + objProfe.Especialidad + "')";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }
    }
}