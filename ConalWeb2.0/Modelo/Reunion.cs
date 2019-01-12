using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConalWeb2._0.Modelo
{
    public class Reunion
    {
        private string idReunion, IdGrupo, idUsuario, nombreUsuario, ubicacion, descripcion, titular, fecha, hora;

        public Reunion(string idReunion, string idGrupo, string idUsuario, string nombreUsuario, string ubicacion, string descripcion, string titular, string fecha, string hora)
        {
            this.idReunion = idReunion;
            this.IdGrupo = idGrupo;
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.ubicacion = ubicacion;
            this.descripcion = descripcion;
            this.titular = titular;
            this.fecha = fecha;
            this.hora = hora;
        }

        public string getIdReunion()
        {
            return idReunion;
        }

        public string getIdGrupo()
        {
            return IdGrupo;
        }

        public string getIdUsuario()
        {
            return idUsuario;
        }

        public string getNombreUsuario()
        {
            return nombreUsuario;
        }

        public string getUbicacion()
        {
            return ubicacion;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public string getFecha()
        {
            return fecha;
        }

        public string getHora()
        {
            return hora;
        }
    }
}