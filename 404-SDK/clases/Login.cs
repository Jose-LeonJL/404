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
        private string URL_base, access_token;
        private HttpClient httpClient;
        public Login(string URl_base, string access_token)
        {
            this.httpClient = new HttpClient();
            this.URL_base = URl_base;
            this.access_token = access_token;
        }
        public async Task create_Login(Struct_Login Login)
        {
            httpClient.BaseAddress = new Uri(URL_base);
            httpClient.DefaultRequestHeaders.Add("x-access-token", access_token);
            StringContent body = new StringContent(JsonSerializer.Serialize(Login), System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/Login", body);
            var contenido = await response.Content.ReadAsStringAsync();
            Console.WriteLine(contenido);
            //Console.WriteLine(Login.);
        }
    }
}
