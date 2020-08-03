using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clAdminSQL
    {

        SqlConnection conex = null;

        public int mtdConectado(string sql)
        {
            clConexion objConexion = new clConexion();
            conex = objConexion.mtdConexion();
            conex.Open();
            SqlCommand cmdSql = new SqlCommand(sql, conex);
            int resultado = cmdSql.ExecuteNonQuery();
            conex.Close();
            return resultado;
        }

        public DataTable mtdDesconectado(string sql)
        {
            clConexion objConexion = new clConexion();
            conex = objConexion.mtdConexion();
            conex.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conex);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conex.Close();
            return tblDatos;


        }
    }
}