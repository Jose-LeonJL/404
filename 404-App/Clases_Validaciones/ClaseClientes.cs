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
    public class ClaseClientes
    {
        public string Codigo { get; set; }
        public string Identidad { get; set; }
        public string Telefono { get; set; }
    }

    public class Clientesvalidator : AbstractValidator<ClaseClientes>
    {
        public Clientesvalidator()
        {
            //codigo
            RuleFor(x => x.Codigo).NotEmpty().WithMessage("El campo codigo no puede ir Nulo");
            //Identidad
            RuleFor(x => x.Identidad).NotEmpty().WithMessage(" El Campo Identidad no puede ir nulo").MinimumLength(13).MaximumLength(13).WithMessage("tiene que tener 13 caracteres");
            //Telefono
            RuleFor(x => x.Telefono).NotEmpty().WithMessage(" El Campo Telefono no puede ir nulo").MinimumLength(8).MaximumLength(8).WithMessage("tiene que tener 8 caracteres");

        }
    }
}
