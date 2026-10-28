namespace SGRH.Domain
{
    public class Huesped
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}