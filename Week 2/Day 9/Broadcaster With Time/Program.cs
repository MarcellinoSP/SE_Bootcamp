using BroadcastStationProgram;
public delegate void BroadcastHandler (object sender, BroadcastEventArgs e);

class Program
{
	static void Main()
	{	int messageChoices;
		Console.WriteLine("Enter your message choices (0-2): ");
		Message[] message = (Message[])Enum.GetValues(typeof(Message));
		do
		{
			messageChoices = Convert.ToInt32(Console.ReadLine());
		} while(messageChoices > (message.Length-1));
		string sendMessage = message[messageChoices].ToString();
		BroadcastStation broadcastStation = new(sendMessage);
		Broadcasters broadcasters = new("Alvaro");
		Listeners listeners1 = new();
		broadcastStation.BroadcastEvent += listeners1.ReceiveMessage;
		broadcastStation.Broadcast();
	}
}