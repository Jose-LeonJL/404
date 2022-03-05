using System;
using DVStudio.SDK.clases;
namespace testsdks
{
    class Program
    {
        static void Main(string[] args)
        {
            Login.create_Login(new DVStudio.SDK.Estructuras.Struct_Login { Correo = "josemaleon44@gmail.com", Contraseña = "Password1" }).Wait();
            Console.WriteLine("Hello World!");
        }
    }
}
