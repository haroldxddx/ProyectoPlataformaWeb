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
        public static int IdProfesor;
        public List<clEntidadProfesorE> mtdListarProf()
        {
            string sql = "select IdProfesor,Nombres,Apellidos,Documento,Email from Profesor";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblprof = new DataTable();
            tblprof = objSql.mtdDesconectado(sql);

            List<clEntidadProfesorE> listaProf = new List<clEntidadProfesorE>();

            for (int i = 0; i < tblprof.Rows.Count; i++)
            {
                clEntidadProfesorE objProf = new clEntidadProfesorE();

                objProf.IdProfesor = int.Parse(tblprof.Rows[i][0].ToString());
                objProf.Nombres = tblprof.Rows[i][1].ToString();
                objProf.Apellidos = tblprof.Rows[i][2].ToString();
                objProf.Documento = int.Parse(tblprof.Rows[i][3].ToString());
                objProf.Email = tblprof.Rows[i][4].ToString();
               



                listaProf.Add(objProf);

            }

            return listaProf;
        }
            public List<clEntidadProfesorE> mtdBuscarProf(clEntidadProfesorE objProfe)
            {
                string sql = "select IdProfesor,Nombres,Apellidos,Documento,Email,Especialidad from Profesor WHERE (Profesor.Nombres LIKE '%" + objProfe.Nombres + "%')";
                clAdminSQL objSql = new clAdminSQL();
                DataTable tblprof = new DataTable();
                tblprof = objSql.mtdDesconectado(sql);

                List<clEntidadProfesorE> listaProf = new List<clEntidadProfesorE>();

                for (int i = 0; i < tblprof.Rows.Count; i++)
                {
                      clEntidadProfesorE objProfee = new clEntidadProfesorE();

                    objProfee.IdProfesor = int.Parse(tblprof.Rows[i][0].ToString());
                    objProfee.Nombres = tblprof.Rows[i][1].ToString();
                    objProfee.Apellidos = tblprof.Rows[i][2].ToString();
                    objProfee.Documento = int.Parse(tblprof.Rows[i][3].ToString());
                    objProfee.Email = tblprof.Rows[i][4].ToString();
                    objProfee.Especialidad = tblprof.Rows[i][5].ToString();



                    listaProf.Add(objProfee);

                }

                return listaProf;


            }
        

            
        //listar profesor Asignacion
        public List<clEntidadProfesorEE> mtdListarProfe()
        {
            string sql = "SELECT IdProfesor,Nombres,Apellidos,Especialidad from Profesor";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblprof = new DataTable();
            tblprof = objSql.mtdDesconectado(sql);

            List<clEntidadProfesorEE> listaProfe = new List<clEntidadProfesorEE>();

            for (int i = 0; i < tblprof.Rows.Count; i++)
            {
                clEntidadProfesorEE objProf = new clEntidadProfesorEE();

                objProf.IdProfesor = int.Parse(tblprof.Rows[i][0].ToString());
                objProf.Nombres = tblprof.Rows[i][1].ToString() ;
                objProf.Apellidos = tblprof.Rows[i][2].ToString();
                objProf.Especialidad = tblprof.Rows[i][3].ToString();



                listaProfe.Add(objProf);
            
            }

            return listaProfe;
        }



        //login
        public List<clEntidadProfesorE> mtdListarlogin(clEntidadProfesorE objest)
        {
            string consulta = "SELECT Profesor.idProfesor, Profesor.Contrasena, Profesor.Email FROM Profesor WHERE (Profesor.Contrasena = '" + objest.Contrasena + "') AND (Profesor.Email = '" + objest.Email + "')";

            clAdminSQL objAdmin = new clAdminSQL();

            DataTable tblDatos = new DataTable();
            tblDatos = objAdmin.mtdDesconectado(consulta);

            List<clEntidadProfesorE > listaProfesor = new List<clEntidadProfesorE>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clEntidadProfesorE objPasDatos = new clEntidadProfesorE();
                objPasDatos.IdProfesor = int.Parse(tblDatos.Rows[i][0].ToString());
                objPasDatos.Contrasena = tblDatos.Rows[i][1].ToString();
                objPasDatos.Email = tblDatos.Rows[i][2].ToString();


                listaProfesor.Add(objPasDatos);
            }
            return listaProfesor;

        }
        public int mtdRegistrarProfesor(clEntidadProfesorE objProfe)
        {
            string sqlInsert = "insert into Profesor (Nombres,Apellidos,Documento,Email,Contrasena,Especialidad)" +
                "values('" + objProfe.Nombres + "' , '" + objProfe.Apellidos + "' , " + objProfe.Documento + " , '" + objProfe.Email + "' , '" + objProfe.Contrasena + "' , '" + objProfe.Especialidad + "')";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }

        //Actualizar Nombre

        public int mtdEditarNomP(clEntidadProfesorE objPr)
        {

            string sql = "UPDATE Profesor SET Nombres = '" + objPr.Nombres + "' WHERE Email = '" + objPr.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //EDITAR APELLIDO
        public int mtdEditarApellidoP(clEntidadProfesorE objPr)
        {

            string sql = "UPDATE Profesor SET Apellidos = '" + objPr.Apellidos + "' WHERE Email = '" + objPr.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //EDITAR DOCUMENTO
        public int mtdEditarDocP(clEntidadProfesorE objPr)
        {

            string sql = "UPDATE Profesor SET Documento = '" + objPr.Documento + "' WHERE Email = '" + objPr.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //Editar Email

        public int mtdEditarEmaP(clEntidadProfesorE objPr)
        {

            string sql = "UPDATE Profesor SET Email = '" + objPr.Email + "' WHERE Documento = '" + objPr.Documento + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //Editar Especialidad
        public int mtdEditarEspecialidadP(clEntidadProfesorE objPr)
        {

            string sql = "UPDATE Profesor SET Especialidad = '" + objPr.Especialidad + "' WHERE Email = '" + objPr.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }



        //Cambiar Contraseña
        public int mtdEditarContP(clEntidadProfesorE objPr)
        {

            string sql = "UPDATE Profesor SET Contrasena = '" + objPr.Contrasena + "' WHERE Email = '" + objPr.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }
        public List<clEntidadProfesorE> mtdDatosProf(clEntidadProfesorE objE)
        {
            string sql = "select IdProfesor,Nombres,Apellidos,Documento,Email from Profesor where Email = '" + objE.Email + "'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadProfesorE> listaEstud = new List<clEntidadProfesorE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadProfesorE objEstu = new clEntidadProfesorE();

                objEstu.IdProfesor = int.Parse(tblEstud.Rows[i][0].ToString());
                objEstu.Nombres = tblEstud.Rows[i][1].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][2].ToString();
                objEstu.Documento = int.Parse(tblEstud.Rows[i][3].ToString());
                objEstu.Email = tblEstud.Rows[i][4].ToString();


                IdProfesor = int.Parse(tblEstud.Rows[i][0].ToString());


                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }


    }
}
