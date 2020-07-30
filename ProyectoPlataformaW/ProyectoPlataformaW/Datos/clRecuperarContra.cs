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
        //Permite agregar destinatarios mensajes etc
        SmtpClient envios = new SmtpClient();
        //Verificacion de si el correo emisor y la contraseña son validos conectar a servidor de gmail

        public void enviarCorreo(string correo)
        {
            try
            {
                correos.To.Clear();//Limpiar campos despues de enviar un mensaje
                correos.Body = ""; //Eliminar body y asunto
                correos.Subject = "";
                correos.Body = "Hola! Buen dia, Usted solicito recuperar su contraseña: " + "1234";//Asignar mensaje 
                correos.Subject = ("Recuperar Contraseña");//Asignar asunto
                correos.IsBodyHtml = true;//
                correos.To.Add(correo.Trim());

                correos.From = new MailAddress("haroldzabala5@gmail.com"); //Enviar informacion
                envios.Credentials = new NetworkCredential("haroldzabala5@gmail.com", "3213064314e");//enviar correo verificacion correo y password

                //DATOS NO MODIFICABLES PARA TENER ACCESO A LA CUENTA
                envios.Host = "smtp.gmail.com";//Servidor gmail
                envios.Port = 587;//Puerto Host Gmil
                envios.EnableSsl = true; //XD

                envios.Send(correos);//Enviar Correo
            

            }
            catch (Exception ex)
            {
               

            }
        }
    }
}