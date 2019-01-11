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

        
        private static String host = "http://conalweb.esy.es/ConalWeb_PHP/";
        private static String URL_GruposPertenece = host + "Grupo/Select_Grupos_Usuario_Pertenece.php";
        private static String URL_GruposNoPertenece = host + "Grupo/Select_Grupos_Usuario_NoPertenece.php";
        private static String URL_AgregarMiembroGrupo = host + "Grupo/AgregarUsuario.php";
        private static String URL_EliminarMiembroGrupo = host + "Grupo/Delete_Miembro_Grupo.php";
        private static String URL_Select_Miembros_Grupo = host + "Grupo/Select_Miembros_Grupo.php";


        private static String URL_PublicarSuceso = host + "Suceso/CrearSuceso.php";

        private static String URL_PublicarReunion = host + "Reunion/Insert_Reunion.php";
        private static String URL_SelectReuniones = host + "Reunion/Select_Reuniones_De_Grupo.php";

        private static String URL_RegistrarUsuario = host + "Usuario/RegistrarUsuario.php";
        private static String URL_IniciarSesion = host + "Usuario/Login.php";



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


        public String executeQueryPOST(String URL, String parametros)
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

        public ArrayList cargarGruposPertenece(String IdUsuario)
        {
            String respuesta = executeQueryPOST(URL_GruposPertenece, "IdUsuario=" + IdUsuario);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {     
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        String idGrupo = json.Value<string>("IdGrupo");
                        String idAdm = json.Value<string>("IdAdministrador");
                        String nombre = json.Value<string>("Nombre");
                        String descripcion = json.Value<string>("Descripcion");
                        String img = json.Value<string>("Imagen");
                        String name_img = json.Value<string>("NombreImg");
                        Grupo g = new Grupo(idGrupo, idAdm, nombre, descripcion, img, name_img);
                        result.Add(g);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }


        public ArrayList cargarGruposNoPertenece(String IdUsuario)
        {
            String respuesta = executeQueryPOST(URL_GruposNoPertenece, "IdUsuario=" + IdUsuario);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    {
                        String idGrupo = json.Value<string>("IdGrupo");
                        String idAdm = json.Value<string>("IdAdministrador");
                        String nombre = json.Value<string>("Nombre");
                        String descripcion = json.Value<string>("Descripcion");
                        String img = json.Value<string>("Imagen");
                        String name_img = json.Value<string>("NombreImg");
                        Grupo g = new Grupo(idGrupo, idAdm, nombre, descripcion, img, name_img);
                        result.Add(g);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }

        public Boolean crearGrupo(String idAdm, String nombre, String descripcion, String nombreIMG)
        {
            String respuesta = executeQueryPOST(URL_GruposNoPertenece, "nombre=" + nombre + "&descripcion=" + descripcion + "&adm=" + idAdm + "&name=" + nombreIMG);
            

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

        public Boolean actualizarGrupo(String idGrupo, String nombre, String descripcion, String nombreIMG)
        {
            String respuesta = executeQueryPOST(URL_GruposNoPertenece, "Nombre=" + nombre + "&Descripcion=" + descripcion + "&IdGrupo=" + idGrupo + "&NombreImg=" + nombreIMG);


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

        public Boolean publicarSuceso(String titular, String descripcion, String sospechosos, String fecha, String hora, String ubicacion, String imgGPS, String idUsuario, String idGrupo)
        {
            String respuesta = executeQueryPOST(URL_PublicarSuceso, "titular=" + titular + "&descripcion=" + descripcion + "&sospechosos=" + sospechosos + "&fecha=" + fecha + "&hora=" + hora + "&ubicacion="+ubicacion + "&imgGPS="+imgGPS + "&idUsuario="+idUsuario + "&idGrupo=" + idGrupo);

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

        public Boolean publicarReunion(String titular, String descripcion, String fecha, String hora, String ubicacion, String idUsuario, String idGrupo)
        {
            String respuesta = executeQueryPOST(URL_PublicarReunion, "Titular=" + titular + "&Descripcion=" + descripcion + "&fecha=" + fecha + "&hora=" + hora + "&Ubicacion=" + ubicacion + "&idUsuario=" + idUsuario + "&idGrupo=" + idGrupo);

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

        public Boolean registrarUsuario(String username, String password, String email, String name, String lastname)
        {
            String respuesta = executeQueryPOST(URL_RegistrarUsuario, "username=" + username + "&password=" + password + "&email=" + email + "&name=" + name + "&lastname=" + lastname);

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

        public Boolean agregarMiembroGrupo(String IdUsuario, String IdGrupo)
        {
            String respuesta = executeQueryPOST(URL_AgregarMiembroGrupo, "IdUsuario=" + IdUsuario + "&IdGrupo=" + IdGrupo);

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


        public Boolean eliminarMiembroGrupo(String IdUsuario, String IdGrupo)
        {
            String respuesta = executeQueryPOST(URL_EliminarMiembroGrupo, "IdUsuario=" + IdUsuario + "&IdGrupo=" + IdGrupo);

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
        

        public ArrayList selectMiembrosGrupo(String IdGrupo)
        {
            String respuesta = executeQueryPOST(URL_Select_Miembros_Grupo, "IdGrupo=" + IdGrupo);
            ArrayList result = new ArrayList();

            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    JToken valores = jsonObject.GetValue("value");
                    foreach (JObject json in valores)
                    { 
                        String idUsuario = json.Value<string>("IDUsuario");
                        String nombre = json.Value<string>("Nombre");
                        String apellido = json.Value<string>("Apellido");
                        String correo = json.Value<string>("Correo");
                        Usuario u = new Usuario(idUsuario, nombre, apellido, correo);
                        result.Add(u);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }


        public ArrayList selectReunionesGrupo(String IdGrupo)
        {
            String respuesta = executeQueryPOST(URL_Select_Miembros_Grupo, "IdGrupo=" + IdGrupo);
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
                        String idReunion = json.Value<string>("IdReunion");
                        String idUsuario = json.Value<string>("IdUsuario");
                        String ubicacion = json.Value<string>("Ubicacion");
                        String descripcion = json.Value<string>("Descripcion");
                        String titular = json.Value<string>("Titular");
                        String fecha = json.Value<string>("Fecha");
                        String hora = json.Value<string>("Hora");
                        Reunion u = new Reunion(idReunion, IdGrupo, idUsuario, ubicacion, descripcion, titular, fecha, hora);
                        result.Add(u);
                    }

                }

            }
            catch (Exception e) { }

            return result;
        }

        public Usuario iniciarSesion(String user, String password)
        {
            String respuesta = executeQueryPOST(URL_IniciarSesion, "user=" + user + "&password=" + password);
            Usuario u = null;
            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    JToken valores = jsonObject.GetValue("value");
                    System.Diagnostics.Debug.WriteLine("valores " + valores.ToString());
                    String idUsuario = valores.Value<string>("IDUsuario");
                    String nombre = valores.Value<string>("Nombre");
                    String apellido = valores.Value<string>("Apellido");
                    String correo = valores.Value<string>("Correo");
                    u = new Usuario(idUsuario, nombre, apellido, correo);
                    return u;   
                }

            }
            catch (Exception e) { Console.WriteLine("mierda " + e); }
            return u;
        }
    }
}