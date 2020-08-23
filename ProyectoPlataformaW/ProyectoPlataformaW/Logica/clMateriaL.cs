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
        public List<clEntidadMateriaE> mtdListMat()
        {
            clMateriaD objMat = new clMateriaD();
            List<clEntidadMateriaE> listM = new List<clEntidadMateriaE>();
            listM = objMat.mtdListarMateria();
            return listM;
        }

        public List<clNotasEstudE> mtdCargarComboMat(clNotasEstudE objNot)
        {
            clMateriaD objMat = new clMateriaD();
            List<clNotasEstudE> listM = new List<clNotasEstudE>();
            listM = objMat.mtdComboMateria(objNot);
            return listM;
        }
    }
}