using System;
using System.Collections.Generic;
using System.Text;
using DVStudio.SDK.Estructuras;

namespace DVStudio.SDK.Estructura_Respuesta
{
    public struct Struct_Ventas_Response
    {
        public Data data { get; set; }
        public string status { get; set; }
        public int code { get; set; }

        public struct Data 
        {
            public List<Sales> sales { get; set; }
        }
            public struct Sales 
        {
            public string id { get; set; }
            public Struct_Ventas Data { get; set; }
        } 
    }
}
