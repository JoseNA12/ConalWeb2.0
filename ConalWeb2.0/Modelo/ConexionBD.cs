using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Text;

namespace ConalWeb2._0.Modelo
{
    public class ConexionBD
    {

        public String executeQueryPOST(String URL, String parametros)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            byte[] data = Encoding.ASCII.GetBytes($"Parametros={parametros}");

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


        /*
        public List<Boletin> cargarBoletines_por_busqueda(String caracteristicas)
        {
            List<Boletin> boletines = new List<Boletin>();
            String respuesta = executeQueryPOST(ClaseSingleton.SEARCH_SOSPECHOSOS, caracteristicas);
            try
            {
                JObject jsonObject = JObject.Parse(respuesta);
                if (!jsonObject.Value<string>("status").Equals("false"))
                {
                    if (jsonObject.Value<string>("status").Equals("none")) { return boletines; }
                    else
                    {
                        JToken valores = jsonObject.GetValue("value");

                        foreach (JObject json in valores)
                        {
                            String idBoletin = json.Value<string>("IdBoletin");
                            Console.WriteLine(IdComunidad);
                        }
                    }
                }

            }
            catch (Exception e) { }

            return boletines;
        }*/
    }
}