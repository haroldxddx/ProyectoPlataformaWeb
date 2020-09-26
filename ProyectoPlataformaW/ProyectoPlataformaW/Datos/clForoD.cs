using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
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
    }
}