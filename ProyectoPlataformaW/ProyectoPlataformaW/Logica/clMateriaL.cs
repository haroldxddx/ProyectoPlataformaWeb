using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clMateriaL
    {
        public List<clEntidadACursoMateriaE> mtdListMat()
        {
            clMateriaD objMat = new clMateriaD();
            List<clEntidadACursoMateriaE> listM = new List<clEntidadACursoMateriaE>();
            listM = objMat.mtdListarMateria();
            return listM;
        }
    }
}