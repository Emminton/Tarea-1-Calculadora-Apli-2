using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OperacionesMatematicas.Data
{
    public class Datos
    {
        [Required(ErrorMessage = "El campo no puede estar vacío.")]
        public  decimal numero1 { get; set; }
        [Required(ErrorMessage = "El campo no puede estar vacío.")]
        public decimal numero2 { get; set; }
        public decimal resultado { get; set; }

        public Datos()
        {
            numero1 = 0;
            numero2 = 0;
            resultado = 0;
        }
    }
}
