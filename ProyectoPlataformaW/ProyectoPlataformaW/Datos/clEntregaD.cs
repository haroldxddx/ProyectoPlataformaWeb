using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clEntregaD
    {
        //Detalles Entrega Estudiante-Actividad
        public List<clEntidadEntregaE> mtdEntregaEst(clEntidadEntregaE objE)
        {

            string sql = "select Entrega.Descripcion, Entrega.Fecha, Entrega.Archivos,Entrega.Estado,Entrega.IdEntrega,Entrega.vinculo from Entrega inner join Actividad on Entrega.IdActividad = Actividad.IdActividad inner join Estudiante on Entrega.IdEstudiante = Estudiante.IdEstudiante where Actividad.IdActividad = '" + objE.IdActividad + "' and Estudiante.IdEstudiante = '" + objE.IdEstudiante + "'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadEntregaE> listaEnt = new List<clEntidadEntregaE>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadEntregaE objEntr = new clEntidadEntregaE();

                objEntr.Descripcion = tblCur.Rows[i][0].ToString();
                objEntr.Fecha = tblCur.Rows[i][1].ToString();
                objEntr.Archivos = tblCur.Rows[i][2].ToString();
                objEntr.Estado = tblCur.Rows[i][3].ToString();
                objEntr.IdEntrega = int.Parse(tblCur.Rows[i][4].ToString());
                objEntr.Vinculo= tblCur.Rows[i][5].ToString();

                listaEnt.Add(objEntr);

            }

            return listaEnt;


        }

        //Asignar nota a Actividad
        public int mtdAsigNota(clEntidadEntregaE objEnt)
        {

            string sql = "UPDATE Entrega SET Nota = '" + objEnt.Nota + "' WHERE Entrega.IdEntrega = '" + objEnt.IdEntrega + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //Cambiar Estado de Actividad
        public int mtdCambiarEstadoEnt(clEntidadEntregaE objEnt)
        {

            string sql = "UPDATE Entrega SET Estado = 'Calificado' WHERE Entrega.IdEntrega = '" + objEnt.IdEntrega + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }



        //Entregar  Actividad
        public int mtdAsignarEntrega(clEntidadEntregaE objEnt)
        {

            string sql = "insert into Entrega(Descripcion,Fecha,Archivos,Estado,Nota,idActividad,idEstudiante,Vinculo,OtraRespuesta,Comentario)values('"+objEnt.Descripcion+ "',GETDATE(),'" + objEnt.Archivos+"','Sin_Calificar',1.0,'"+objEnt.IdActividad+"','"+objEnt.IdEstudiante+"','"+objEnt.Vinculo+"','"+objEnt.otraRespuesta+"','"+objEnt.Comentario+"')";

            clAdminSQL objConexion = new clAdminSQL();
            int vj = objConexion.mtdConectado(sql);
            return vj;
        }

        //Ver notas por materias y actividades

        public List<clEntidadNotas> mtdListarNotasAc()
        {

            string sql = "Select * from(select Estudiante.Nombres, Estudiante.Apellidos, Actividad.NombreActividad as NombreAct, Entrega.Nota as Nota from Actividad inner join Entrega on Actividad.IdActividad = Entrega.IdActividad inner join Estudiante on Estudiante.IdEstudiante = Entrega.IdEstudiante inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria where CursoMateria.IdCursoMateria = 1 )T PIVOT( MAX(T.Nota) FOR T.NombreAct in ([Proyecto]))pivotrReport";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadNotas> listaNot = new List<clEntidadNotas>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadNotas objNota = new clEntidadNotas();

                objNota.Nombres = tblCur.Rows[i][0].ToString();
                objNota.Apellidos = tblCur.Rows[i][1].ToString();
                objNota.NombreActividad = tblCur.Rows[i][2].ToString();
                //objNota.Nota = tblCur.Rows[i][3].ToString();
                
               
                listaNot.Add(objNota);

            }

            return listaNot;

        }

        //Notas Generales

        public List<clEntidadNotas> mtdInformeN(clEntidadNotas objN)
        {

            string sql = "select Actividad.NombreActividad, Actividad.Descripcion, Entrega.Nota from Actividad inner join Entrega on Actividad.IdActividad = Entrega.IdActividad inner join CursoMateria on Actividad.IdCursoMateria = CursoMateria.IdCursoMateria inner join Estudiante on Entrega.IdEstudiante = Estudiante.IdEstudiante  WHERE CursoMateria.IdCursoMateria = '"+ objN.IdCursoMateria +"' and Estudiante.IdEstudiante = '8'";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblCur = new DataTable();
            tblCur = objSql.mtdDesconectado(sql);

            List<clEntidadNotas> listaNot = new List<clEntidadNotas>();

            for (int i = 0; i < tblCur.Rows.Count; i++)
            {
                clEntidadNotas objNota = new clEntidadNotas();

                objNota.NombreActividad = tblCur.Rows[i][0].ToString();
                objNota.Descripcion = tblCur.Rows[i][1].ToString();
                objNota.Nota = tblCur.Rows[i][2].ToString();
                //objNota.Nota = tblCur.Rows[i][3].ToString();


                listaNot.Add(objNota);

            }

            return listaNot;

        }
    }
}