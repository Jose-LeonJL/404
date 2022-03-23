using System;
using System.Collections.Generic;
using System.Text;
using DVStudio.SDK.Estructuras;

namespace DVStudio.SDK.Estructura_Respuesta
{
    public class Obtener_Inventario
    {
        
        public string status { get; set; }

        public int code { get; set; }
        public Data data { get; set; }
        public struct Data
        {
            public Products[] products { get; set; }

        }
        public struct Products 
        { 
            public Struct_Inventario Data { get; set; }
            public string id { get; set; } 
        }

    }
}
