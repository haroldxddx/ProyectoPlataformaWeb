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






    }
}