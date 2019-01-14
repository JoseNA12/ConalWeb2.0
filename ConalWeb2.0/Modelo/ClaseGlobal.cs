using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConalWeb2._0.Modelo
{
    public class ClaseGlobal
    {
        public static string sessionKey_usuarioNombre = "USUARIO_ACTUAL_NOMBRE";
        public static string sessionKey_usuarioApellidos = "USUARIO_ACTUAL_APELLIDOS";
        public static string sessionKey_usuarioNombreUsuario = "USUARIO_ACTUAL_NOMBRE_USER";
        public static string sessionKey_usuarioCorreo = "USUARIO_ACTUAL_CORREO";
        public static string sessionKey_usuarioImagenPerfil = "USUARIO_ACTUAL_IMAGEN_PERFIL";
        public static string sessionKey_usuarioURLImagenPerfil = "USUARIO_ACTUAL_URL_IMAGEN";

        private ArrayList sucesos;

        private static ClaseGlobal intanciaClaseGlobal;

        public static ClaseGlobal getInstancia()
        {
            if (ClaseGlobal.intanciaClaseGlobal==null)
            {
                ClaseGlobal.intanciaClaseGlobal = new ClaseGlobal();
            }
            return ClaseGlobal.intanciaClaseGlobal;
        }

        public ArrayList getSucesos()
        {
            return this.sucesos;
        }

        public void setSucesos(ArrayList pSucesos)
        {
            this.sucesos = pSucesos;

        }
    }
}