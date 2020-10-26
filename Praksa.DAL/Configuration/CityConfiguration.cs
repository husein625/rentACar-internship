using Microsoft.EntityFrameworkCore.Metadata.Builders;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Configuration
{
    class CityConfiguration : BaseEntityConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(30);
            builder.HasMany(b => b.Users).WithOne(b => b.City).HasForeignKey(b => b.CityId);
            builder.HasData(new List<City>
            {
                new City
                {
                    Id=1,
                    Name="Tuzla",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="ajdintbk",

                },
                new City
                {
                    Id=2,
                    Name="Sarajevo",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="ajdintbk",

                },
                new City
                {
                    Id=3,
                    Name="Mostar",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="ajdintbk",

                },

            });
        }
    }
}
