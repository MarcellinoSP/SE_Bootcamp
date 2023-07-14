using BroadcastStationProgram;
public delegate void BroadcastHandler (object sender, BroadcastEventArgs e);

class Program
{
	static void Main()
	{	int messageChoices;
		//start:
		Console.WriteLine("Enter your message choices (0-2): ");
		Message[] message = (Message[])Enum.GetValues(typeof(Message));
		messageChoices = Convert.ToInt32(Console.ReadLine());
		//if(messageChoices > (message.Length-1)) //Method 1 using goto
		//{
		//	goto start;
		//} //Kurang Recommended
		while(messageChoices > (message.Length-1)) //Method 2 using while
		{
			Console.WriteLine("Enter your message choices (0-2): ");
			messageChoices = Convert.ToInt32(Console.ReadLine());
		}
		//Add method 3 Do While
		string sendMessage = message[messageChoices].ToString();
		
		BroadcastStation broadcastStation = new(sendMessage);
		Broadcasters broadcasters = new("Alvaro");
		Listeners listeners1 = new();
		broadcastStation.BroadcastEvent += listeners1.ReceiveMessage;
		broadcastStation.Broadcast();
	}
}