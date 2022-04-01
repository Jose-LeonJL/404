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
   public class ClaseUsuarios
    {
        public string Correo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public int Sueldo { get; set; }
        public string Telefono { get; set; }
        public string Nick { get; set; }
        public string Tipo { get; set; }
        public string Contraseña { get; set; }

    }

    public class UsuariosValidator : AbstractValidator<ClaseUsuarios>
    {
        public UsuariosValidator()
        {
            //Correo
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
}
