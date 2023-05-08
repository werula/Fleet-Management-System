using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domena.Models
{
    [Table("Vehicles")] // Nazwa tabeli Vehicles
    public class Booking
    {   // Id rezerwacji 
        [Key] // klucz główny 
        public int Id { get; set; }
        /// <summary>
        /// Numery samochodów 
        /// </summary>
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        /// <summary>
        /// Numerowanie klientów 
        /// </summary>
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string Fees { get; set; } // Opłata za wypożyczenie auta

        
    }
}
