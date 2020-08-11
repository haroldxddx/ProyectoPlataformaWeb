using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clActividadD
    {
        public int mtdAsignarActividad(clEntidadActividadE objAct)
        {
            string sqlInsert = "insert into Actividad(NombreActividad,FechaInicio,FechaFinal,Descripcion,Archivos,IdCursoMateria)" +
                "values('" + objAct.NombreActividad + "' , '" + objAct.FechaInicio + "' , " + objAct.FechaFinal + " , '" + objAct.Descripcion + "' , '" + objAct.Archivos + "' , " + objAct.IdCursoMateria + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }
    }
}