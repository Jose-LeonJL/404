using System;
using DVStudio.SDK.clases;
namespace DVStudio.SDK
{
    public class SDK_
    {
        private const string URL_base = "https://api.dvstudio.dev";
        private Inventario _Inventario;
        private Usuarios _usuarios;
        private Ventas _ventas;
        private Login _login;
        public Inventario inventario {
            get {
                return this._Inventario;
            }
        }
        public Usuarios usuarios
        {
            get
            {
                return this._usuarios;
            }
        }
        public Ventas ventas
        {
            get
            {
                return this._ventas;
            }
        }
        public Login login
        {
            get
            {
                return this._login;
            }
        }
        public SDK_()
        {
            this._Inventario = new Inventario(URL_base, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6ImRhbmllbGZ1bmV6ZmxoQGdtYWlsLmNvbSIsImlhdCI6MTY0NTgzMzY5NywiZXhwIjoxNjQ1OTIwMDk3fQ.TyhkABs5n3vENbL3DKQ5L4801aJKr3efn2G20goPdaU");
        }
    }
}
