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

        //por modificar login
        public List<clEstudianteE> mtdListar(clEstudianteE objest)
        {
            string consulta = "SELECT Estudiante.idEstudiante, Estudiante.Contrasena, Estudiante.Email FROM Estudiante WHERE (Estudiante.Contrasena = '" + objest.Contraseña + "') AND (Estudiante.Email = '" + objest.Email + "')";
            clConexion objconexion = new clConexion();

            DataTable tblDatos = new DataTable();
            tblDatos = objconexion.mtdDesconectado(consulta);

            List<clEstudianteE> listaEstudiante = new List<clEstudianteE>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clEstudianteE objPasDatos = new clEstudianteE();
                objPasDatos.idEstudiante = int.Parse(tblDatos.Rows[i][0].ToString());
                objPasDatos.Contraseña = tblDatos.Rows[i][1].ToString();
                objPasDatos.Email = tblDatos.Rows[i][2].ToString();


                listaEstudiante.Add(objPasDatos);
            }
            return listaEstudiante;

        }




    }

}