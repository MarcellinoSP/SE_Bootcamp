class Program
{
	static void Main()
	{
		Tile tile = new();
		tile.GetPosition();
	}
}

public class Tile
{
	TilePosition position = new();
	public void GetPosition()
	{
		bool message = position.SetPosition(10, 15);
		Console.WriteLine(message.ToString());
	}

}

public class TilePosition
{
	private int _positionX;
	private int _positionY;
	
	public bool SetPosition(int sizeX, int sizeY)
	{
		_positionX = sizeX;
		_positionY = sizeY;
		return true;
	}
}