using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConalWeb2._0.Modelo
{
    public class Suceso
    {

        private string idSuceso, IdGrupo, idUsuario, nombreUsuario, ubicacion, descripcion, titular, fecha, hora, sospechosos;

        public Suceso(string idSuceso, string idGrupo, string idUsuario, string nombreUsuario, string ubicacion, string descripcion, string titular, string fecha, string hora, string sospechosos)
        {
            this.idSuceso = idSuceso;
            this.IdGrupo = idGrupo;
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.ubicacion = ubicacion;
            this.descripcion = descripcion;
            this.titular = titular;
            this.fecha = fecha;
            this.hora = hora;
            this.sospechosos = sospechosos;
        }

        public string getIdSuceso()
        {
            return idSuceso;
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

        public string getSospechosos()
        {
            return sospechosos;
        }
    }
}