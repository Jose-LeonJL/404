using System;
using System.Collections.Generic;
using System.Text;
using DVStudio.SDK.Estructuras;

namespace DVStudio.SDK.Estructura_Respuesta
{
    public class Obtener_Ventas
    {
        public Data data { get; set; }
        public string status { get; set; }
        public int code { get; set; }
        public struct Data 
        {
            public List<ventas> sales { get; set; }
        }
    }
    public struct ventas
    {
        public string id { get; set; }
        public Struct_Ventas Data { get; set; }
    }
}
