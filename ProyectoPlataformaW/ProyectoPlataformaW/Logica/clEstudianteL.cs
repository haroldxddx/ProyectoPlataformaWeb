using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoPlataformaW.Datos;
namespace ProyectoPlataformaW.Logica
{
    public class clEstudianteL
    {

        //List<clEstudianteE> listaEstudiante = new List<clEstudianteE>();

        public List<clEstudianteE> mtdListarApb1(clEstudianteE objDatos)
        {
            clEstudianteD objAsA = new clEstudianteD();
            List<clEstudianteE> listaApb1 = new List<clEstudianteE>();
            listaApb1 = objAsA.mtdListar(objDatos);
            return listaApb1;
        }


    }
}