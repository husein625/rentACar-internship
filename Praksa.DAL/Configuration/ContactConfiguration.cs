using Microsoft.EntityFrameworkCore.Metadata.Builders;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Configuration
{
    class ContactConfiguration : BaseEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.User);
        }
    }
}
