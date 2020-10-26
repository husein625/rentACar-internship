using Microsoft.EntityFrameworkCore.Metadata.Builders;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Configuration
{
    class CarConfiguration : BaseEntityConfiguration<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.NumberOfDoors).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.HorsePower).IsRequired();
            builder.HasOne(p => p.Color);
        }
    }
}
