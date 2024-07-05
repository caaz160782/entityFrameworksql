namespace sqlServer.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Slug { get; set; }
        public string? Descripcion { get; set; }
        public int? Precio { get; set; }
        public int? Stock { get; set; }
        public DateTime? Fecha { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }
    }
}