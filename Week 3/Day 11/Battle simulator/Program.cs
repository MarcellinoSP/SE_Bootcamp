class Program
{
	static void Main()
	{
		BattleArena inazumaArena = new();
		Human player1 = new("Albedo", 1);
		Human player2 = new("Aether", 2);
		Bot player3 = new("Bot1", 4);
		
		Console.WriteLine("");
		inazumaArena.AddPlayer(player1);
		inazumaArena.AddPlayer(player2);
		inazumaArena.AddPlayer(player3);
		
		inazumaArena.ShowPlayerList();
		inazumaArena.StartBattle();
		inazumaArena.ShowLeaderboards();
	}
}

public class BattleArena
{
	public List <Player> playerList;
	public BattleArena()
	{
		playerList = new List<Player>();
	}
	public void ShowPlayerList()
	{
		for(int i = 0; i < playerList.Count(); i++)
		{
			Console.WriteLine($"Participant List: {playerList[i].name}");
		}
	}
	public void AddPlayer(Player playerProperty)
	{
		playerList.Add(playerProperty);
	}
	public void StartBattle()
	{
		for(int i = 0; i < playerList.Count(); i++)
		{
			Random score = new();
			playerList[i].score = score.Next(0, 101);
			Console.WriteLine(playerList[i].score);
		}
	}
	public void ShowLeaderboards()
	{
		var sortedRank = playerList.OrderByDescending(playerList => playerList.score);
		int rank = 1;
		
		foreach(Player player in sortedRank)
		{
			Console.WriteLine(player.name);
			rank++;
		}
	}
}

public class Player
{
	public string name {get; set;}
	public int playerId {get; set;}
	public int score;
	
	public Player(string name, int playerId)
	{
		this.name = name;
		this.playerId = playerId;
	}
}

public class Human : Player
{
	public Human(string name, int playerId) : base(name, playerId)
	{
		Console.WriteLine("Creating Human as a Player...");
	}
}

public class Bot : Player
{
	public Bot(string name, int playerId) : base(name, playerId)
	{
		Console.WriteLine("Creating Bot as a Player...");
	}
}