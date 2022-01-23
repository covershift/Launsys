namespace Launsys.Entity.Models
{
    public class ServicioBE
    {
        public ServicioBE(int? pIdServicio) => id_servicio = Convert.ToInt32(pIdServicio);
        public int id_servicio { get; private set; }
        public string? nombre { get; set; }
        public int estado { get; set; }
    }
}
