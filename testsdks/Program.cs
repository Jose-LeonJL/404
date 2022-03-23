using System;
using DVStudio.SDK.clases;
namespace testsdks
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Login.create_Login(new DVStudio.SDK.Estructuras.Struct_Login { Correo = "josemaleon43@gmail.com", Contraseña = "Password1" }).GetAwaiter().GetResult();
            //var result2 = Login.Recuperar_Login(correo: "josemaleon44@gmail.com").GetAwaiter().GetResult();
            //var result3 = Login.Validar_Codigo(new DVStudio.SDK.Estructuras.Validacion { code = "1599-9703", correo = ".josemaleon44@gmail.com" }).GetAwaiter().GetResult();
            //var result4 = Login.Actualizar_Contrasena(new DVStudio.SDK.Estructuras.Actualizar_contrasena { contraseña = "Password1", correo = "josemaleon44@gmail.com", id = "RpwAXlHuyypU4roP6326" }).GetAwaiter().GetResult();
            //var Obtene_inventario = Inventario.Obtener_Inventario(result.data.jwt).GetAwaiter().GetResult();
            //Console.WriteLine(Obtene_inventario.code);
            //foreach (var inventario in Obtene_inventario.data.products)
            //{
            //    Console.WriteLine(inventario.Data.Marca);
            //}
            //var create_inv = Inventario.create_Inventario(new DVStudio.SDK.Estructuras.Struct_Inventario
            //{
            //    Codigo = System.Guid.NewGuid().ToString(),
            //    Categoria = System.Guid.NewGuid().ToString(),
            //    Marca = System.Guid.NewGuid().ToString(),
            //    Nombre = System.Guid.NewGuid().ToString(),
            //    Precio = 1,
            //    Stock = 1
            //}, result.data.jwt).GetAwaiter().GetResult();
            //Console.WriteLine(create_inv.data.id);
            //var Update = Inventario.Delete_Inventario("Bfrmo40RWeW2MoOj5y2m",result.data.jwt).GetAwaiter().GetResult();
            //Console.WriteLine(Update.status);
            //var create_vent = Ventas.create_Ventas(new DVStudio.SDK.Estructuras.Struct_Ventas 
            //{
            //    Codigo = "",
            //    Cliente = new DVStudio.SDK.Estructuras.Struct_Cliente { Codigo = "1", Identidad = "a", Telefono = "2"},
            //    Fecha = System.Guid.NewGuid().ToString(),
            //    Empleado = new DVStudio.SDK.Estructuras.Struct_Usuarios {
            //        Sueldo = 1000, 
            //        Telefono = "342", 
            //        Tipo = "Masculino", 
            //        Nombre = "Hortencio", 
            //        Codigo = "3", 
            //        Correo = "dasd", 
            //        Identidad = "afasd", 
            //        Nick = "DVRAndinor",
            //        Contraseña = ""},
            //    Total = 1,
            //    Productos= new DVStudio.SDK.Estructuras.Productos[] {new DVStudio.SDK.Estructuras.Productos { id = "1"} },
            //    IVS = 1
            //}, result.data.jwt).GetAwaiter().GetResult();
            var Obtener_Ventas = Ventas.Obtener_Ventas(result.data.jwt).GetAwaiter().GetResult();
            foreach (var ventas in Obtener_Ventas.data.sales)
            {
                Console.WriteLine(ventas.Data.Fecha);
            }
        }
    }
}