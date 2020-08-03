using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clProfesorD
    {
        public List<clEntidadProfesorE> mtdListarProf()
        {
            string sql = "select Nombres,Apellidos,Documento,Email,Especialidad from Profesor";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblprof = new DataTable();
            tblprof = objSql.mtdDesconectado(sql);

            List<clEntidadProfesorE> listaProf = new List<clEntidadProfesorE>();

            for (int i = 0; i < tblprof.Rows.Count; i++)
            {
                clEntidadProfesorE objProf = new clEntidadProfesorE();
               
                
                objProf.Nombres = tblprof.Rows[i][0].ToString();
                objProf.Apellidos = tblprof.Rows[i][1].ToString();
                objProf.Documento = int.Parse(tblprof.Rows[i][2].ToString());
                objProf.Email = tblprof.Rows[i][3].ToString();
                objProf.Especialidad = tblprof.Rows[i][4].ToString();



                listaProf.Add(objProf);

            }

            return listaProf;


        }
    }
}