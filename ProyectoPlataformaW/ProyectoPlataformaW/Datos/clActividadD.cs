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

        /*select Estudiante.Nombres , Estudiante.Apellidos, Actividad.Descripcion , Materia.NombreMateria , Curso.Curso
from Estudiante
inner join CursoMateria
on Estudiante.IdCurso= CursoMateria.IdCurso
inner join Actividad
on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria
inner join Materia
on Materia.IdMateria= CursoMateria.IdMateria
inner join Curso
on Curso.IdCurso = CursoMateria.IdCurso
where CursoMateria.IdCursoMateria = '1' and Actividad.NombreActividad = 'Proyecto'*/
    }
}