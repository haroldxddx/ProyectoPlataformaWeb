using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clAnunciosD
    {
        public int mtdRegistrarA(clEntidadAnunciosE objAnun)
        {
            string sqlInsert = "insert into Anuncios (Titulo,Descripcion,Archivos,IdAdministrador)" +
                "values('" + objAnun.Titulo + "' , '" + objAnun.Descripcion + "' , '" + objAnun.Archivos + "' , " + objAnun.IdAdministrador + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }
        public int mtdRegistrarAProf(clEntidadAnunciosE objAnun)
        {
            string sqlInsert = "insert into Anuncios (Titulo,Descripcion,Archivos,IdProfesor)" +
                "values('" + objAnun.Titulo + "' , '" + objAnun.Descripcion + "' , '" + objAnun.Archivos + "' , " + objAnun.IdProfesor + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }
    }
}