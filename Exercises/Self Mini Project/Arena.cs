using PlayersData;
using System.Text;
namespace Warzone;

public class BattleArena
{
	List <Players> playerLists;
	public BattleArena()
	{
		playerLists = new List <Players>();
	}
	public void AddPlayers(Players data)
	{
		playerLists.Add(data);
		Console.WriteLine($"Player {data.playerName} join to arena");
	}
	public void RemovePlayers(Players data)
	{
		playerLists.Remove(data);
		Console.WriteLine($"Player {data.playerName} removed from arena");
	}
	public void ShowPlayerList()
	{
		Console.WriteLine("\nPlayer List: ");
		foreach (var player in playerLists)
		{
			Console.WriteLine(player.playerName);
		}
	}
	public void CommencingBattle()
	{
		Console.WriteLine();
		foreach(var player in playerLists)
		{
			Random score = new Random();
			player.playerScore = score.Next(0, 51);
			Console.WriteLine($"{player.playerName} have score: {player.playerScore}");
		}
	}
	public string ShowRanks()
	{
		StringBuilder ranks = new();
		var sortedRank = playerLists.OrderByDescending(playerLists => playerLists.playerScore);
		foreach(var playerRanks in sortedRank)
		{
			ranks.AppendLine(playerRanks.playerName);
		}
		return ranks.ToString();
	}
}