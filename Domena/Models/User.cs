using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domena.Models
{
    // User
    // Manager to jest użytkownik z uprawnieniami większymi niż wszyscy inni
    [Table("Users")] // Nazwa tabeli 
    public class User
    {
        [Key] // Klucz główny tabeli
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Name cannot be less than 1 characters")]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Surname cannot be less than 1 characters")]
        public string Surname { get; set; }
        [MinLength(9, ErrorMessage = "Number cannot be less than 9")]
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Email  { get; set; }
        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }

    }

    [Table("UserTypes")]
    public class UserType:DictionaryData
    {
    }
}
