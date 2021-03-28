using Microsoft.EntityFrameworkCore;
using Domain.AssessementWebAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastrucuture.AssessementWebAPI.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);            
        }
    }
}
