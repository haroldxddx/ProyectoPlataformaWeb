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

        //Recuperacion de contraseña
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

        //Listado Completo de estudiantes

        public List<clEntidadEstudiante> mtdListadoCompletoE()
        {
            string sql = "select Estudiante.Nombres,Estudiante.Apellidos,Estudiante.Documento,Estudiante.Email,Curso.Grado,Curso.Curso from Estudiante INNER JOIN Curso ON Estudiante.IdCurso = Curso.IdCurso";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudiante> listaEstud = new List<clEntidadEstudiante>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudiante objEstu = new clEntidadEstudiante();

                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][2].ToString());
                objEstu.Email = tblEstud.Rows[i][3].ToString();
                objEstu.Grado = tblEstud.Rows[i][4].ToString();
                objEstu.Curso = tblEstud.Rows[i][5].ToString();

                listaEstud.Add(objEstu);

            }

            return listaEstud;


        }

        //Busqueda de estudiante por nombre
        public List<clEntidadEstudiante> mtdBuscarPorNom(clEntidadEstudiante objEstud)
        {
            string sql = "select Estudiante.Nombres,Estudiante.Apellidos,Estudiante.Documento,Estudiante.Email,Curso.Grado,Curso.Curso from Estudiante INNER JOIN Curso ON Estudiante.IdCurso = Curso.IdCurso WHERE (Estudiante.Nombres LIKE '%" + objEstud.Nombres + "%')";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudiante> listaEstud = new List<clEntidadEstudiante>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudiante objEstu = new clEntidadEstudiante();

                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][2].ToString());
                objEstu.Email = tblEstud.Rows[i][3].ToString();
                objEstu.Grado = tblEstud.Rows[i][4].ToString();
                objEstu.Curso = tblEstud.Rows[i][5].ToString();

                listaEstud.Add(objEstu);

            }

            return listaEstud;


        }


        //Filtro de estudiantes por curso
        public List<clEntidadEstudiante> mtdFiltroCurso(clEntidadEstudiante objEstud)
        {
            string sql = "select Estudiante.Nombres,Estudiante.Apellidos,Estudiante.Documento,Estudiante.Email,Curso.Grado,Curso.Curso from Estudiante INNER JOIN Curso ON Estudiante.IdCurso = Curso.IdCurso WHERE Curso.Curso = '"+ objEstud.Curso +"'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudiante> listaEstud = new List<clEntidadEstudiante>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudiante objEstu = new clEntidadEstudiante();

                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][2].ToString());
                objEstu.Email = tblEstud.Rows[i][3].ToString();
                objEstu.Grado = tblEstud.Rows[i][4].ToString();
                objEstu.Curso = tblEstud.Rows[i][5].ToString();

                listaEstud.Add(objEstu);

            }

            return listaEstud;


        }



    }

}