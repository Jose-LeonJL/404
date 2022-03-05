using System;
using System.Collections.Generic;
using System.Text;

namespace DVStudio.SDK.Estructuras
{
    public struct Struct_Ventas
    {
        public string Codigo;
        public string Fecha;
        public Struct_Cliente Cliente;
        public Struct_Usuarios Usuarios;
        public int IVS;
        public Struct_Inventario Inventario;
        public int Total; 
    }
}
