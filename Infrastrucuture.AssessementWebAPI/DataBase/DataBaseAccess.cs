using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Domain.AssessementWebAPI.Entities;
using Infrastrucuture.AssessementWebAPI.Mapping;

namespace Infrastrucuture.AssessementWebAPI.DataBase
{
    public class DataBaseAccess : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(x => { x.AddConsole(); });

        public DataBaseAccess(DbContextOptions<DataBaseAccess> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
