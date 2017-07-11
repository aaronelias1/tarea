using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Prestamos.Models

{
    public class Clientes
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "EL Campo {0} Es obligado")]
        [StringLength(60)] 
        public string Nombre { get; set; }

        [Required(ErrorMessage = "EL Campo {0} Es obligado")]
        [StringLength(100)]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "EL Campo {0} Es obligado")]
        [StringLength(200)]
        public string Direccion { get; set; }
            
        public virtual  ICollection<Prestamo> Prestamos { get; set; }
    }
}