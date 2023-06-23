using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? NombreCategoria { get; set; }//hola
        public ICollection <Producto>? Productos { get; set; }
    }
}
