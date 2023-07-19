namespace PlayersData;

public class Players
{
	public string? playerName{get; set;}
	public int playerID{get; set;}
	public int playerScore;
	
	public Players(string playerName, int playerID)
	{
		this.playerName = playerName;
		this.playerID = playerID;
	}
}

public class Bot : Players
{
	public Bot(string playerName, int playerID) : base (playerName, playerID)
	{
		Console.WriteLine($"Bot join into the game {playerName}");
	}
}

public class Human : Players
{
	public Human(string playerName, int playerID) : base (playerName, playerID)
	{
		Console.WriteLine($"Human join into the game: {playerName}");
	}
}