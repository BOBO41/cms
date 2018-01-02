using cms.Data.EF.Extensions;
using cms.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cms.Data.EF.Configurations
{
    public class PostTagConfiguration : DbEntityConfiguration<PostTag>
    {
        public override void Configure(EntityTypeBuilder<PostTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasColumnType("varchar(50)");
        }
    }
}
