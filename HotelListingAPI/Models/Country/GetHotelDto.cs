using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models.Country
{
    public class HotelDto:BaseHotelDto
    {
        public int Id { get; set; }
       
    }

    public class CreateHotelDto:BaseHotelDto
    {

    }

    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set;}
        public string Address { get; set;}
        public double Rating { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int CountryId { get; set; }

    }
}