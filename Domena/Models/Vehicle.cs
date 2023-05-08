using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domena.Models
{
    [Table("Vehicles")] // Nazwa tabeli 
    public class Vehicle
    {
        [Key] // Klucz główny tabeli 
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Name cannot be less than 1 characters")]
        public string Brand { get; set; } // nazwa samochodu model + marka
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Name cannot be less than 1 characters")]
        public string Model { get; set; }

        /// <summary>
        /// Numerowanie kierowców 
        /// </summary>
        //public int? DriverId { get; set; }
        //public virtual Driver Driver { get; set; }


        /// <summary>
        ///  Numerowanie samochodów ze względu na typ
        /// </summary>
        public int TypeId { get; set; }
        public virtual VehicleType Type { get; set; }
    
        public string Year { get; set; }
        public string? Color { get; set; }
        public DateTime NextReview { get; set; } // Data następnego przeglądu
        public DateTime NextInsurance { get; set; } // Data początku ważności ubezpieczenia        


        public IEnumerable<DriverVehicleAssingment> Drivers { get; set; }

        public virtual Tire Tires { get; set; }
        public virtual Issue Issues { get; set; }
        public virtual Fuel Fuels { get; set; }
    }


    [Keyless]
    public class DriverVehicleAssingment
    {
        public int? DriverId { get; set; }
        public virtual Driver Driver { get; set; }
        public int? VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public bool IsCurrent { get; set; }

        public DateTime AssignTime { get; set; }
        public DateTime? LeaveTime { get; set; }
    }

    [Table("Issues")]
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        public string Problem { get; set; }
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public int? VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

    }

    [Table("Tires")]
    public class Tire
    {
        [Key]
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Quantity { get; set; }

        public string TiresNumber { get; set; }
        public DateTime PurchaseDate { get; set; }

        public int? VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

    }


}
