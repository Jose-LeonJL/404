using System;
using DVStudio.SDK.clases;
namespace testsdks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Login.create_Login(new DVStudio.SDK.Estructuras.Struct_Login { Correo = "josemaleon44@gmail.com", Contraseña = "Password1" }).GetAwaiter().GetResult()
            //var result2 = Login.Recuperar_Login(correo: "josemaleon44@gmail.com").GetAwaiter().GetResult();
            //var result3 = Login.Validar_Codigo(new DVStudio.SDK.Estructuras.Validacion { code = "1599-9703", correo = ".josemaleon44@gmail.com" }).GetAwaiter().GetResult();
            var result4 = Login.Actualizar_Contrasena(new DVStudio.SDK.Estructuras.Actualizar_contrasena { contraseña = "Password1", correo = "josemaleon44@gmail.com", id = "RpwAXlHuyypU4roP6326" }).GetAwaiter().GetResult();
        }
    }
}
