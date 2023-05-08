using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domena.Models
{
    [Table("Drivers")] // Nazwa tabeli Drivers
    public class Driver
    {
        [Key] // Klucz główny tabeli
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Name cannot be less than 1 characters")]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Surname cannot be less than 1 characters")]
        public string Surname { get; set; }
        [MinLength(9, ErrorMessage = "Number cannot be less than 9")]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual License License { get; set; }

        public IEnumerable<DriverVehicleAssingment> Vehicles { get; set; }

    }


    [Table("Licenses")]
    public class License
    {
        [Key] // Klucz główny tabeli
        public int Id { get; set; }

        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
        
        public bool? CatB { get; set; }
        public bool? CatC { get; set; }
    }
}
