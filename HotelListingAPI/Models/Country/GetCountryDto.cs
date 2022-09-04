﻿namespace HotelListingAPI.Models.Country
{
    public class GetCountryDto:BaseCountryDto
    {
        public int Id { get; set; }
     
    }

    public class GetCountryDetailsDto:BaseCountryDto
    {
        public int Id { get; set; }
        public List<GetHotelDto> Hotels { get; set; }
    }
}
