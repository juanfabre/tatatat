using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppEntityCore.Models
{
    [Table("Usuarios")]
    
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Nombre { get; set; }

        [NotMapped]
        public int Edad { get; set; }

        [Display(Name = "Correo electronico")]
        [EmailAddress(ErrorMessage = "Por favor ingrese un email válido")]
        public string? Email { get; set; }

        [ForeignKey("DetalleUsuario")]
        public int DetalleUsuarioId { get; set; }
        public DetalleUsuario? DetalleUsuario { get; set; }

    }

}
