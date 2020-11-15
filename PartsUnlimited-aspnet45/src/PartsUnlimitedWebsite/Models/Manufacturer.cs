using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Manufacturer
    {
                //Comments 3 testing
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}