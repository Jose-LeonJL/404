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
   public class ClaseActualizarContrasena
    {
        public string id { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
    }

    public class ActualizarContrasenaValidator : AbstractValidator<ClaseActualizarContrasena>
    {
        public ActualizarContrasenaValidator()
        {
            //id
            RuleFor(x => x.id).NotEmpty().WithMessage("El Campo Id no puede ir Nulo");
            //Correo
            RuleFor(x => x.correo).NotEmpty().WithMessage("El Campo Correo No puede ir Nulo").EmailAddress().WithMessage("El Correo Tiene que ser valido");
            //contrasena
            RuleFor(x => x.contraseña).NotEmpty().WithMessage("El Campo Contraseña no puede ir Nulo");


        }
    }

}
