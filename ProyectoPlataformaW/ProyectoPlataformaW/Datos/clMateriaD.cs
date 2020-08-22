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
            string sql = "select IdMateria,NombreMateria, NivelAcademico from Materia";
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

        //Cargar Combo Materia Asignada A Curso-Materia
        public List<clNotasEstudE> mtdComboMateria(clNotasEstudE objNot)
        {
            string sql = "select Materia.NombreMateria, CursoMateria.IdCursoMateria from Materia inner join CursoMateria ON Materia.IdMateria = CursoMateria.IdMateria inner join Curso on Curso.IdCurso = CursoMateria.IdCurso where Curso.IdCurso = '"+ objNot.IdCurso + "'";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblMateria = new DataTable();
            tblMateria = objSql.mtdDesconectado(sql);

            List<clNotasEstudE> listaMat = new List<clNotasEstudE>();

            for (int i = 0; i < tblMateria.Rows.Count; i++)
            {
                clNotasEstudE objMat = new clNotasEstudE();

                
                objMat.NombreMateria = tblMateria.Rows[i][0].ToString();
                objMat.IdCursoMateria = int.Parse(tblMateria.Rows[i][1].ToString());



                listaMat.Add(objMat);


            }

            return listaMat;
        }
    }
}