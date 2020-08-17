using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clCursoD
    {
            public int mtdRegistrarCurso(ClEntidadCursosE objECurso)
            {
                string sqlInsert = "Insert into Curso (Grado,Curso)" +
                     "values('" + objECurso.Grado + "' , '" + objECurso.Curso + "' )";

                clAdminSQL objSQL = new clAdminSQL();
                int result = objSQL.mtdConectado(sqlInsert);
                return result;



            }
        public List<ClEntidadCursosE> mtdListarCurso()
        {
            string sql = "select * from Curso";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblcurso = new DataTable();
            tblcurso = objSql.mtdDesconectado(sql);

            List<ClEntidadCursosE> listaCur = new List<ClEntidadCursosE>();

            for (int i = 0; i < tblcurso.Rows.Count; i++)
            {
                ClEntidadCursosE objCurs = new ClEntidadCursosE();

                objCurs.IdCurso = int.Parse(tblcurso.Rows[i][0].ToString());
                objCurs.Grado = tblcurso.Rows[i][1].ToString();
                objCurs.Curso = tblcurso.Rows[i][2].ToString();
                listaCur.Add(objCurs);


            }

            return listaCur;
        }
            public List<clEntidadACursoMateriaE> mtdListarCursos()
            {
                string sql = "select Grado,Curso from Curso";
                clAdminSQL objSql = new clAdminSQL();
                DataTable tblcurso = new DataTable();
                tblcurso = objSql.mtdDesconectado(sql);

                List<clEntidadACursoMateriaE> listaCurs = new List<clEntidadACursoMateriaE>();

                for (int i = 0; i < tblcurso.Rows.Count; i++)
                {
                clEntidadACursoMateriaE objCurs = new clEntidadACursoMateriaE();

              
                    objCurs.Grado = tblcurso.Rows[i][0].ToString();
                    objCurs.Curso = tblcurso.Rows[i][1].ToString();
                    listaCurs.Add(objCurs);


                }

                return listaCurs;


            }
        }
     
    }
