using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ProyectoPlataformaW.Datos
{
    public class clRecuperarContra
    {

        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();
        

        public void enviarCorreo(string correo, string contra)
        {
            try
            {
                correos.To.Clear();
                correos.Body = ""; 
                correos.Subject = "";
                correos.Body = "Hola! Buen dia, Usted solicito recuperar su contrasena, recuerde cambiar su contraseña la proxima vez que ingrese a la plataforma " 
                 + " Su Contrasena es : " + contra;
                correos.Subject = ("Recuperacion de Contraseña");
                correos.IsBodyHtml = true;
                correos.To.Add(correo.Trim());

                correos.From = new MailAddress("glvduitama0@gmail.com"); //Enviar informacion
                envios.Credentials = new NetworkCredential("glvduitama0@gmail.com", "integrado");//enviar correo verificacion correo y password

               
                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true; 

                envios.Send(correos);
            

            }
            catch (Exception ex)
            {
               

            }
        }
    }
}