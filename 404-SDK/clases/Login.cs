using System;
using System.Collections.Generic;
using System.Text;
using DVStudio.SDK.Estructuras;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DVStudio.SDK.Estructura_Respuesta;
using DVStudio.SDK.Exceptions;
namespace DVStudio.SDK.clases
{
    public class Login
    {
        private const string URL_base = "https://api.dvstudio.dev";
        private static HttpClient httpClient;
        
        public static async Task<Login_Response> create_Login(Struct_Login Login)
        {
            Login_Response _Response = null;
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                Console.WriteLine(JsonSerializer.Serialize(Login));
                StringContent body = new StringContent(JsonSerializer.Serialize(Login), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("/Login", body);
                var contenido = await response.Content.ReadAsStringAsync();
                Console.WriteLine(contenido);
                 
             
                _Response = JsonSerializer.Deserialize<Login_Response>(contenido);
                if (_Response.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error} };
                    Console.WriteLine(x2.status);
                    throw x2;
                }
                else if(_Response == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                Console.WriteLine(_Response.status);
                
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _Response;
        }
        
        public static async Task<Recuperar_Login> Recuperar_Login(string correo)
        {
            Recuperar_Login _Response = null;
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                Console.WriteLine(JsonSerializer.Serialize(new { Correo = correo }));
                StringContent body = new StringContent(JsonSerializer.Serialize(new { Correo = correo }), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("/Login/Recovery", body);
                var contenido = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(contenido);

                _Response = JsonSerializer.Deserialize<Recuperar_Login>(contenido);
                if (_Response.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error } };
                    //Console.WriteLine(x2.status);
                    throw x2;
                }
                else if (_Response == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                //Console.WriteLine(_Response.status);
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _Response;
        }
        
        public static async Task<Validar_Respuesta> Validar_Codigo(Validacion validacion)
        {
            Validar_Respuesta _Response = null;
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                //Console.WriteLine(JsonSerializer.Serialize(validacion));
                
                var response = await httpClient.GetAsync($"/Login/Recovery?code={validacion.code}&correo={validacion.correo}");
                var contenido = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(contenido);

                _Response = JsonSerializer.Deserialize<Validar_Respuesta>(contenido);
                if (_Response.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error } };
                    //Console.WriteLine(x2.status);
                    throw x2;
                }
                else if (_Response == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                //Console.WriteLine(_Response.status);
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _Response;
        }
        public static async Task<ActualizarContrasena> Actualizar_Contrasena(Actualizar_contrasena actualizar_)
        {
            ActualizarContrasena _Response = null;
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                //Console.WriteLine(JsonSerializer.Serialize(actualizar_));
                StringContent body = new StringContent(JsonSerializer.Serialize(actualizar_), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync("/Login/Recovery", body);
                var contenido = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(contenido);
                

                _Response = JsonSerializer.Deserialize<ActualizarContrasena>(contenido);
                if (_Response.status == "error")
                {
                    Exception2 ex2 = JsonSerializer.Deserialize<Exception2>(contenido);
                    ExceptionsResponse x2 = new ExceptionsResponse() { status = ex2.status, code = ex2.code, data = new ExceptionsResponse.Data { error = ex2.data.error } };
                    //Console.WriteLine(x2.status);
                    throw x2;
                }
                else if (_Response == null)
                {
                    throw new ExceptionsResponse() { status = "error", code = 404, data = new ExceptionsResponse.Data { error = "solicitud nula" } };
                }
                //Console.WriteLine(_Response.status);
            }
            catch (ExceptionsResponse ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _Response;
        }
        public static void xd()
        {

        }
    }
}