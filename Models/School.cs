using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CuentaRegresiva.Models
{
    public class School //ENTIDAD ESCUELA int, decimal, string
    {
        public Guid Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Debe ingresar nombre.", AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
