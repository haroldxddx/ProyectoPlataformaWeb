using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clEstudianteR
    {
        public int mtdRegistrarEstudiante (clEntidadEstudianteT objEst)
        {
            string sqlInsert = "insert into Estudiante (Nombres,Apellidos,Documento,Email,Contrasena,IdCurso)" +
                "values('" + objEst.Nombres + "' , '" + objEst.Apellidos + "' , " + objEst.Documento + " , '" + objEst.Email + "' , '" + objEst.Contrasena + "' , " + objEst.IdCurso + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }
    }
}