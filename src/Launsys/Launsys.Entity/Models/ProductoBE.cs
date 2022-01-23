
namespace Launsys.Entity.Models
{
    public class ProductoBE
    {
        public ProductoBE(int? pIdProducto) => id_producto = Convert.ToInt32(pIdProducto);
        public int id_producto { get; }
        public string? nombre { get; set; }
        public float precio { get; set; }
        public int id_servicio { get; set; }
        public int estado { get; set; }
    }
}
