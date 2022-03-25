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
            RuleFor(x => x.Identidad).NotEmpty().WithMessage(" El Campo Identidad no puede ir nulo").MinimumLength(15).MaximumLength(15).WithMessage("tiene que tener 15 caracteres con guiones ");
            //Telefono
            RuleFor(x => x.Telefono).NotEmpty().WithMessage(" El Campo Telefono no puede ir nulo").MinimumLength(9).MaximumLength(9).WithMessage("tiene que tener 9 caracteres con un guion en medio");

        }
    }
}
