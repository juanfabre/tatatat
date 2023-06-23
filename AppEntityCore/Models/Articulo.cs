using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{

#nullable disable
    [Table("Articulos")]
    public class Articulo
    {
        public int ArticuloId { get; set; }
        public string TituloArticulo { get;}
        public string Descripcion { get; set; }
        public string Fecha { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<ArticuloEtiqueta> ArticuloEtiqueta { get; set; }
    }
}
