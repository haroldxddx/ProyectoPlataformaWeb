using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoPlataformaW.Logica;
using ProyectoPlataformaW.Entidades;
using ProyectoPlataformaW.Datos;
using System.IO;
using System.Security.Permissions;

namespace ProyectoPlataformaW.Vista
{
    public partial class Actividades : System.Web.UI.Page
    {
        
        public static int id;
        public static string Descripcion;
      
        public string o;
        public string ruta;

        protected void Page_Load(object sender, EventArgs e)

        {

            clCursoMateriaD objcmd = new clCursoMateriaD();
            int var = clCursoMateriaD.datoDT;

            
            





            string user = Session["usuario"].ToString();

            List<clEntidadActividadE> listaActividad = new List<clEntidadActividadE>();

            clEntidadActividadE objEs = new clEntidadActividadE();
            objEs.IdMateria =  inicioEstu.id;

            clActividadL objActividad = new clActividadL();
            listaActividad = objActividad.mtdActividades(objEs);


            if (listaActividad.Count != 0)
            {
                repeaterActividad.DataSource = listaActividad;
                repeaterActividad.DataBind();

                clActividadD objact = new clActividadD();
                int var2 = clActividadD.idActividad;
               



            }




            List<clEntidadActividadE> listActi = new List<clEntidadActividadE>();
            clActividadL objEstudianteL = new clActividadL();
            listActi = objEstudianteL.mtdActividades(objEs);


            for (int i = 0; i < listActi.Count; i++)
            {
                if (listActi[i].Email == user)
                {
                    clEntidadActividadE objAct = new clEntidadActividadE();


                    

                    ruta = objAct.Archivos = listActi[i].Archivos;

                   //lblnom.Text = objEstu.Nombres = listEestu[i].Nombres;

                }

            }





        }

        protected void repeaterActividad_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
          
            o = repeaterActividad.Items[e.Item.ItemIndex].ItemIndex.ToString();

           id = int.Parse(((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblidActi")).Text);
            Descripcion = ((Label)repeaterActividad.Items[int.Parse(o)].FindControl("lblDescripcion")).Text;

            Response.Write("<script> alert(" + id + ") </script>");

            Response.Redirect("~/Vista/entregaActividad.aspx");

         

        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {


            Response.Redirect("");
        }

        protected void ButtonDescargar_click(object sender, System.EventArgs e)
        {
            Response.Write("Datos de acceso incorrectos");
            //  Response.ContentType = "text/xml"+"application/msword"+ "image/x-icon"+ "image/jpeg"+ "application/json"+ "application/vnd.ms-powerpoint"+ "application/x-rar-compressed"+ "application/vnd.ms-excel"+ "application/zip"+ "image/png";
            Response.ContentType = "application/msword";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AppendHeader("NombreCabecera", "MensajeCabecera");
            Response.TransmitFile(Server.MapPath("~/Archivo/CRUCIGRAMA.dock"));
            Response.End();
        }








        public static class MIMEAssistant
        {
            private static readonly Dictionary<string, string> MIMETypesDictionary = new Dictionary<string, string>
     {
       {"ai", "application/postscript"},
       {"aif", "audio/x-aiff"},
       {"aifc", "audio/x-aiff"},
       {"aiff", "audio/x-aiff"},
       {"asc", "text/plain"},
       {"atom", "application/atom+xml"},
       {"au", "audio/basic"},
       {"avi", "video/x-msvideo"},
       {"bcpio", "application/x-bcpio"},
       {"bin", "application/octet-stream"},
       {"bmp", "image/bmp"},
       {"cdf", "application/x-netcdf"},
       {"cgm", "image/cgm"},
       {"class", "application/octet-stream"},
       {"cpio", "application/x-cpio"},
       {"cpt", "application/mac-compactpro"},
       {"csh", "application/x-csh"},
       {"css", "text/css"},
       {"dcr", "application/x-director"},
       {"dif", "video/x-dv"},
       {"dir", "application/x-director"},
       {"djv", "image/vnd.djvu"},
       {"djvu", "image/vnd.djvu"},
       {"dll", "application/octet-stream"},
       {"dmg", "application/octet-stream"},
       {"dms", "application/octet-stream"},
       {"doc", "application/msword"},
       {"docx","application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
       {"dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
       {"docm","application/vnd.ms-word.document.macroEnabled.12"},
       {"dotm","application/vnd.ms-word.template.macroEnabled.12"},
       {"dtd", "application/xml-dtd"},
       {"dv", "video/x-dv"},
       {"dvi", "application/x-dvi"},
       {"dxr", "application/x-director"},
       {"eps", "application/postscript"},
       {"etx", "text/x-setext"},
       {"exe", "application/octet-stream"},
       {"ez", "application/andrew-inset"},
       {"gif", "image/gif"},
       {"gram", "application/srgs"},
       {"grxml", "application/srgs+xml"},
       {"gtar", "application/x-gtar"},
       {"hdf", "application/x-hdf"},
       {"hqx", "application/mac-binhex40"},
       {"htm", "text/html"},
       {"html", "text/html"},
       {"ice", "x-conference/x-cooltalk"},
       {"ico", "image/x-icon"},
       {"ics", "text/calendar"},
       {"ief", "image/ief"},
       {"ifb", "text/calendar"},
       {"iges", "model/iges"},
       {"igs", "model/iges"},
       {"jnlp", "application/x-java-jnlp-file"},
       {"jp2", "image/jp2"},
       {"jpe", "image/jpeg"},
       {"jpeg", "image/jpeg"},
       {"jpg", "image/jpeg"},
       {"js", "application/x-javascript"},
       {"kar", "audio/midi"},
       {"latex", "application/x-latex"},
       {"lha", "application/octet-stream"},
       {"lzh", "application/octet-stream"},
       {"m3u", "audio/x-mpegurl"},
       {"m4a", "audio/mp4a-latm"},
       {"m4b", "audio/mp4a-latm"},
       {"m4p", "audio/mp4a-latm"},
       {"m4u", "video/vnd.mpegurl"},
       {"m4v", "video/x-m4v"},
       {"mac", "image/x-macpaint"},
       {"man", "application/x-troff-man"},
       {"mathml", "application/mathml+xml"},
       {"me", "application/x-troff-me"},
       {"mesh", "model/mesh"},
       {"mid", "audio/midi"},
       {"midi", "audio/midi"},
       {"mif", "application/vnd.mif"},
       {"mov", "video/quicktime"},
       {"movie", "video/x-sgi-movie"},
       {"mp2", "audio/mpeg"},
       {"mp3", "audio/mpeg"},
       {"mp4", "video/mp4"},
       {"mpe", "video/mpeg"},
       {"mpeg", "video/mpeg"},
       {"mpg", "video/mpeg"},
       {"mpga", "audio/mpeg"},
       {"ms", "application/x-troff-ms"},
       {"msh", "model/mesh"},
       {"mxu", "video/vnd.mpegurl"},
       {"nc", "application/x-netcdf"},
       {"oda", "application/oda"},
       {"ogg", "application/ogg"},
       {"pbm", "image/x-portable-bitmap"},
       {"pct", "image/pict"},
       {"pdb", "chemical/x-pdb"},
       {"pdf", "application/pdf"},
       {"pgm", "image/x-portable-graymap"},
       {"pgn", "application/x-chess-pgn"},
       {"pic", "image/pict"},
       {"pict", "image/pict"},
       {"png", "image/png"},
       {"pnm", "image/x-portable-anymap"},
       {"pnt", "image/x-macpaint"},
       {"pntg", "image/x-macpaint"},
       {"ppm", "image/x-portable-pixmap"},
       {"ppt", "application/vnd.ms-powerpoint"},
       {"pptx","application/vnd.openxmlformats-officedocument.presentationml.presentation"},
       {"potx","application/vnd.openxmlformats-officedocument.presentationml.template"},
       {"ppsx","application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
       {"ppam","application/vnd.ms-powerpoint.addin.macroEnabled.12"},
       {"pptm","application/vnd.ms-powerpoint.presentation.macroEnabled.12"},
       {"potm","application/vnd.ms-powerpoint.template.macroEnabled.12"},
       {"ppsm","application/vnd.ms-powerpoint.slideshow.macroEnabled.12"},
       {"ps", "application/postscript"},
       {"qt", "video/quicktime"},
       {"qti", "image/x-quicktime"},
       {"qtif", "image/x-quicktime"},
       {"ra", "audio/x-pn-realaudio"},
       {"ram", "audio/x-pn-realaudio"},
       {"ras", "image/x-cmu-raster"},
       {"rdf", "application/rdf+xml"},
       {"rgb", "image/x-rgb"},
       {"rm", "application/vnd.rn-realmedia"},
       {"roff", "application/x-troff"},
       {"rtf", "text/rtf"},
       {"rtx", "text/richtext"},
       {"sgm", "text/sgml"},
       {"sgml", "text/sgml"},
       {"sh", "application/x-sh"},
       {"shar", "application/x-shar"},
       {"silo", "model/mesh"},
       {"sit", "application/x-stuffit"},
       {"skd", "application/x-koan"},
       {"skm", "application/x-koan"},
       {"skp", "application/x-koan"},
       {"skt", "application/x-koan"},
       {"smi", "application/smil"},
       {"smil", "application/smil"},
       {"snd", "audio/basic"},
       {"so", "application/octet-stream"},
       {"spl", "application/x-futuresplash"},
       {"src", "application/x-wais-source"},
       {"sv4cpio", "application/x-sv4cpio"},
       {"sv4crc", "application/x-sv4crc"},
       {"svg", "image/svg+xml"},
       {"swf", "application/x-shockwave-flash"},
       {"t", "application/x-troff"},
       {"tar", "application/x-tar"},
       {"tcl", "application/x-tcl"},
       {"tex", "application/x-tex"},
       {"texi", "application/x-texinfo"},
       {"texinfo", "application/x-texinfo"},
       {"tif", "image/tiff"},
       {"tiff", "image/tiff"},
       {"tr", "application/x-troff"},
       {"tsv", "text/tab-separated-values"},
       {"txt", "text/plain"},
       {"ustar", "application/x-ustar"},
       {"vcd", "application/x-cdlink"},
       {"vrml", "model/vrml"},
       {"vxml", "application/voicexml+xml"},
       {"wav", "audio/x-wav"},
       {"wbmp", "image/vnd.wap.wbmp"},
       {"wbmxl", "application/vnd.wap.wbxml"},
       {"wml", "text/vnd.wap.wml"},
       {"wmlc", "application/vnd.wap.wmlc"},
       {"wmls", "text/vnd.wap.wmlscript"},
       {"wmlsc", "application/vnd.wap.wmlscriptc"},
       {"wrl", "model/vrml"},
       {"xbm", "image/x-xbitmap"},
       {"xht", "application/xhtml+xml"},
       {"xhtml", "application/xhtml+xml"},
       {"xls", "application/vnd.ms-excel"},
       {"xml", "application/xml"},
       {"xpm", "image/x-xpixmap"},
       {"xsl", "application/xml"},
       {"xlsx","application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
       {"xltx","application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
       {"xlsm","application/vnd.ms-excel.sheet.macroEnabled.12"},
       {"xltm","application/vnd.ms-excel.template.macroEnabled.12"},
       {"xlam","application/vnd.ms-excel.addin.macroEnabled.12"},
       {"xlsb","application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
       {"xslt", "application/xslt+xml"},
       {"xul", "application/vnd.mozilla.xul+xml"},
       {"xwd", "image/x-xwindowdump"},
       {"xyz", "chemical/x-xyz"},
       {"zip", "application/zip"}
     };

            public static string GetMIMEType(string fileName)
            {
                //get file extension
                string extension = Path.GetExtension(fileName).ToLowerInvariant();

                if (extension.Length > 0 &&
                    MIMETypesDictionary.ContainsKey(extension.Remove(0, 1)))
                {
                    return MIMETypesDictionary[extension.Remove(0, 1)];
                }
                return "unknown/unknown";
            }
        }







        protected void btn_Exc_Click(object sender, EventArgs e)
        {
           //string ruta;
            //ruta = Server.MapPath("~/Archivo/esp.jpg");
            DescargarDocumento(ruta);
        }
        private void DescargarDocumento(String ruta)
        {
            try
            {
                String prueba;
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ContentType = "image/jpeg";

                prueba = Path.GetFileName(ruta).ToString();
                HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + prueba);
                HttpContext.Current.Response.TransmitFile(ruta);
                HttpContext.Current.Response.End();
            }
            catch (Exception ex)
            {
                Response.Write("error");
            }
        }



    }
}