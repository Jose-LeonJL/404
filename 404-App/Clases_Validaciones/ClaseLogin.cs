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
    public class ClaseLogin
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }

    public class LoginValidator : AbstractValidator<ClaseLogin>
    {
        public LoginValidator()
        {
            //Correo
            RuleFor(x => x.Correo).NotEmpty().WithMessage("El Campo Correo no puede ir Nulo").EmailAddress().WithMessage("El Correo tiene que ser valido");
            //Contraseña
            RuleFor(x => x.Contraseña).NotEmpty().WithMessage("El Campo Contraseña no puede ir Nulo");
        }
    }


}
