using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace DatabaseTrial;

public class Database : DbContext
{
	private string _path = @"C:\Users\user\Documents\Berkas Daftar Kerja\Bootcamp File\Database\Database.db";
	public DbSet <Product>? products {get; set;}
	public DbSet <Category> category {get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		string connectionPath = $"Data Source = {_path}";
		optionsBuilder.UseSqlite(connectionPath);
	}
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>()
			.Property(c => c.CategoryName)
			.IsRequired()
			.HasMaxLength(15);

		modelBuilder.Entity<Category>()
		.HasKey(c => c.categoryID);
		
		if (Database.ProviderName?.Contains("Sqlite") ?? false)
		{
			modelBuilder.Entity<Product>()
			.Property(p => p.Cost)
			.HasConversion<double>();
		}
	}
}
