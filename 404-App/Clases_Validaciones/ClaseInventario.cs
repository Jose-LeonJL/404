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
   public class ClaseInventario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string id { get; set; }

        
        
    }
    public class Inventariovalidator : AbstractValidator<ClaseInventario>
    {
        public Inventariovalidator()
        {

            //codigo
            RuleFor(x => x.Codigo).NotEmpty().WithMessage("El campo codigo no puede ir Nulo");

            //Nombre
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El Campo Nombre no puede ir Nulo");

            //Precio
            RuleFor(x => x.Precio).NotEmpty().WithMessage("El Campo Precio no puede ir Nulo");

            //Stock
            RuleFor(x => x.Stock).NotEmpty().WithMessage("El Campo Stock no puede ir Nulo");

            //Categoria
            RuleFor(x => x.Categoria).NotEmpty().WithMessage("El Campo Categoria no puede ir Nulo");

            //Marca
            RuleFor(x => x.Marca).NotEmpty().WithMessage("El Campo Marca no puede ir Nulo");

            //id
            RuleFor(x => x.id).NotEmpty().WithMessage("El Campo Id no puede ir Nulo");
        }
    }
}
