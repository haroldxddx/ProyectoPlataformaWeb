using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clMateriaR
    {
     
            public int mtdRegistrarMateria(clEntidadMateria objEMateria)
            {
                string sqlInsert = "Insert into Materia (NombreMateria,NivelAcademico)" +
                     "values('" + objEMateria.NombreMateria + "' , '" + objEMateria.NivelAcademico + "' )";

                clAdminSQL objSQL = new clAdminSQL();
                int result = objSQL.mtdConectado(sqlInsert);
                return result;



            }
        }
}