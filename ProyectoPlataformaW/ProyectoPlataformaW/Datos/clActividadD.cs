using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clActividadD
    {
        public static int idActividadP;
        public static int idActividad;
        public int mtdAsignarActividad(clEntidadActividadE objAct)
        {
            string sqlInsert = "insert into Actividad(NombreActividad,FechaInicio,FechaFinal,Descripcion,Archivos,IdCursoMateria)" +
                "values('" + objAct.NombreActividad + "' , '" + objAct.FechaInicio + "' , " + objAct.FechaFinal + " , '" + objAct.Descripcion + "' , '" + objAct.Archivos + "' , " + objAct.IdCursoMateria + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }

        public List<clEntidadActividadE> mtdListActividad(clEntidadActividadE objE)
        {
            
            string sql = "select   Actividad.FechaInicio,Actividad.FechaFinal,Actividad.NombreActividad,Actividad.Descripcion,Profesor.Nombres,Profesor.Apellidos , Actividad.IdActividad ,Actividad.Archivos from Actividad inner join CursoMateria on Actividad.IdCursoMateria=CursoMateria.IdCursoMateria inner join Curso on CursoMateria.IdCurso=Curso.IdCurso inner join Profesor on CursoMateria.IdProfesor=Profesor.IdProfesor inner join Materia on CursoMateria.IdMateria= Materia.IdMateria where Materia.IdMateria='" + objE.IdMateria + "' ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadActividadE> listaAct = new List<clEntidadActividadE>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadActividadE objActivi = new clEntidadActividadE();

                objActivi.FechaInicio = tblCur.Rows[i][0].ToString();
                objActivi.FechaFinal = tblCur.Rows[i][1].ToString();
                objActivi.NombreActividad = tblCur.Rows[i][2].ToString();
                objActivi.Descripcion = tblCur.Rows[i][3].ToString();
                objActivi.Nombres = tblCur.Rows[i][4].ToString();
                objActivi.Apellidos = tblCur.Rows[i][5].ToString();
                objActivi.IdActividad = int.Parse(tblCur.Rows[i][6].ToString());
                objActivi.Archivos = tblCur.Rows[i][7].ToString();

           



                listaAct.Add(objActivi);

            }

            return listaAct;


        }
        public List<clEntidadActividadE> mtdListActividadN(clEntidadActividadE objACT)
        {

            string sql = "select IdActividad,NombreActividad from Actividad where IdCursoMateria = "+ objACT.IdCursoMateria + "";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblAct = new DataTable();
            tblAct = objSql.mtdDesconectado(sql);

            List<clEntidadActividadE> listaAct = new List<clEntidadActividadE>();

            for (int i = 0; i < tblAct.Rows.Count; i++)
            {
                clEntidadActividadE objActivi = new clEntidadActividadE();


                objActivi.IdActividad = int.Parse(tblAct.Rows[i][0].ToString());
                objActivi.NombreActividad = tblAct.Rows[i][1].ToString();
             


                listaAct.Add(objActivi);

            }

            return listaAct;


        }





        public List<clEntidadActividadE> mtdListActividadP(clEntidadActividadE objE)
        {

            string sql = "select   Actividad.FechaInicio,Actividad.FechaFinal,Actividad.NombreActividad,Actividad.Descripcion,Profesor.Nombres,Profesor.Apellidos , Actividad.IdActividad from Actividad inner join CursoMateria on Actividad.IdCursoMateria=CursoMateria.IdCursoMateria inner join Curso on CursoMateria.IdCurso=Curso.IdCurso inner join Profesor on CursoMateria.IdProfesor=Profesor.IdProfesor inner join Materia on CursoMateria.IdMateria= Materia.IdMateria where Actividad.IdActividad='" + objE.IdActividad + "' ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadActividadE> listaAct = new List<clEntidadActividadE>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadActividadE objActivi = new clEntidadActividadE();

                objActivi.FechaInicio = tblCur.Rows[i][0].ToString();
                objActivi.FechaFinal = tblCur.Rows[i][1].ToString();
                objActivi.NombreActividad = tblCur.Rows[i][2].ToString();
                objActivi.Descripcion = tblCur.Rows[i][3].ToString();
                objActivi.Nombres = tblCur.Rows[i][4].ToString();
                objActivi.Apellidos = tblCur.Rows[i][5].ToString();
                objActivi.IdActividad = int.Parse(tblCur.Rows[i][6].ToString());

                idActividadP = int.Parse(tblCur.Rows[i][6].ToString());



                listaAct.Add(objActivi);

            }

            return listaAct;


        }

        //Cargar Combo Con actividades de profesor
        public List<clEntidadActividadE> mtdCargarAct(clEntidadActividadE objE)
        {

           string sql="select Actividad.NombreActividad, Actividad.IdActividad from Actividad inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria inner join Profesor on Profesor.IdProfesor = CursoMateria.IdProfesor where Profesor.Email = '" + objE.Email + "' and CursoMateria.IdCursoMateria = '" + objE.IdCursoMateria + "'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadActividadE> listaAct = new List<clEntidadActividadE>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadActividadE objActivi = new clEntidadActividadE();

               
                objActivi.NombreActividad = tblCur.Rows[i][0].ToString();
                objActivi.IdActividad = int.Parse(tblCur.Rows[i][1].ToString());

                listaAct.Add(objActivi);

            }

            return listaAct;


        }



    }
}