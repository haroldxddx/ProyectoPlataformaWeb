using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clAnunciosD
    {
        public int mtdRegistrarA(clEntidadAnunciosE objAnun)
        {
            string sqlInsert = "insert into Anuncios (Titulo,Fecha,Descripcion,Archivos,IdAdministrador)" +
                "values('" + objAnun.Titulo + "' , '"+ objAnun.Fecha +"' ,'" + objAnun.Descripcion + "' , '" + objAnun.Archivos + "' , " + objAnun.IdAdministrador + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }
        public int mtdRegistrarAProf(clEntidadAnunciosE objAnun)
        {
            string sqlInsert = "insert into Anuncios (Titulo,Fecha, Descripcion,Archivos,IdProfesor)" +
                "values('" + objAnun.Titulo + "' , '" + objAnun.Fecha + " ,'" + objAnun.Descripcion + "' , '" + objAnun.Archivos + "' , " + objAnun.IdProfesor + ")";

            clAdminSQL objSQL = new clAdminSQL();
            int result = objSQL.mtdConectado(sqlInsert);
            return result;
        }

        //Listado de anuncios Administrador
        public List<clAdminAnunciosE2> mtdListAnunAdm()
        {
            string sql = "select Administradores.Nombres, Administradores.Apellidos, Anuncios.Titulo , Anuncios.Fecha, Anuncios.Descripcion , Anuncios.Archivos from Administradores inner join Anuncios on Anuncios.IdAdministrador = Administradores.IdAdministrador";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clAdminAnunciosE2> listaEstud = new List<clAdminAnunciosE2>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clAdminAnunciosE2 objEstu = new clAdminAnunciosE2();

                
                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Titulo = tblEstud.Rows[i][2].ToString();
                objEstu.Fecha = tblEstud.Rows[i][3].ToString();
                objEstu.Descripcion = tblEstud.Rows[i][4].ToString();
                objEstu.Archivos = tblEstud.Rows[i][5].ToString();

                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

        //Listado de anuncios Profesor
        public List<clAdminAnunciosE2> mtdListAnunProf()
        {
            string sql = "select Profesor.Nombres, Profesor.Apellidos, Anuncios.Titulo , Anuncios.Fecha, Anuncios.Descripcion , Anuncios.Archivos from Profesor inner join Anuncios on Anuncios.IdProfesor = Profesor.IdProfesor";

            clAdminSQL objSql = new clAdminSQL();
            DataTable tblEstud = new DataTable();
            tblEstud = objSql.mtdDesconectado(sql);

            List<clAdminAnunciosE2> listaEstud = new List<clAdminAnunciosE2>();

            for (int i = 0; i < tblEstud.Rows.Count; i++)
            {
                clAdminAnunciosE2 objEstu = new clAdminAnunciosE2();


                objEstu.Nombres = tblEstud.Rows[i][0].ToString();
                objEstu.Apellidos = tblEstud.Rows[i][1].ToString();
                objEstu.Titulo = tblEstud.Rows[i][2].ToString();
                objEstu.Fecha = tblEstud.Rows[i][3].ToString();
                objEstu.Descripcion = tblEstud.Rows[i][4].ToString();
                objEstu.Archivos = tblEstud.Rows[i][5].ToString();

                listaEstud.Add(objEstu);

            }

            return listaEstud;
        }

    }
}