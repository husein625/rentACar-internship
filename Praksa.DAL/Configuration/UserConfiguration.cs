using Microsoft.EntityFrameworkCore.Metadata.Builders;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Configuration
{
    class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Password).IsRequired();
            builder.HasOne(b => b.City).WithMany(b => b.Users).HasForeignKey(b => b.CityId);
            builder.HasMany(b => b.UserRoles).WithOne(b => b.User).HasForeignKey(b => b.UserId);

            builder.HasData(new List<User>
            {
                new User
                {
                    Id=1,
                    Name="Husein",
                    Surname="Muftic",
                    CityId=1,
                    DatOfBirth=new DateTime(1998,10,25),
                    Email="hmuftic@gmail.com",
                    Address="Odred Sretno 2",
                    Username="hmuftic",
                    Password="123123",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="hmuftic",

                },
                new User
                {
                    Id=2,
                    Name="John",
                    Surname="Eod",
                    CityId=2,
                    DatOfBirth=new DateTime(1998,04,23),
                    Email="johneod@hotmail.com",
                    Address="IM 28",
                    Username="johne",
                    Password="john123",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="hmuftic",

                }


            });
        }
    }
}
