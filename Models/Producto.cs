using System;
using System.ComponentModel.DataAnnotations;

namespace repasoPC4.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set;}
          [Required]
        public String NombreComprador { get; set;}
          [Required]
        public String CelularComprador { get; set;}
          [Required]
        public String LugarCompra{ get; set;}
          [Required]
        public String Descripcion { get; set;}
          [Required]
        public String Foto { get; set;}
          [Required]
        public decimal Precio { get; set;}
        public Categoria Categoria { get; set;}
        public int CategoriaId { get; set;}

     }

}