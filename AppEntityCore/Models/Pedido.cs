using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppEntityCore.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaPedido { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaEntrega { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan HoraEntrega { get; set; }
    }

}
