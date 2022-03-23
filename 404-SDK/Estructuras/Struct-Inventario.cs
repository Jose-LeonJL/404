using System;
using System.Collections.Generic;
using System.Text;

namespace DVStudio.SDK.Estructuras
{
    public struct Struct_Inventario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
    }
}
