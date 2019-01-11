using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConalWeb2._0.Modelo
{
    public class Reunion
    {
        private String idReunion, IdGrupo, idUsuario, ubicacion, descripcion, titular, fecha, hora;

        public Reunion(string idReunion, string idGrupo, string idUsuario, string ubicacion, string descripcion, string titular, string fecha, string hora)
        {
            this.idReunion = idReunion;
            IdGrupo = idGrupo;
            this.idUsuario = idUsuario;
            this.ubicacion = ubicacion;
            this.descripcion = descripcion;
            this.titular = titular;
            this.fecha = fecha;
            this.hora = hora;
        }
    }
}