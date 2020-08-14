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

            string sql = "select Entrega.Descripcion, Entrega.Fecha, Entrega.Archivos,Entrega.Estado from Entrega inner join Actividad on Entrega.IdActividad = Actividad.IdActividad inner join Estudiante on Entrega.IdEstudiante = Estudiante.IdEstudiante where Actividad.IdActividad = '"+ objE.IdActividad + "' and Estudiante.IdEstudiante = '" + objE.IdEstudiante + "'";

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
                
                listaEnt.Add(objEntr);

            }

            return listaEnt;


        }
    }
}