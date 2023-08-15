#define QUERY
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using DatabaseTrial;

//OVERALL UNHANDLED TERJADI KARENA PENAMAAN
//BETTER SAMAKAN NAMA TIAP ENTITY DENGAN DATABASE
class Program
{
	static void Main()
	{
		#if ADD
		using(Game database = new Game())
		{
			Player player1 = new Player
			{
				PlayerName = "Aether",
				PlayerColor = "White",
				PlayerID = 1
			};
			Player player2 = new Player
			{
				PlayerName = "Lumime",
				PlayerColor = "Black",
				PlayerID = 2
			};
			database.Players.Add(player1);
			database.Players.Add(player2);
			database.SaveChanges();
		}
		#elif QUERY
		using (Game database = new Game())
		{
			Console.WriteLine("Checking pieces associated with players");
			
			IQueryable<Player>? playerPieces = database.Players
												.Include(p => p.Piece);
			if (playerPieces == null)
			{
				Console.WriteLine("Null");
				return;
			}
			foreach(var data in playerPieces)
			{
				Console.WriteLine($"{data.PlayerName} has {data.Piece.Count()}");
			}
		}
		#elif TEST
		Database db1 = new();
		Console.WriteLine(database.Database.CanConnect());
		Console.WriteLine(db1.Database.ProviderName);
		#endif
	}
}