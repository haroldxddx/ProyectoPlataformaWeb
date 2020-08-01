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

       public List<clEntidadEstudiante> mtdListar()
        {
            string sql = "select Email,Contrasena from Estudiante" ;
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudiante> listaEstud = new List<clEntidadEstudiante>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudiante objEstu = new clEntidadEstudiante();
                objEstu.Email = tblEstud.Rows[i][0].ToString();
                objEstu.Contrasena = tblEstud.Rows[i][1].ToString();

                listaEstud.Add(objEstu);

            }

            return listaEstud;
      
        
        }

        //por modificar login
        public List<clEntidadEstudiante> mtdListarlogin(clEntidadEstudiante objest)
        {
            string consulta = "SELECT Estudiante.idEstudiante, Estudiante.Contrasena, Estudiante.Email FROM Estudiante WHERE (Estudiante.Contrasena = '" + objest.Contrasena + "') AND (Estudiante.Email = '" + objest.Email + "')";
            
            clAdminSQL objAdmin = new clAdminSQL();

            DataTable tblDatos = new DataTable();
            tblDatos = objAdmin.mtdDesconectado(consulta);

            List<clEntidadEstudiante> listaEstudiante = new List<clEntidadEstudiante>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clEntidadEstudiante objPasDatos = new clEntidadEstudiante();
                objPasDatos.IdEstudiante = int.Parse(tblDatos.Rows[i][0].ToString());
                objPasDatos.Contrasena = tblDatos.Rows[i][1].ToString();
                objPasDatos.Email = tblDatos.Rows[i][2].ToString();


                listaEstudiante.Add(objPasDatos);
            }
            return listaEstudiante;

        }




    }

}