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
        public List<EntidadEstudianteXlsx> mtdlis()
        {
            // string path = @"C:\Users\USUARIO\source\repos\ProyectoPlataformaWeb\ProyectoPlataformaW\Estu.xlsx";
            string path  = @"driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)}";
          

         SLDocument sl = new SLDocument(path);

            int iRow = 2;
            List<EntidadEstudianteXlsx> listaEs = new List<EntidadEstudianteXlsx>();

           while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                EntidadEstudianteXlsx objEVM = new EntidadEstudianteXlsx();
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