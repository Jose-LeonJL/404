using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _404_App.Clases_Validaciones;
using System.Threading.Tasks;
using DVStudio.SDK;
using FluentValidation.Results;

namespace _404_App
{
    public static class Datos
    {
        public static string Token { get; set; }
        public static ClaseUsuarios Usuario { get; set; }
        public static List<ClaseInventario> Inventario { get; set; }
        public static List<ClaseVentas> Ventas { get; set; }
        public static List<ClaseUsuarios> Usuarios { get; set; }

        public async static Task SetInventarios()
        {
            try
            {
            Inventario = new List<Clases_Validaciones.ClaseInventario>();
            var inventarios = await DVStudio.SDK.clases.Inventario.Obtener_Inventario(Token);
            foreach (var inventario in inventarios.data.products)
            {
                var ResultInventario = new ClaseInventario
                {
                    id = inventario.id,
                    Categoria = inventario.Data.Categoria,
                    Codigo = inventario.Data.Codigo,
                    Marca = inventario.Data.Marca,
                    Nombre = inventario.Data.Nombre,
                    Precio = inventario.Data.Precio,
                    Stock = inventario.Data.Stock
                };
                var validar = new Inventariovalidator();
                ValidationResult Resultado = validar.Validate(ResultInventario);
                if (Resultado.IsValid)
                {
                    Inventario.Add(ResultInventario);
                }
            }

            }
            catch (Exception ex )
            {
                
            }
        }
        public async static void SetVentas()
        {
            Datos.Ventas = new List<ClaseVentas>();
            var ventas = await DVStudio.SDK.clases.Ventas.Obtener_Ventas(Datos.Token);
            foreach (var venta in ventas.data.sales)
            {
                var ResultInventario = new ClaseVentas
                {
                    id = venta.id,
                    Cliente = venta.Data.Cliente,
                    Codigo = venta.Data.Codigo,
                    Empleado = venta.Data.Empleado,
                    Fecha = venta.Data.Fecha,
                    IVS = venta.Data.IVS,
                    Productos = venta.Data.Productos,
                    Total = venta.Data.Total
                };
                var validar = new VentasValidator1();
                ValidationResult Resultado = validar.Validate(ResultInventario);
                if (Resultado.IsValid)
                {
                    Datos.Ventas.Add(ResultInventario);
                }
            }
        }
    }
}
