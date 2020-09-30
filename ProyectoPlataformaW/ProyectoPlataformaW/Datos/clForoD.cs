using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clForoD
    {
        public int mtdRegistrarForo(clEntidadForoE objDatos)
        {
            string consulta = "insert into Foro (Titulo,Fecha,Descripcion,Imagen,Archivo,Tipo,IdActividad)" +
                 "values ('" + objDatos.Titulo + "','" + objDatos.Fecha + "','" + objDatos.Descripcion + "' ,'" + objDatos.Imagen + "','" + objDatos.Archivo + "','" + objDatos.Tipo + "','" + objDatos.IdActividad + "')";

            clAdminSQL objConexion = new clAdminSQL();
            int reg = objConexion.mtdConectado(consulta);
            return reg;
        }
        public List<clEntidadParticipacionE> mtdComentsForoP(clEntidadParticipacionE objP)
        {
            string sql = "select Participacion.Fecha, Participacion.Comentario, Profesor.Nombres, Profesor.Apellidos from Participacion inner join Profesor on Profesor.IdProfesor = Participacion.IdProfesor inner join Foro on Foro.IdForo = Participacion.IdForo where Foro.IdForo = " + objP.IdForo + " ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadParticipacionE> listaEstud = new List<clEntidadParticipacionE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadParticipacionE objEstu = new clEntidadParticipacionE();

                objEstu.Fecha = tblEstud.Rows[i][0].ToString();
                objEstu.Comentario = tblEstud.Rows[i][1].ToString();
                objEstu.Nombres = tblEstud.Rows[i][2].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][3].ToString();


                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }
        public List<clEntidadParticipacionE> mtdComentsForo(clEntidadParticipacionE objP)
        {
            string sql = "select Participacion.Fecha, Participacion.Comentario, Estudiante.Nombres, Estudiante.Apellidos  from Participacion inner join Estudiante on Estudiante.IdEstudiante = Participacion.IdEstudiante inner join Foro on Foro.IdForo = Participacion.IdForo where Foro.IdForo = "+ objP.IdForo + " ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadParticipacionE> listaEstud = new List<clEntidadParticipacionE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadParticipacionE objEstu = new clEntidadParticipacionE();

                objEstu.Fecha = tblEstud.Rows[i][0].ToString();
                objEstu.Comentario = tblEstud.Rows[i][1].ToString();
                objEstu.Nombres = tblEstud.Rows[i][2].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][3].ToString();
                

                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

        public List<clEntidadForoE> mtdForosDisp(clEntidadForoE objForE)
        {
            string sql = "select Foro.IdForo, Foro.Titulo, Foro.Fecha, Foro.Descripcion, Foro.Tipo from Foro where Foro.IdActividad =  "+ objForE.IdActividad + " ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadForoE> listaEstud = new List<clEntidadForoE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadForoE objEstu = new clEntidadForoE();


                objEstu.IdForo = int.Parse(tblEstud.Rows[i][0].ToString());
                objEstu.Titulo = tblEstud.Rows[i][1].ToString();
                objEstu.Fecha = tblEstud.Rows[i][2].ToString();
                objEstu.Descripcion = tblEstud.Rows[i][3].ToString();
                objEstu.Tipo = tblEstud.Rows[i][3].ToString();


                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }
        public int mtdComentar(clEntidadParticipacionE objDatos)
        {
            string consulta = "insert into Participacion (Fecha,Comentario,IdProfesor,IdForo)" +
                 "values ('" + objDatos.Fecha + "','" + objDatos.Comentario + "','" + objDatos.IdProfesor + "', '" + objDatos.IdForo +"')";

            clAdminSQL objConexion = new clAdminSQL();
            int reg = objConexion.mtdConectado(consulta);
            return reg;
        }
        public int mtdComentarE(clEntidadParticipacionE objDatos)
        {
            string consulta = "insert into Participacion (Fecha,Comentario,IdEstudiante,IdForo)" +
                 "values ('" + objDatos.Fecha + "','" + objDatos.Comentario + "','" + objDatos.IdEstudiante + "', '" + objDatos.IdForo + "')";

            clAdminSQL objConexion = new clAdminSQL();
            int reg = objConexion.mtdConectado(consulta);
            return reg;
        }
        public List<clEntidadForoE> mtdForosDesc()
        {
            string sql = "select Foro.IdForo, Foro.Titulo, Foro.Descripcion, Foro.Tipo from Foro ";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clEntidadForoE> listaEstud = new List<clEntidadForoE>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clEntidadForoE objEstu = new clEntidadForoE();


                objEstu.IdForo = int.Parse(tblEstud.Rows[i][0].ToString());

                objEstu.Titulo = tblEstud.Rows[i][1].ToString();              
                objEstu.Descripcion = tblEstud.Rows[i][2].ToString();
                objEstu.Tipo = tblEstud.Rows[i][3].ToString();


                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }
    }
}