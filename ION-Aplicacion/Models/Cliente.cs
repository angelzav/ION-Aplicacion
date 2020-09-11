using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ION_Aplicacion.Models
{
    public class Cliente
    {        
        public int ID { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        [Required]        
        [StringLength(150)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [StringLength(250)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Direccion { get; set; }

        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
