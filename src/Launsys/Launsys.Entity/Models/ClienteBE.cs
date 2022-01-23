namespace Launsys.Entity.Models
{
    public class ClienteBE
    {
        public ClienteBE(int? pIdCliente) => id_cliente = Convert.ToInt32(pIdCliente);
        public int id_cliente { get; }
        public int id_promocion { get; set; }
        public string? nombres { get; set; }
        public string? paterno { get; set; }
        public string? materno { get; set; }
        public string? celular { get; set; }
        public string? documento { get; set; }
        public DateOnly? fecha_nacimiento { get; set; }
        public DateTime fecha_registro { get; }
        public int estado { get; set; }
    }
}
