using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clCursoMateriaD
    {
        public int mtdAsignarCursoMateria(clEntidadCursoMateriaE objCurMat)
        {
            string sqlInsert = "insert into CursoMateria values(" + objCurMat.IdCurso + " , " + objCurMat.IdMateria + " , " + objCurMat.IdProfesor + " )";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }

    }
}