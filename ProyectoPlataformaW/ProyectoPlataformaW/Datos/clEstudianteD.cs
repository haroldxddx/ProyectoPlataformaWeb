using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clEstudianteD
    {

        public List<clEntidadEstudiante> mtdListar(clEntidadEstudiante objEs)
        {
            string sql = "select Contrasena from Estudiante where Email = "+ objEs.Email;
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudiante> listaEstud = new List<clEntidadEstudiante>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudiante objEstu = new clEntidadEstudiante();
                objEstu.Email = tblEstud.Rows[i][4].ToString();
                objEstu.Contrasena = tblEstud.Rows[i][5].ToString();

            }

            return listaEstud;
        }
    }
}