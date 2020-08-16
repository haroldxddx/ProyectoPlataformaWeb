using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clMateriaD
    {
     
     public int mtdRegistrarMateria(clEntidadMateriaE objEMateria)
            {
                string sqlInsert = "Insert into Materia (NombreMateria,NivelAcademico)" +
                     "values('" + objEMateria.NombreMateria + "' , '" + objEMateria.NivelAcademico + "' )";

                clAdminSQL objSQL = new clAdminSQL();
                int result = objSQL.mtdConectado(sqlInsert);
                return result;

            }
        public List<clEntidadACursoMateriaE> mtdListarMateria()
        {
            string sql = "select NombreMateria, NivelAcademico from Materia";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblMateria = new DataTable();
            tblMateria = objSql.mtdDesconectado(sql);

            List<clEntidadACursoMateriaE> listaMat = new List<clEntidadACursoMateriaE>();

            for (int i = 0; i < tblMateria.Rows.Count; i++)
            {
                clEntidadACursoMateriaE objMat = new clEntidadACursoMateriaE();
    
                objMat.NombreMateria = tblMateria.Rows[i][0].ToString();
                objMat.NivelAcademico = tblMateria.Rows[i][1].ToString();
               
               
                listaMat.Add(objMat);


            }

            return listaMat;
        }
    }
}