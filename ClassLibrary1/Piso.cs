namespace SGRH.Domain
{
    public class Piso
    {
        public int Id { get; set; }
        public int NumeroPiso { get; set; }
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public ICollection<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();
    }
}