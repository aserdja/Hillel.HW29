using HW29.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HW29.DAL.Data
{
	public class AppDbContext : DbContext
	{
		public virtual DbSet<Car> Cars => Set<Car>();
		public virtual DbSet<Product> Products => Set<Product>();
		public virtual DbSet<CarShowroom> CarShowrooms => Set<CarShowroom>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HW29Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>()
				.HasKey(c => c.Id);
			modelBuilder.Entity<Product>()
				.HasKey(p => p.Id);
			modelBuilder.Entity<CarShowroom>()
				.HasKey(cs => cs.Id);

			modelBuilder.Entity<Car>()
				.Property(c => c.Model)
				.IsRequired();

			modelBuilder.Entity<Car>()
				.Property(c => c.Brand)
				.IsRequired();
			
			modelBuilder.Entity<Product>()
				.Property(p => p.Price)
				.IsRequired();

			modelBuilder.Entity<CarShowroom>()
				.Property(cs => cs.Name)
				.IsRequired();

			modelBuilder.Entity<CarShowroom>()
				.Property(cs => cs.Address)
				.IsRequired();


			modelBuilder.Entity<Product>()
				.HasOne<Car>(p => p.Car)
				.WithOne();

			modelBuilder.Entity<CarShowroom>()
				.HasMany<Product>(cs => cs.Products)
				.WithOne();
		}
	}
}
