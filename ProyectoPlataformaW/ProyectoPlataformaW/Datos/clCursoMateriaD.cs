﻿using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clCursoMateriaD
    {

         public static int datoDT;
         public static int idCursoMat;

        public int mtdAsignarCursoMateria(clEntidadCursoMateriaE objCurMat)
        {
            string sqlInsert = "insert into CursoMateria values(" + objCurMat.IdCurso + " , " + objCurMat.IdMateria + " , " + objCurMat.IdProfesor + " )";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }


        //Listado de cursos asignadas a profesor
        public List<clEntidadCursoMateriaE> mtdListCursoP(clEntidadCursoMateriaE objprofe)
       
        {
            string sql = "select CursoMateria.IdCursoMateria, Curso.Curso, Curso.Grado , Profesor.Nombres, Profesor.Apellidos,Profesor.Email from Curso inner join CursoMateria On Curso.IdCurso =CursoMateria.IdCurso inner join Profesor On Profesor.IdProfesor = CursoMateria.IdProfesor where Profesor.Email = '" + objprofe.Email + "'";
            

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblProf = new DataTable();
            tblProf = objSql.mtdDesconectado(sql);
            List<clEntidadCursoMateriaE> listaEcM = new List<clEntidadCursoMateriaE>();
            for (int i = 0; i < tblProf.Rows.Count; i++)
            {
                clEntidadCursoMateriaE objCursoM = new clEntidadCursoMateriaE();
                objCursoM.IdCursoMateria = int.Parse(tblProf.Rows[i][0].ToString());
                objCursoM.Curso = tblProf.Rows[i][1].ToString();
                objCursoM.Grado = tblProf.Rows[i][2].ToString();
                objCursoM.Nombres = tblProf.Rows[i][3].ToString();
                objCursoM.Apellidos = tblProf.Rows[i][4].ToString();
                objCursoM.Email = tblProf.Rows[i][5].ToString();

                idCursoMat = int.Parse(tblProf.Rows[i][0].ToString());


                listaEcM.Add(objCursoM);

            }
            return listaEcM;
        }

        //Listado de materias a cursos
        public List<clEntidadCursoMateriaE> mtdListMateriasE(clEntidadEstudianteE objE)
        {
            string sql = "select Materia.NombreMateria, Materia.NivelAcademico , Profesor.Nombres,Profesor.Apellidos,Materia.IdMateria from Materia inner join CursoMateria ON Materia.IdMateria = CursoMateria.IdMateria inner join Profesor on Profesor.IdProfesor = CursoMateria.IdProfesor inner join Curso on Curso.IdCurso = CursoMateria.IdCurso inner join Estudiante On Curso.IdCurso = Estudiante.IdCurso where Estudiante.Email = '"+ objE.Email +"' ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadCursoMateriaE> listaEcM = new List<clEntidadCursoMateriaE>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadCursoMateriaE objCursoM = new clEntidadCursoMateriaE();

                objCursoM.NombreMateria = tblCur.Rows[i][0].ToString();
                objCursoM.NivelAcademico = tblCur.Rows[i][1].ToString();
                objCursoM.Nombres = tblCur.Rows[i][2].ToString();
                objCursoM.Apellidos = tblCur.Rows[i][3].ToString();
                 objCursoM.IdMateria = int.Parse(tblCur.Rows[i][4].ToString());

                   

                   datoDT =  int.Parse(tblCur.Rows[i][4].ToString());




                listaEcM.Add(objCursoM);

            }

            return listaEcM;


        }

        //Listado de estudiantes con esa actividad Asignada
        public List<clEntidadActividadEstuE> mtdMostrarEst(clEntidadActividadEstuE objE)
        {
            string sql = "select Estudiante.Nombres , Estudiante.Apellidos, Actividad.Descripcion , Materia.NombreMateria , Curso.Curso from Estudiante inner join CursoMateria on Estudiante.IdCurso = CursoMateria.IdCurso inner join Actividad on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria inner join Materia on Materia.IdMateria = CursoMateria.IdMateria inner join Curso on Curso.IdCurso = CursoMateria.IdCurso where CursoMateria.IdCursoMateria = '" + objE.IdCursoMateria + "' and Actividad.IdActividad = '" + objE.IdActividad + "'";


            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadActividadEstuE> listaActivi = new List<clEntidadActividadEstuE>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadActividadEstuE objAct = new clEntidadActividadEstuE();

                objAct.Nombres = tblCur.Rows[i][0].ToString();
                objAct.Apellidos = tblCur.Rows[i][1].ToString();
                objAct.Descripcion = tblCur.Rows[i][2].ToString();
                objAct.NombreMateria = tblCur.Rows[i][3].ToString();
                objAct.Curso = tblCur.Rows[i][4].ToString();


                listaActivi.Add(objAct);

            }

            return listaActivi;


        }


    }
}