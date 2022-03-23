using System;
using System.Collections.Generic;
using System.Text;

namespace DVStudio.SDK.Estructura_Respuesta
{
    public class ActualizarContrasena
    {
        public Data data { get; set; }
        public string status { get; set; }
        public int code { get; set; }
        public struct Data { public string message { get; set; } }
    }
}
