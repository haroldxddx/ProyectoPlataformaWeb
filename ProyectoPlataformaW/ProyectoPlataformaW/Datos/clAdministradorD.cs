using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ProyectoPlataformaW.Entidades;

namespace ProyectoPlataformaW.Datos
{
    public class clAdministradorD
    {
        public int mtdRegistrarAdministrador(clEntidadAdministradorE objAdmin)
        {
            string sqlInsert = "insert into Administradores (Nombres,Apellidos,Documento,Email,Contrasena,Tipo)" +
                "values('" + objAdmin.Nombres + "' , '" + objAdmin.Apellidos + "' , " + objAdmin.Documento + " , '" + objAdmin.Email + "' , '" + objAdmin.Contrasena + "' , '" + objAdmin.Tipo + "')";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }

        public List<clEntidadAdministradorE> mtdListarlogin(clEntidadAdministradorE objest)
        {
            string consulta = "SELECT Administradores.IdAdministrador, Administradores.Contrasena, Administradores.Email FROM Administradores WHERE (Administradores.Contrasena = '" + objest.Contrasena + "') AND (Administradores.Email = '" + objest.Email + "')";

            clAdminSQL objAdmin = new clAdminSQL();

            DataTable tblDatos = new DataTable();
            tblDatos = objAdmin.mtdDesconectado(consulta);

            List<clEntidadAdministradorE> listaAdministradores = new List<clEntidadAdministradorE>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clEntidadAdministradorE objPasDatos = new clEntidadAdministradorE();
                objPasDatos.idAdministrador = int.Parse(tblDatos.Rows[i][0].ToString());
                objPasDatos.Contrasena = tblDatos.Rows[i][1].ToString();
                objPasDatos.Email = tblDatos.Rows[i][2].ToString();


                listaAdministradores.Add(objPasDatos);
            }
            return listaAdministradores;

        }




        public int mtdRegistrar(clEntidadAdministradorE objDatos)
        {
            string consulta = "insert into Administradores (Nombres,Apellidos,Documento,Email,Contrasena,tipo)" +
                 "values ('" + objDatos.Nombres + "','" + objDatos.Apellidos + "','" + objDatos.Documento + "' ,'" + objDatos.Email + "','" + objDatos.Contrasena + "','" + objDatos.Tipo + "')";

            clAdminSQL objConexion = new clAdminSQL();
            int reg = objConexion.mtdConectado(consulta);
            return reg;
        }

        public List<clEntidadAdministradorE> mtdListarAdmin()
        {
            string sql = "select IdAdministrador,Nombres,Apellidos,Documento,Email from Administradores";
            clAdminSQL objSql = new clAdminSQL();
            DataTable tblprof = new DataTable();
            tblprof = objSql.mtdDesconectado(sql);

            List<clEntidadAdministradorE> listaAdmin = new List<clEntidadAdministradorE>();

            for (int i = 0; i < tblprof.Rows.Count; i++)
            {
                clEntidadAdministradorE objAdmin = new clEntidadAdministradorE();

                objAdmin.idAdministrador = int.Parse(tblprof.Rows[i][0].ToString());
                objAdmin.Nombres = tblprof.Rows[i][1].ToString();
                objAdmin.Apellidos = tblprof.Rows[i][2].ToString();
                objAdmin.Documento = int.Parse(tblprof.Rows[i][3].ToString());
                objAdmin.Email = tblprof.Rows[i][4].ToString();




                listaAdmin.Add(objAdmin);

            }

            return listaAdmin;
        }


        //Actualizar Nombre

        public int mtdEditarNom(clEntidadAdministradorE objAd)
        {

            string sql = "UPDATE Administradores SET Nombres = '" + objAd.Nombres + "' WHERE Email = '" + objAd.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //EDITAR APELLIDO
        public int mtdEditarAp(clEntidadAdministradorE objAd)
        {

            string sql = "UPDATE Administradores SET Apellidos = '" + objAd.Apellidos + "' WHERE Email = '" + objAd.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //EDITAR DOCUMENTO
        public int mtdEditarDoc(clEntidadAdministradorE objAd)
        {

            string sql = "UPDATE Administradores SET Documento = '" + objAd.Documento + "' WHERE Email = '" + objAd.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }

        //Editar Email

        public int mtdEditarEmail(clEntidadAdministradorE objAd)
        {

            string sql = "UPDATE Administradores SET Email = '" + objAd.Email + "' WHERE Documento = '" + objAd.Documento + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }



        //Cambiar Contraseña
        public int mtdEditarCo(clEntidadAdministradorE objAd)
        {

            string sql = "UPDATE Administradores SET Contrasena = '" + objAd.Contrasena + "' WHERE Email = '" + objAd.Email + "'";

            clAdminSQL objConexion = new clAdminSQL();
            int xd = objConexion.mtdConectado(sql);
            return xd;
        }


    }
}