using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clCursoR
    {
        public int mtdRegistrarCurso (clEntidadCurso objECurso)
        {
            string sqlInsert = "Insert into Curso (Grado,Curso)" +
                 "values('" + objECurso.Grado + "' , '" + objECurso.Curso + "' )";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;



        }
    }
}