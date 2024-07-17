namespace AprobacionGastos.Models
{
    public class SolicitudGasto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public SolicitudGasto(int id, string descripcion, decimal monto)
        {
            Id = id;
            Descripcion = descripcion;
            Monto = monto;
        }
    }
}