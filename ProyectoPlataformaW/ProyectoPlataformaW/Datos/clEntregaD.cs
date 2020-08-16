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

            string sql = "select Entrega.Descripcion, Entrega.Fecha, Entrega.Archivos,Entrega.Estado,Entrega.IdEntrega from Entrega inner join Actividad on Entrega.IdActividad = Actividad.IdActividad inner join Estudiante on Entrega.IdEstudiante = Estudiante.IdEstudiante where Actividad.IdActividad = '"+ objE.IdActividad + "' and Estudiante.IdEstudiante = '" + objE.IdEstudiante + "'";

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

    }
}