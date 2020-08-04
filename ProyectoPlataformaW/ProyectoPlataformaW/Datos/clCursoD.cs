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
        public List<clEntidadCursosE> mtdListarCurso()
        {
            string sql = "select * from Curso";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblcurso = new DataTable();
            tblcurso = objSql.mtdDesconectado(sql);

            List<clEntidadCursosE> listaCur = new List<clEntidadCursosE>();

            for (int i = 0; i < tblcurso.Rows.Count; i++)
            {
                clEntidadCursosE objCurs = new clEntidadCursosE();

                objCurs.IdCurso = int.Parse(tblcurso.Rows[i][0].ToString());
                objCurs.Grado = tblcurso.Rows[i][1].ToString();
                objCurs.Curso = tblcurso.Rows[i][2].ToString();


                listaCur.Add(objCurs);

            }

            return listaCur;


        }
    }
}