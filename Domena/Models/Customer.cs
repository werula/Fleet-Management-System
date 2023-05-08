using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Domena.Models
{
    [Table("Customers")] // Nazwa tabeli Customers 
    public class Customer
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
        public string PostCode { get; set; }
        public string CardId { get; set; } // Numer dokumentu potwierdzającego 
        public string? Email   { get; set; }

        //TODO: Dodać coś

        public virtual IEnumerable<CustomersPermamentJob> Jobs { get; set; }
    }


    [Table("CustomersPermamentJobs")]
    [Keyless]
    public class CustomersPermamentJob
    {
        public int CustomerId { get; set; }
        public int JobId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PermamentJob Job { get; set; }
    }



    [Table("PermamentJobs")] 
    public class PermamentJob
    {
        [Key] // Klucz główny tabeli 
        public int Id { get; set; }
        public double Price { get; set; }
        public double DeliveryWeight { get; set; }
        public string From { get;set; }
        public string To { get;set; }

        public virtual IEnumerable<CustomersPermamentJob> Customers { get; set; }
    }
}
