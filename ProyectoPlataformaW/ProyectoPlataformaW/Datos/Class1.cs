using ProyectoPlataformaW.Entidades;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class Class1
    {
        public List<estudiantesViewModel> mtdlis()
        {
            string path = @"C:\Users\USUARIO\source\repos\ProyectoPlataformaWeb\ProyectoPlataformaW\Estu.xlsx";
          

            SLDocument sl = new SLDocument(path);

            int iRow = 2;
            List<estudiantesViewModel> listaEs = new List<estudiantesViewModel>();

            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                estudiantesViewModel objEVM = new estudiantesViewModel();
                objEVM.Nombres = sl.GetCellValueAsString(iRow, 1);
                objEVM.Apellidos = sl.GetCellValueAsString(iRow, 2);
                objEVM.Documento = sl.GetCellValueAsInt32(iRow, 3);
                objEVM.Email = sl.GetCellValueAsString(iRow, 4);
                objEVM.Contrasena = sl.GetCellValueAsString(iRow, 5);
                objEVM.IdCurso = sl.GetCellValueAsInt32(iRow, 6);

                listaEs.Add(objEVM);



                iRow++;
            }

            return listaEs;
        }
    }
}