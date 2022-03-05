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
        private static string URL_base, access_token;
        private static HttpClient httpClient;
        public Login(string URl_base)
        {
            httpClient = new HttpClient();
            URL_base = URl_base;
        }
        public static async Task create_Login(Struct_Login Login)
        {
            try
            {
                httpClient.BaseAddress = new Uri(URL_base);
                StringContent body = new StringContent(JsonSerializer.Serialize(Login), System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("/Login", body);
                var contenido = await response.Content.ReadAsStringAsync();
                Console.WriteLine(contenido);
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