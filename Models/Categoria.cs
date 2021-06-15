using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace repasoPC4.Models
{
    public class Categoria
    {
        public int Id { get; set; }
          [Required]
        public string Nombre { get; set; }
        public ICollection<Producto> Productos{ get; set;}
    }
}