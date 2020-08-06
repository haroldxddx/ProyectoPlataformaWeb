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
            string sql = "select IdProfesor,Nombres,Apellidos,Documento,Email,Especialidad from Profesor";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblprof = new DataTable();
            tblprof = objSql.mtdDesconectado(sql);

            List<clEntidadProfesorE> listaProf = new List<clEntidadProfesorE>();

            for (int i = 0; i < tblprof.Rows.Count; i++)
            {
                clEntidadProfesorE objProf = new clEntidadProfesorE();

                objProf.idProfesor = int.Parse(tblprof.Rows[i][0].ToString());
                objProf.Nombres = tblprof.Rows[i][1].ToString();
                objProf.Apellidos = tblprof.Rows[i][2].ToString();
                objProf.Documento = int.Parse(tblprof.Rows[i][3].ToString());
                objProf.Email = tblprof.Rows[i][4].ToString();
                objProf.Especialidad = tblprof.Rows[i][5].ToString();



                listaProf.Add(objProf);

            }

            return listaProf;


        }
        public List<clEntidadProfesorE> mtdListarProfe()
        {
            string sql = "select IdProfesor,Nombres,Apellidos,Especialidad from Profesor";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblprof = new DataTable();
            tblprof = objSql.mtdDesconectado(sql);

            List<clEntidadProfesorE> listaProfe = new List<clEntidadProfesorE>();

            for (int i = 0; i < tblprof.Rows.Count; i++)
            {
                clEntidadProfesorE objProf = new clEntidadProfesorE();

                objProf.idProfesor = int.Parse(tblprof.Rows[i][0].ToString());
                objProf.Nombres = tblprof.Rows[i][1].ToString();
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
                objPasDatos.idProfesor = int.Parse(tblDatos.Rows[i][0].ToString());
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
    }


    }
