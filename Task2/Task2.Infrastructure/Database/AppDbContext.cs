using Task2.Core;
using Task2.Core.Base;

namespace Task2.Infrastructure.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Person> People { get; set; } = null!;
    public DbSet<Transaction> Transactions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>(e =>
        {
            e.HasKey(p => p.Id);
            e.Property(p => p.Version).IsConcurrencyToken();

            e
                .Property(p => p.Id)
                .HasConversion(p =>
                        p.Value,
                    guid => new AggregateId(guid));
            
            e.HasData(Data.People);
        });

        modelBuilder.Entity<Transaction>(e =>
        {
            e
                .Property(p => p.Id)
                .HasConversion(p =>
                        p.Value,
                    guid => new AggregateId(guid));
            
            e.HasKey(t => t.Id);
            e
                .HasOne(t => t.Person)
                .WithMany(p => p.Transactions)
                .HasForeignKey(t => t.PersonId);
            e.Property(p => p.Version).IsConcurrencyToken();

            e.HasData(Data.Transactions);
        });
    }
}