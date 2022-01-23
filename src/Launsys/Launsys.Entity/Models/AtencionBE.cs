namespace Launsys.Entity.Models
{
    public class AtencionBE
    {
        public int id_atencion { get; }
        public int id_cliente { get; set; }
        public string? observaciones { get; set; }
        public DateTime? fecha_registro { get; }
        public int estado { get; set; }
    }
}
