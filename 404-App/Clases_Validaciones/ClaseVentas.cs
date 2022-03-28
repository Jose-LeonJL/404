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
        public Productos[] Productos { get; set; }
        public string id { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public Struct_Cliente Cliente { get; set; }
        public Struct_Usuarios Empleado { get; set; }
        public double IVS { get; set; }
        public double Total { get; set; }
    }

    public class VentasValidator3 : AbstractValidator<Productos[]>
    {
        public VentasValidator3()
        {
            //id
            RuleFor(x => x).NotEmpty().WithMessage("El Campo Id no puede ir Nulo");
        }
    }
    public class VentasValidator2 : AbstractValidator<Struct_Cliente>
    {
        public VentasValidator2()
        {
            //id
            RuleFor(x => x.Identidad).NotEmpty().WithMessage(" El Campo Identidad no puede ir nulo").MinimumLength(15).MaximumLength(15).WithMessage("tiene que tener 15 caracteres con guiones");
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El Campo Nombre no puede ir Nulo");
            RuleFor(x => x.Telefono).NotEmpty().WithMessage(" El Campo Telefono no puede ir nulo").MinimumLength(9).MaximumLength(9).WithMessage("tiene que tener 9 caracteres con un guion en medio");
        }
    }
    public class VentasValidator4 : AbstractValidator<Struct_Usuarios>
    {
        public VentasValidator4()
        {
            //id
            RuleFor(x => x.Correo).NotEmpty().WithMessage("El Campo Correo No puede ir Nulo").EmailAddress().WithMessage("El Correo Tiene que ser valido");

            //Codigo
            RuleFor(x => x.Codigo).NotEmpty().WithMessage("El Campo Codigo No puede ir Nulo");
            //Nombre
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El Campo Nombre no puede ir Nulo");
            //Identidad
            RuleFor(x => x.Identidad).NotEmpty().WithMessage(" El Campo Identidad no puede ir nulo").MinimumLength(15).MaximumLength(15).WithMessage("tiene que tener 15 caracteres con guiones");
            //Sueldo
            RuleFor(x => x.Sueldo).NotEmpty().WithMessage("El Campo Sueldo no puede ir Nulo");
            //Telefono
            RuleFor(x => x.Telefono).NotEmpty().WithMessage(" El Campo Telefono no puede ir nulo").MinimumLength(9).MaximumLength(9).WithMessage("tiene que tener 9 caracteres con un guion en medio");
            //Nick
            RuleFor(x => x.Nick).NotEmpty().WithMessage("El Campo Nick no puede ir Nulo");
            //Tipo
            RuleFor(x => x.Tipo).NotEmpty().WithMessage("El Campo Tipo no puede ir Nulo");
            //Contraseña
            RuleFor(x => x.Contraseña).NotEmpty().WithMessage("El Campo Contraseña no puede ir Nulo");
        }
    }
    public class VentasValidator1 : AbstractValidator<ClaseVentas>
    {
        public VentasValidator1()
        {
            //Producto
            RuleFor(x => x.id).NotEmpty().WithMessage("El Id no puede Contener Nulos");
            RuleFor(x => x.Productos).NotEmpty().WithMessage("Ingrese al menos un producto");
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
