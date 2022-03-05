using System;
using System.Collections.Generic;
using System.Text;
using DVStudio.SDK.Estructuras;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DVStudio.SDK.clases
{
    public class Login
    {
        private const string URL_base = "https://api.dvstudio.dev";
        private static HttpClient httpClient;
        
        public static async Task create_Login(Struct_Login Login)
        {
            try
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(URL_base);
                Console.WriteLine(JsonSerializer.Serialize(Login));
                StringContent body = new StringContent(JsonSerializer.Serialize(Login), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("/Login", body);
                var contenido = await response.Content.ReadAsStringAsync();
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine(JsonSerializer.Serialize(contenido));
                //Console.WriteLine(Login.);
            }
            catch (Exception ex)
            {

            }
        }
        public static void xd()
        {

        }
    }
}