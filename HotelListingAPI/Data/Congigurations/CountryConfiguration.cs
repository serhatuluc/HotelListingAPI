using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListingAPI.Data.Congigurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(new Country
            {
                Id = 1,
                Name = "Jamaica",
                ShortName = "JM"
            },
             new Country
             {
                 Id = 2,
                 Name = "Bahamas",
                 ShortName = "BS"
             }); 
        }
    }
}
