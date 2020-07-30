using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ProyectoPlataformaW.Datos
{
    public class clConexion
    {
        SqlConnection conexBD = null;
        public SqlConnection mtdConexion()
        {
            string cadena = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbProyectoPlataforma.mdf;Integrated Security=True";
            try
            {
                conexBD = new SqlConnection(cadena);
            }
            catch (Exception error)
            {

                string err = error.Message;
                HttpContext.Current.Response.Redirect("paginaError.aspx", true);
                conexBD = null;


            }

            return conexBD;
        }
    }
}