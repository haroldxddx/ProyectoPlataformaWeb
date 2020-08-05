using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clAdministradorR
    {
        public int mtdRegistrarAdministrador(clEntidadAdministrador objAdmin)
        {
            string sqlInsert = "insert into Administradores (Nombres,Apellidos,Documento,Email,Contrasena,Tipo)" +
                "values('" + objAdmin.Nombres + "' , '" + objAdmin.Apellidos + "' , " + objAdmin.Documento + " , '" + objAdmin.Email + "' , '" + objAdmin.Contrasena + "' , '" + objAdmin.Tipo + "')";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }
    }
}