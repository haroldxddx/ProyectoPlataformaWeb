using ProyectoPlataformaW.Entidades;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW.Vista
{
    public partial class pruebaxd : System.Web.UI.Page

    {
        //  private string path = @"C:\Users\USUARIO\source\repos\ProyectoPlataformaWeb\ProyectoPlataformaW\Estu.xlsx";
        OleDbConnection origen = default(OleDbConnection);

        string conexion = @"Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\Users\USUARIO\source\repos\ProyectoPlataformaWeb\ProyectoPlataformaW\Estu.xlsx\Excel 4.0; HDR=Yes\";

        protected void Page_Load(object sender, EventArgs e)
        {


            origen = new OleDbConnection(conexion);

            OleDbCommand seleccion = default(OleDbCommand);
            seleccion = new OleDbCommand("Select * From [Hoja1$]", origen);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = seleccion;

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            dtgExc.DataSource = ds.Tables[0];

            origen.Close();


            SqlConnection conexion_destino = new SqlConnection();
            conexion_destino.ConnectionString = "Data Source=.;Initial Catalog=DBExcel; Integrated Security = True";

            conexion_destino.Open();

            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(conexion_destino);
            importar.DestinationTableName = "Estudiante";
            importar.WriteToServer(ds.Tables[0]);
            conexion_destino.Close();


        }
   
    }


    }