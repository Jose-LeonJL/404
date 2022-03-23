using System;
using System.Collections.Generic;
using System.Text;

namespace DVStudio.SDK.Estructuras
{
    public struct Struct_Ventas
    {
        public Productos[] Productos { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public Struct_Cliente Cliente { get; set; }
        public Struct_Usuarios Empleado { get; set; }
        public int IVS { get; set; }
        public int Total { get; set; }
    }
    public struct Productos
    {
        public string id { get; set; }
    }
}
