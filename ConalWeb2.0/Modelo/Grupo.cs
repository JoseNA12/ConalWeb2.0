using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConalWeb2._0.Modelo
{
    public class Grupo
    {
        private String idGrupo;
        private String idAdm;
        private String nombre;
        private String descripcion;
        private String img;
        private String nombre_img;

        public Grupo(string idGrupo, string idAdm, string nombre, string descripcion, string img, string nombre_img)
        {
            this.idGrupo = idGrupo;
            this.idAdm = idAdm;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.img = img;
            this.nombre_img = nombre_img;
        }
    }
}