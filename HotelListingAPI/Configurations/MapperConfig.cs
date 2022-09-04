using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;

namespace HotelListingAPI.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDetailsDto>().ReverseMap();
            CreateMap<Hotel, GetHotelDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

        }
    }
}
