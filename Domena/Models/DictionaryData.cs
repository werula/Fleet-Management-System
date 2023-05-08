using System.ComponentModel.DataAnnotations;

namespace Domena.Models
{
    public abstract class DictionaryData
    {
        [Key] // klucz główny 
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
