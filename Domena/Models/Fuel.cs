using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domena.Models
{
    [Table("Fuels")] // Nazwa tabeli 
    public class Fuel
    {
        [Key] // Klucz główny tabeli 
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime FillDate { get; set; }
        public string Quantity { get; set; }
        public string Amount { get; set; }
        public string OdometerReading { get; set; }
    }

}
