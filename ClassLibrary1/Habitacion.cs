namespace SGRH.Domain
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Numero { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public decimal PrecioPorNoche { get; set; }
        public bool EstaDisponible { get; set; }
        public int PisoId { get; set; }
        public Piso? Piso { get; set; }
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}