using System;
using System.Collections.Generic;
using System.Text;

namespace DVStudio.SDK.Estructura_Respuesta
{

    public class Login_Response
    {
        public Data data { get; set; }
        public string status { get; set; }
        public int code { get; set; }
        public struct Data { public string jwt { get; set; } public bool login { get; set; }  public string tipo { get; set; } }
    
    }
}
