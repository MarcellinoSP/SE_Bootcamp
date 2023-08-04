// using System.Text.Json;

// public class Pawn
// {
// 	public int X{get; set;}
// 	public int Y{get; set;}
// 	public string Name {get; set;}

// 	public Pawn(int x, int y, string name)
// 	{
// 		X = x;
// 		Y = y;
// 		Name = name;
// 	}
// 	public Pawn()
// 	{
		
// 	}
// }

// class Program
// {
// 	static void Main()
// 	{
// 		// JSON file path
// 		string jsonFilePath = "pawns.json";
		
// 		List<Pawn> pawns = new List<Pawn>
// 		{
// 			new Pawn {Name = "hello", X = 1, Y = 2},
// 			new Pawn {Name = "Hi", X = 2, Y = 1}
// 		};
// 		string json = JsonSerializer.Serialize(pawns);
		
// 		using (StreamWriter writer = new StreamWriter(jsonFilePath))
// 		{
// 			writer.Write(json);
// 		}
// 	}
// }

using System.Text.Json;

public class Position
{
	public int X { get; private set; }
	public int Y { get; private set; }

	public Position(int x, int y)
	{
		X = x;
		Y = y;
	}
}

public abstract class Piece
{
	public string Name { get; protected set; }
	public Position Position { get; protected set; }
}
public class Pawn : Piece
{
	public Pawn(int x, int y, string name)
	{
		Position = new Position(x, y);
		Name = name;
	}
}

class Program
{
	static void Main()
	{
		// JSON file path
		string jsonFilePath = "pawns.json";

		// Step 1: Read the JSON file and parse the data
		List<Pawn> pawns = new List<Pawn>();

		// Step 2 and 3: Add the new Pawn object to the data structure
		pawns.Add(new Pawn(1, 2, "P1"));
		pawns.Add(new Pawn(2, 3, "P2"));

		// Step 4: Serialize the updated data structure back to JSON format
		var options = new JsonSerializerOptions
		{
		    WriteIndented = true // Optional: Makes the output more readable
		};
		string updatedJsonData = JsonSerializer.Serialize(pawns);

		// Step 5: Write the JSON data back to the file
		using (StreamWriter streamWriter = new StreamWriter(jsonFilePath))
		{
			streamWriter.Write(updatedJsonData);
		}
	}
}
