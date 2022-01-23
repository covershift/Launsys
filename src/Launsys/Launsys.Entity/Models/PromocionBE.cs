namespace Launsys.Entity.Models
{
    public class PromocionBE
    {
        public PromocionBE(int? pIdPromocion) => id_promocion = Convert.ToInt32(pIdPromocion);
        public int id_promocion { get; }
        public string? nombre { get; set; }
        public string? color_identificador { get; set; }
        public int estado { get; set; }
    }
}
