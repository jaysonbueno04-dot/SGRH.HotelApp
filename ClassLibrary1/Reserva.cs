namespace SGRH.Domain
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Total { get; set; }

        public int HuespedId { get; set; }
        public Huesped? Huesped { get; set; }

        public int HabitacionId { get; set; }
        public Habitacion? Habitacion { get; set; }
    }
}