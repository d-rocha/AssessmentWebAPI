using Microsoft.EntityFrameworkCore;
using Domain.AssessementWebAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastrucuture.AssessementWebAPI.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.Isbn).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Year).IsRequired().HasMaxLength(5);

            builder.HasOne<Author>(x => x.Author);
        }
    }
}
