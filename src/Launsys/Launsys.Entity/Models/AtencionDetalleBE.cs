namespace Launsys.Entity.Models
{
    public class AtencionDetalleBE
    {
        public int id_atencion_detalle { get; }
        public int id_atencion { get; set; }
        public int id_producto { get; set; }
        public float? precio { get; set; }
        public float? descuento { get; set; }
        public float? cobro_adicional { get; set; }
        public bool? urgente { get; set; }
        public DateTime? fecha_estimada_entrega { get; set; }
        public DateTime? fecha_entrega { get; set; }
        public DateTime? fecha_registro { get; }
        public int estado { get; set; }
    }
}
