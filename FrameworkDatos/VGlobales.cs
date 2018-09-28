using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace publiRecargas
{
    class VGlobales
    {
        // Identificación de la aplicación.
        public static string NOMBRE_APLICACION = " - Video Publicidad -";

        // Variables constantes para la cadena de conexion de la base de datos.

        //------------------------------------------------------------------------
        // Host Web
        public static string HOST = "www.publirecargas.com";
        public static string USUARIO_DB = "ab96474_publi_re";
        public static string PASSWORD_DB = "Armenia@.123";
        public static string DATABASE = "ab96474_publi_recargas";
        //-------------------------------------------------------------------------
        //// Host Local
        //public static string HOST = "Cesar";
        //public static string USUARIO_DB = "villegas";
        //public static string PASSWORD_DB = "CA@.v1ll3g4s";
        //public static string DATABASE = "video_publicidad";  
        //-------------------------------------------------------------------------
        //variables de sesion
        public static string nombre = "";
        public static string tipo_usuario = "";
        public static string franquicia_id = "";
  
        //variables para procesos web
        public static string rutaWeb = "http://www.publirecargas.com/core/campaign";

    }
}
