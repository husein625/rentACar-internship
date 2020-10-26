using Microsoft.EntityFrameworkCore.Metadata.Builders;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Configuration
{
    class UserRoleConfiguration : BaseEntityConfiguration<UserRoles>
    {
        public override void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.User);
            builder.HasOne(p => p.Role);

            builder.HasData(new List<UserRoles>
            {
                new UserRoles
                {
                    Id=1,
                     CreatedAt=DateTime.Now,
                    CreatedBy="hmuftic",
                    RoleId=1,
                    UserId=1
                },
                new UserRoles
                {
                    Id=2,
                     CreatedAt=DateTime.Now,
                    CreatedBy="hmuftic",
                    RoleId=2,
                    UserId=2
                }


            });
        }      
    }
}
