using System;
using System.Collections.Generic;
using System.Text;
using DVStudio.SDK.Estructuras;

namespace DVStudio.SDK.Estructura_Respuesta
{
    public class Obtener_Usuarios
    {
        public Data data { get; set; }
        public string status { get; set; }

        public int code { get; set; }

        public struct Data { public List<Usuarios> users { get; set; } }
    }

    public struct Usuarios
    {
        public string id { get; set; }
        public Struct_Usuarios Data { get; set; }
    }
}
