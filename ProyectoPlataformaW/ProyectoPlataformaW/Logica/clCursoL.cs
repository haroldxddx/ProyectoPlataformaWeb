﻿using ProyectoPlataformaW.Datos;
using ProyectoPlataformaW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Logica
{
    public class clCursoL
    {
        public List<clEntidadCursosE> mtdComboCur()
        {
            clCursoD objCur = new clCursoD();
            List<clEntidadCursosE> listC = new List<clEntidadCursosE>();
            listC = objCur.mtdListarCurso();
            return listC;
        }
    }
}