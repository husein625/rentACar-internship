using Microsoft.EntityFrameworkCore.Metadata.Builders;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Configuration
{
    class RoleConfiguration : BaseEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.HasMany(b => b.UserRoles).WithOne(b => b.Role).HasForeignKey(b => b.RoleId);
            builder.HasData(new List<Role>
            {
                new Role
                {
                    Id=1,
                    Name="Administrator",
                    CreatedAt=DateTime.Now,
                    CreatedBy="ajdintbk",

                },
                new Role
                {
                    Id=2,
                    Name="Client",
                    CreatedAt=DateTime.Now,
                    CreatedBy="ajdintbk",

                }

            });

        }
    }
}
