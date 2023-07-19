using Warzone;
using PlayersData;

class Program
{
	static void Main()
	{
		BattleArena warzone1 = new BattleArena();
		Human human1 = new Human("Alvaro", 1);
		Human human2 = new Human("Albedo", 2);
		Human human3 = new Human("Bennett", 3);
		Bot bot1 = new Bot("Bot 1", 4);
		
		warzone1.AddPlayers(human1);
		warzone1.AddPlayers(human2);
		warzone1.AddPlayers(human3);
		warzone1.AddPlayers(bot1);
		
		warzone1.ShowPlayerList();
		warzone1.CommencingBattle();
		
		string leaderboards = warzone1.ShowRanks();
		Console.WriteLine("\nLeaderboards: ");
		Console.WriteLine(leaderboards);
	}
}