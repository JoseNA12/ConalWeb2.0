using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConalWeb2._0.Modelo
{
    public class Usuario
    {
        private String idUsuario;
        private String nombre;
        private String apellido;
        private String correo;
        private String imgPerfil;

        public Usuario(string idUsuario, string nombre, string apellido, string correo, string imgPerfil)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.imgPerfil = imgPerfil;
        }

        public String getIdUsuario()
        {
            return this.idUsuario;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public string getCorreo()
        {
            return this.correo;
        }

        public string getApellidos()
        {
            return this.apellido;
        }

        public string getImgPerfil()
        {
            return this.imgPerfil;
        }
    }
}