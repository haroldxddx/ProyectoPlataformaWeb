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

        public List<clEntidadEstudiante> mtdListarApb1(clEntidadEstudiante objDatos)
        {
            clEstudianteD objAsA = new clEstudianteD();
            List<clEntidadEstudiante> listaApb1 = new List<clEntidadEstudiante>();
            listaApb1 = objAsA.mtdListarlogin(objDatos);
            return listaApb1;
        }


    }
}