using ProyectoPlataformaW.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoPlataformaW
{
    
    public partial class Site1 : System.Web.UI.MasterPage
    {
        clRecuperarContra clrecuperar = new clRecuperarContra();
        protected void Page_Load(object sender, EventArgs e)
        {

        
        }

   
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            clrecuperar.enviarCorreo(txtEmail.Text);
        }

       
    }
}