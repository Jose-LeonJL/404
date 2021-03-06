using System;
using System.Collections.Generic;
using System.Text;
using DVStudio.SDK.Estructuras;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DVStudio.SDK.Exceptions;
using DVStudio.SDK.Estructura_Respuesta;

namespace DVStudio.SDK.clases
{
    public class Usuarios
    {
        private const string URL_base = "https://api.dvstudio.dev";
        private static HttpClient httpClient;
        
        public static async Task<Obtener_Usuarios> Obtener_Usuarios(string token)
        {
            Obtener_Usuarios Obtener_ = null;
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                httpClient.DefaultRequestHeaders.Add("x-access-token", token);
                Console.WriteLine(JsonSerializer.Serialize(token));
                StringContent body = new StringContent(JsonSerializer.Serialize(token), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.GetAsync("/Usuarios");
                var contenido = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(contenido);

                Obtener_ = JsonSerializer.Deserialize<Obtener_Usuarios>(contenido);
                if (Obtener_.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error } };
                    //Console.WriteLine(x2.status);
                    throw x2;
                }
                else if (Obtener_ == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                //Console.WriteLine(Obtener_.status);
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Obtener_;
        }
        public static async Task<Response_General> create_Usuarios(Struct_Usuarios usuario, string token)
        {
            Response_General response_ = null;
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json; charset=utf-8");
                httpClient.DefaultRequestHeaders.Add("x-access-token", token);
                StringContent body = new StringContent(JsonSerializer.Serialize(usuario), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("/Usuarios", body);
                var contenido = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(contenido);
                //Console.WriteLine(usuario.Identidad);


                response_ = JsonSerializer.Deserialize<Response_General>(contenido);
                if (response_.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error } };
                    //Console.WriteLine(x2.status);
                    throw x2;
                }
                else if (response_ == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                //Console.WriteLine(response_.status);
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response_;
        }
        public static async Task<Response_General> Update_Usuario(Struct_Usuarios usuario, string token, string id)
        {
            Response_General Update_ = null;

            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json; charset=utf-8");
                httpClient.DefaultRequestHeaders.Add("x-access-token", token);
                StringContent body = new StringContent(JsonSerializer.Serialize(new { id = id, data = usuario}), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync("/Usuarios", body);
                var contenido = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(contenido);
                //Console.WriteLine(usuario.Identidad);

                Update_ = JsonSerializer.Deserialize<Response_General>(contenido);
                if (Update_.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error } };
                    //Console.WriteLine(x2.status);
                    throw x2;
                }
                else if (Update_ == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                //Console.WriteLine(Update_.status);
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Update_;
        }
        public static async Task<Response_General> Delete_Usuario(string id, string token)
        {
            Response_General Delete_ = null;
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json; charset=utf-8");
                httpClient.DefaultRequestHeaders.Add("x-access-token", token);
                var response = await httpClient.DeleteAsync($"/Usuarios/{id}");
                var contenido = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(contenido);

                Delete_ = JsonSerializer.Deserialize<Response_General>(contenido);
                if (Delete_.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error } };
                    //Console.WriteLine(x2.status);
                    throw x2;
                }
                else if (Delete_ == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                //Console.WriteLine(Delete_.status);
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Delete_;
        }
    }
}
