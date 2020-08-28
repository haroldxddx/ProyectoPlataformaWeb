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
        public static int idestu;
        public static int idEstudiante;
        public static int idCurso;
        public int mtdRegistrarEstudiante(clEntidadEstudianteE objEst)
        {
            string sqlInsert = "insert into Estudiante (Nombres,Apellidos,Documento,Email,Contrasena,IdCurso)" +
                "values('" + objEst.Nombres + "' , '" + objEst.Apellidos + "' , " + objEst.Documento + " , '" + objEst.Email + "' , '" + objEst.Contrasena + "' , " + objEst.IdCurso + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }

        //Recuperacion de contraseña
        public List<clEntidadEstudianteE> mtdListar()
        {
            string sql = "select Email,Contrasena from Estudiante" ;
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteE> listaEstud = new List<clEntidadEstudianteE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteE objEstu = new clEntidadEstudianteE();
                objEstu.Email = tblEstud.Rows[i][0].ToString();
                objEstu.Contrasena = tblEstud.Rows[i][1].ToString();

                listaEstud.Add(objEstu);

            }

            return listaEstud;
      
        
        }

        // login
        public List<clEntidadEstudianteE> mtdListarlogin(clEntidadEstudianteE objest)
        {
            string consulta = "SELECT Estudiante.idEstudiante, Estudiante.Contrasena, Estudiante.Email FROM Estudiante WHERE (Estudiante.Contrasena = '" + objest.Contrasena + "') AND (Estudiante.Email = '" + objest.Email + "')";
            
            clAdminSQL objAdmin = new clAdminSQL();

            DataTable tblDatos = new DataTable();
            tblDatos = objAdmin.mtdDesconectado(consulta);

            List<clEntidadEstudianteE> listaEstudiante = new List<clEntidadEstudianteE>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clEntidadEstudianteE objPasDatos = new clEntidadEstudianteE();
                objPasDatos.IdEstudiante = int.Parse(tblDatos.Rows[i][0].ToString());
                objPasDatos.Contrasena = tblDatos.Rows[i][1].ToString();
                objPasDatos.Email = tblDatos.Rows[i][2].ToString();


                listaEstudiante.Add(objPasDatos);
            }
            return listaEstudiante;

        }

        //Listado Completo de estudiantes

        public List<clEntidadEstudianteE> mtdListadoCompletoE( )
        {
            string sql = "select Estudiante.Nombres,Estudiante.Apellidos,Estudiante.Documento,Estudiante.Email,Curso.Grado,Curso.Curso from Estudiante INNER JOIN Curso ON Estudiante.IdCurso = Curso.IdCurso";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteE> listaEstud = new List<clEntidadEstudianteE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

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
        public List<clEntidadEstudianteEE> mtdListadoCompletoEE()
        {
            string sql = "select Nombres,Apellidos,Documento,Email from Estudiante";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteEE> listaEstud = new List<clEntidadEstudianteEE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteEE objEstu = new clEntidadEstudianteEE();

                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][2].ToString());
                objEstu.Email = tblEstud.Rows[i][3].ToString();
         

                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

            //Busqueda de estudiante por nombre
            public List<clEntidadEstudianteE> mtdBuscarPorNom(clEntidadEstudianteE objEstud)
        {
            string sql = "select Estudiante.Nombres,Estudiante.Apellidos,Estudiante.Documento,Estudiante.Email,Curso.Grado,Curso.Curso from Estudiante INNER JOIN Curso ON Estudiante.IdCurso = Curso.IdCurso WHERE (Estudiante.Nombres LIKE '%" + objEstud.Nombres + "%')";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteE> listaEstud = new List<clEntidadEstudianteE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

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

       /* select Curso.Curso
from Curso
inner join Estudiante
on Curso.IdCurso = Estudiante.IdCurso
where Email = 'haroldzabala5@gmail.com'*/

        //Filtro de estudiantes por curso
        public List<clEntidadEstudianteE> mtdFiltroCurso(clEntidadEstudianteE objEstud)
        {
            string sql = "select Estudiante.Nombres,Estudiante.Apellidos,Estudiante.Documento,Estudiante.Email,Curso.Grado,Curso.Curso from Estudiante INNER JOIN Curso ON Estudiante.IdCurso = Curso.IdCurso WHERE Curso.IdCurso = '"+ objEstud.IdCurso +"'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteE> listaEstud = new List<clEntidadEstudianteE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

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
        public List<clEntidadEstudianteEE> mtdBuscarEst(clEntidadEstudianteEE objEstud)
        {
            string sql = "select Nombres,Apellidos,Documento,Email from Estudiante WHERE (Estudiante.Nombres LIKE '%" + objEstud.Nombres + "%')";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteEE> listaEstud = new List<clEntidadEstudianteEE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteEE objEstu = new clEntidadEstudianteEE();

                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][2].ToString());
                objEstu.Email = tblEstud.Rows[i][3].ToString();
   

                listaEstud.Add(objEstu);

            }

            return listaEstud;


        }

        //Actualizar Nombre

        public int mtdEditarNom(clEntidadEstudianteE objEst)
        {

            string sql = "UPDATE Estudiante SET Nombres = '" + objEst.Nombres + "' WHERE Email = '"+ objEst.Email +"'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //EDITAR APELLIDO
        public int mtdEditarAp(clEntidadEstudianteE objEst)
        {

            string sql = "UPDATE Estudiante SET Apellidos = '" + objEst.Apellidos + "' WHERE Email = '" + objEst.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //EDITAR DOCUMENTO
        public int mtdEditarDoc(clEntidadEstudianteE objEst)
        {

            string sql = "UPDATE Estudiante SET Documento = '" + objEst.Documento + "' WHERE Email = '" + objEst.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //Editar Email

        public int mtdEditarEmail(clEntidadEstudianteE objEst)
        {

            string sql = "UPDATE Estudiante SET Email = '" + objEst.Email + "' WHERE Documento = '" + objEst.Documento + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        

        //Cambiar Contraseña
        public int mtdCambiarCo(clEntidadEstudianteE objEst)
        {

            string sql = "UPDATE Estudiante SET Contrasena = '"+ objEst.Contrasena +"' WHERE Email = '" + objEst.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        public List<clEntidadEstudianteE> mtdBusEEmaiL(clEntidadEstudianteE objest)
        {
            string sql = "select  Estudiante.idEstudiante,Estudiante.Nombres ,Estudiante.Apellidos,Estudiante.Email from Estudiante where Email= '"+objest.Email+"'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteE> listaEstud = new List<clEntidadEstudianteE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

                objEstu.IdEstudiante = int.Parse(tblEstud.Rows[i][0].ToString());
                objEstu.Nombres = tblEstud.Rows[i][1].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][2].ToString();
                objEstu.Email = tblEstud.Rows[i][3].ToString();
                

                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

        public List<clEntidadEstudianteE> mtdDatosE(clEntidadEstudianteE objE)
        {
            string sql = "select IdEstudiante,Nombres,Apellidos,Documento,Email,IdCurso from Estudiante where Email = '"+ objE.Email +"'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteE> listaEstud = new List<clEntidadEstudianteE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

                objEstu.IdEstudiante = int.Parse(tblEstud.Rows[i][0].ToString());
                objEstu.Nombres = tblEstud.Rows[i][1].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][2].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][3].ToString());
                objEstu.Email = tblEstud.Rows[i][4].ToString();
                objEstu.IdCurso = int.Parse(tblEstud.Rows[i][5].ToString());


                idEstudiante = int.Parse(tblEstud.Rows[i][0].ToString());
                idCurso = int.Parse(tblEstud.Rows[i][5].ToString());

                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

        public List<clEntidadEstudianteEE> mtdDatosEstuP(ClEntidadCursosE objE)
        {
            string sql = "select Estudiante.Nombres,Estudiante.Apellidos,Estudiante.Documento,Estudiante.Email from Estudiante inner join Curso on Estudiante.IdCurso = Curso.IdCurso where Curso.Curso = '" + objE.Curso + "'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteEE> listaEstud = new List<clEntidadEstudianteEE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteEE objEstu = new clEntidadEstudianteEE();
 
                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][2].ToString());
                objEstu.Email = tblEstud.Rows[i][3].ToString();
                
                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

        //Listado de correos
        public List<clEntidadEstudianteEE> mtdCorreos(clEntidadCursoMateriaE objCm)
        {
            string sql = "select Email from Estudiante inner join Curso ON Estudiante.IdCurso = Curso.IdCurso inner join CursoMateria on CursoMateria.IdCurso = Curso.IdCurso where CursoMateria.IdCursoMateria = '" + objCm.IdCursoMateria +"'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteEE> listaEstud = new List<clEntidadEstudianteEE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteEE objEstu = new clEntidadEstudianteEE();

                objEstu.Email = tblEstud.Rows[i][0].ToString();
               

                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

        public List<clEntidadEstudianteE> mtdInforme(clEntidadEstudianteE objCm)
        {
            string sql = "select Estudiante.Nombres , Estudiante.Apellidos ,Estudiante.Documento, Estudiante.Email , Curso.Curso , Curso.Grado from Estudiante inner join Curso on Estudiante.IdCurso = Curso.IdCurso where Estudiante.IdEstudiante = '"+objCm.IdEstudiante+"' ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadEstudianteE> listaEstud = new List<clEntidadEstudianteE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadEstudianteE objEstu = new clEntidadEstudianteE();

                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][2].ToString());
                objEstu.Email = tblEstud.Rows[i][3].ToString();
                objEstu.Curso = tblEstud.Rows[i][4].ToString();
                objEstu.Grado = tblEstud.Rows[i][5].ToString();
                            
                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

    }

}