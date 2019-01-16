using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Collections.Specialized;
using System.Text;
using System.Collections;

namespace ConalWeb2._0.Modelo
{
    public class ConexionBD
    {

        
        private static string host = "http://conalweb.esy.es/ConalWeb_PHP/";

        private static string URL_GruposPertenece = host + "Grupo/Select_Grupos_Usuario_Pertenece.php";
        private static string URL_GruposNoPertenece = host + "Grupo/Select_Grupos_Usuario_NoPertenece.php";
        private static string URL_AgregarMiembroGrupo = host + "Grupo/AgregarUsuario.php";
        private static string URL_EliminarMiembroGrupo = host + "Grupo/Delete_Miembro_Grupo.php";
        private static string URL_Select_Miembros_Grupo = host + "Grupo/Select_Miembros_Grupo.php";
        private static string URL_CrearGrupo = host + "Grupo/CrearGrupo.php";
        private static string URL_SelectGrupos = host + "Grupo/Select_Grupos.php";
        private static string URL_UpdateGrupo = host + "Grupo/Update_Grupo.php";

        private static string URL_PublicarSuceso = host + "Suceso/CrearSuceso.php";
        private static string URL_SelectSucesos = host + "Suceso/Select_Sucesos_de_Grupo.php";

        private static string URL_PublicarReunion = host + "Reunion/Insert_Reunion.php";
        private static string URL_SelectReuniones = host + "Reunion/Select_Reuniones_De_Grupo.php";

        private static string URL_RegistrarUsuario = host + "Usuario/RegistrarUsuario.php";
        private static string URL_IniciarSesion = host + "Usuario/Login.php";
        private static string URL_SelectUsuarios = host + "Usuario/SelectUsuarios.php";

        private static ConexionBD instancia;

        private ConexionBD()
        {

        }

        public static ConexionBD getInstance()
        {
            if (instancia == null)
            {
                instancia = new ConexionBD();
            }
            return instancia;
        }


        public string executeQueryPOST(string URL, string parametros)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            byte[] data = Encoding.ASCII.GetBytes(parametros);
           
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            //    request.AutomaticDecompression = DecompressionMethods.GZip;


            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            string respuesta = "";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                respuesta = reader.ReadToEnd();
            }
            return respuesta;
        }

        public ArrayList cargarGruposPertenece(string IdUsuario)
        {
            string respuesta = executeQueryPOST(URL_GruposPertenece, "IdUsuario=" + IdUsuario);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {     
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        string idGrupo = json.Value<string>("IdGrupo");
                        string idAdm = json.Value<string>("IdAdministrador");
                        string nombre = json.Value<string>("Nombre");
                        string descripcion = json.Value<string>("Descripcion");
                        string img = json.Value<string>("Imagen");
                        string name_img = json.Value<string>("NombreImg");
                        Grupo g = new Grupo(idGrupo, idAdm, nombre, descripcion, img, name_img);
                        result.Add(g);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }


        public ArrayList cargarGruposNoPertenece(string IdUsuario)
        {
            string respuesta = executeQueryPOST(URL_GruposNoPertenece, "IdUsuario=" + IdUsuario);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    System.Diagnostics.Debug.WriteLine("parada 1");
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        System.Diagnostics.Debug.WriteLine("parada 2");
                        string idGrupo = json.Value<string>("IdGrupo");
                        string idAdm = json.Value<string>("IdAdministrador");
                        string nombre = json.Value<string>("Nombre");
                        string descripcion = json.Value<string>("Descripcion");
                        string img = json.Value<string>("Imagen");
                        string name_img = json.Value<string>("NombreImg");
                        Grupo g = new Grupo(idGrupo, idAdm, nombre, descripcion, img, name_img);
                        result.Add(g);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }

        public Boolean actualizarGrupo(string idGrupo, string nombre, string descripcion)
        {
            string respuesta = executeQueryPOST(URL_UpdateGrupo, "Nombre=" + nombre + "&Descripcion=" + descripcion + "&IdGrupo=" + idGrupo);


            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    return true;
                }

            }
            catch (Exception e) { }
            return false;
        }

        public Boolean publicarSuceso(string titular, string descripcion, string sospechosos, string fecha, string hora, string ubicacion, string idUsuario, string idGrupo)
        {
            string respuesta = executeQueryPOST(URL_PublicarSuceso, "titular=" + titular + "&descripcionSuceso=" + descripcion + "&descripcionSospechosos=" + sospechosos + "&fecha=" + fecha + "&hora=" + hora + "&ubicacionTxt=" + ubicacion  + "&idUsuario="+idUsuario + "&idGrupo=" + idGrupo);

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    return true;
                }

            }
            catch (Exception e) { }
            return false;
        }

        public Boolean publicarReunion(string titular, string descripcion, string fecha, string hora, string ubicacion, string idUsuario, string idGrupo)
        {
            string respuesta = executeQueryPOST(URL_PublicarReunion, "Titular=" + titular + "&Descripcion=" + descripcion + "&fecha=" + fecha + "&hora=" + hora + "&Ubicacion=" + ubicacion + "&IdUsuario=" + idUsuario + "&IdGrupo=" + idGrupo);

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    return true;
                }

            }
            catch (Exception e) { }
            return false;
        }

        public Boolean registrarUsuario(string username, string password, string email, string name, string lastname, string imagen)
        {
            string respuesta = executeQueryPOST(URL_RegistrarUsuario, "username=" + username + "&password=" + password + "&email=" + email + "&name=" + name + "&lastname=" + lastname + "&img=" + imagen);

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    return true;
                }

            }
            catch (Exception e) { }
            return false;
        }

        public Boolean agregarMiembroGrupo(string IdUsuario, string IdGrupo)
        {
            string respuesta = executeQueryPOST(URL_AgregarMiembroGrupo, "IdUsuario=" + IdUsuario + "&IdGrupo=" + IdGrupo);

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    return true;
                }

            }
            catch (Exception e) { }
            return false;
        }


        public Boolean eliminarMiembroGrupo(string IdUsuario, string IdGrupo)
        {
            string respuesta = executeQueryPOST(URL_EliminarMiembroGrupo, "IdUsuario=" + IdUsuario + "&IdGrupo=" + IdGrupo);

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    return true;
                }

            }
            catch (Exception e) { }
            return false;
        }
        

        public ArrayList selectMiembrosGrupo(string IdGrupo)
        {
            string respuesta = executeQueryPOST(URL_Select_Miembros_Grupo, "IdGrupo=" + IdGrupo);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    { 
                        string idUsuario = json.Value<string>("IDUsuario");
                        string nombre = json.Value<string>("Nombre");
                        string apellido = json.Value<string>("Apellido");
                        string correo = json.Value<string>("Correo");
                        string imgPerfil = json.Value<string>("ImgPerfil");
                        Usuario u = new Usuario(idUsuario, nombre, apellido, correo, imgPerfil);
                        result.Add(u);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }


        public ArrayList selectReunionesGrupo(string IdGrupo)
        {
            string respuesta = executeQueryPOST(URL_SelectReuniones, "IdGrupo=" + IdGrupo);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {

                    // IdReunion	IdGrupo	IdUsuario	Ubicacion	Descripcion	Titular	Fecha	Hora
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        string idReunion = json.Value<string>("IdReunion");
                        string idUsuario = json.Value<string>("IdUsuario");
                        string nombreUsuario = json.Value<string>("Nombre") + " " + json.Value<string>("Apellido") ;
                        string ubicacion = json.Value<string>("Ubicacion");
                        string descripcion = json.Value<string>("Descripcion");
                        string titular = json.Value<string>("Titular");
                        string fecha = json.Value<string>("Fecha");
                        string hora = json.Value<string>("Hora");
                        Reunion u = new Reunion(idReunion, IdGrupo, idUsuario, nombreUsuario, ubicacion, descripcion, titular, fecha, hora);
                        result.Add(u);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }

        public ArrayList selectSucesosGrupo(string IdGrupo)
        {
            string respuesta = executeQueryPOST(URL_SelectSucesos, "IdGrupo=" + IdGrupo);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {

                    // IdReunion	IdGrupo	IdUsuario	Ubicacion	Descripcion	Titular	Fecha	Hora
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        string idSuceso = json.Value<string>("IdSuceso");
                        string idUsuario = json.Value<string>("IdUsuario");
                        string nombreUsuario = json.Value<string>("Nombre") + " " + json.Value<string>("Apellido");
                        string ubicacion = json.Value<string>("Ubicacion");
                        string descripcion = json.Value<string>("Descripcion");
                        string sospechosos = json.Value<string>("Sospechosos");
                        string titular = json.Value<string>("Titular");
                        string fecha = json.Value<string>("Fecha");
                        string hora = json.Value<string>("Hora");
                       
                        Suceso u = new Suceso(idSuceso, IdGrupo, idUsuario, nombreUsuario, ubicacion, descripcion, titular, fecha, hora, sospechosos);
                        result.Add(u);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }

        public Usuario iniciarSesion(string user, string password)
        {
            string respuesta = executeQueryPOST(URL_IniciarSesion, "user=" + user + "&password=" + password);
            Usuario u = null;
            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    JToken valores = jsonObject.GetValue("value");
         
                    string idUsuario = valores.Value<string>("IDUsuario");
                    string nombre = valores.Value<string>("Nombre");
                    string apellido = valores.Value<string>("Apellido");
                    string correo = valores.Value<string>("Correo");
                    string imgPerfil = valores.Value<string>("ImgPerfil");
                    u = new Usuario(idUsuario, nombre, apellido, correo,imgPerfil);
                    return u;   
                }
            }
            catch (Exception e) { Console.WriteLine("mierda " + e); }
            return u;
        }

        public Boolean crearGrupo(string idAdm, string nombre, string descripcion)
        {
            string respuesta = executeQueryPOST(URL_CrearGrupo, "nombre=" + nombre + "&descripcion=" + descripcion + "&adm=" + idAdm);
            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    return true;
                }
            }
            catch (Exception e) { }
            return false;
        }

        public Boolean validarGrupo(string pNombreGrupo)
        {
            string respuesta = executeQueryPOST(URL_SelectGrupos, "");
            ArrayList result = new ArrayList();
            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    // IdReunion	IdGrupo	IdUsuario	Ubicacion	Descripcion	Titular	Fecha	Hora
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        if (pNombreGrupo.Equals(json.Value<string>("Nombre")))
                        {
                            return false;
                        }                        
                    }
                }
            }
            catch (Exception e) { }
            return true;
        }

        public Boolean validarUsuario(string pNombreUsuario)
        {
            string respuesta = executeQueryPOST(URL_SelectUsuarios, "");
            ArrayList result = new ArrayList();
            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        if (pNombreUsuario.Equals(json.Value<string>("IDUsuario")))
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e) { }
            return true;
        }

    }
}