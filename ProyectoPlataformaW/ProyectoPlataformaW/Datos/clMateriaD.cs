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
        public List<clEntidadMateriaE> mtdListarMateria()
        {
            string sql = "select * from Materia";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblMateria = new DataTable();
            tblMateria = objSql.mtdDesconectado(sql);

            List<clEntidadMateriaE> listaMat = new List<clEntidadMateriaE>();

            for (int i = 0; i < tblMateria.Rows.Count; i++)
            {
                clEntidadMateriaE objMat = new clEntidadMateriaE();

                objMat.IdMateria = int.Parse(tblMateria.Rows[i][0].ToString());
                objMat.NombreMateria = tblMateria.Rows[i][1].ToString();
                objMat.NivelAcademico = tblMateria.Rows[i][2].ToString();
               
               
                listaMat.Add(objMat);


            }

            return listaMat;
        }
    }
}