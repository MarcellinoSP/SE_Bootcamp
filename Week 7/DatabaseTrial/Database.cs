using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace DatabaseTrial;

public class Game : DbContext
{
	private string _path = String.Empty;
	public DbSet <Player> Players {get; set;}
	public DbSet <Piece> Piece {get; set;}
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		_path = Path.Combine(Environment.CurrentDirectory, "Database1.db");
		string pathConnection = $"Data Source = {_path}";
		optionsBuilder.UseSqlite(pathConnection);
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().Property(p => p.PlayerID).ValueGeneratedNever();
    }
}