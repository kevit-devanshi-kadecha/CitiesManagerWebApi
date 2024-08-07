using System.ComponentModel.DataAnnotations;

namespace CitiesManager.WebApi.Models
{
    public class City
    {
        [Key]
        public Guid Id { get; set; } 
        [Required(ErrorMessage = "Can't be blank")]
        public string? CityName { get; set; }    
    }
}
