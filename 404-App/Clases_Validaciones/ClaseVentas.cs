using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVStudio.SDK.Estructura_Respuesta;
using DVStudio.SDK.Estructuras;
using FluentValidation;

namespace _404_App.Clases_Validaciones
{
    public class ClaseVentas
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

    public class VentasValidator : AbstractValidator<ClaseVentas.Productos>
    {
        public VentasValidator()
        {
            //id
            RuleFor(x => x.id).NotEmpty().WithMessage("El Campo Id no puede ir Nulo");
        }
    }

    public class VentasValidator1 : AbstractValidator<ClaseVentas.Struct_Ventas>
    {
        public VentasValidator1()
        {
            //Producto
            RuleFor(x => x.Productos).NotEmpty().WithMessage("La Lista de Id no puede Contener Nulos");
            //codigo
            RuleFor(x =>x.Codigo).NotEmpty().WithMessage("El Campo Id no puede ir Nulo");
            //Fecha
            RuleFor(x => x.Fecha).NotEmpty().WithMessage("El Campo Fecha no puede ir Nulo");
            //Cliente
            RuleFor(x => x.Cliente).NotEmpty().WithMessage("Los Datos Del Cliente estan incompletos,favor revisar Informacion del cliente");
            //Usuario
            RuleFor(x => x.Empleado).NotEmpty().WithMessage("Los Datos Del Empleado estan incompletos,favor revisar Informacion del Empleado");
            //ISV
            RuleFor(x => x.IVS).NotEmpty().WithMessage("El campo ISV no puede ir Nulo");
            //Total
            RuleFor(x => x.Total).NotEmpty().WithMessage("El campo Total no puede ir Nulo");

        }
    }

   

}
