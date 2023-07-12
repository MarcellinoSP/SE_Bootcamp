namespace BroadcastStationProgram;

public class BroadcastEventArgs : EventArgs
{
	public string broadcastSender{get; set;}
	public string broadcastMessage{get; set;}
	
	public BroadcastEventArgs(string broadcastSender, string broadcastMessage)
	{
		this.broadcastSender = broadcastSender;
		this.broadcastMessage = broadcastMessage;
	}
}

public class Broadcasters
{
	public string broadcastersName {get; set;}
	
	public Broadcasters(string name)
	{
		broadcastersName = name;
	}
	public string ReturnName()
	{
		return broadcastersName;
	}
}

public class Listeners
{
	public void ReceiveMessage(object sender, BroadcastEventArgs e)
	{
		Console.WriteLine($"Message broadcasted from: {sender.ToString()}");
		Console.WriteLine($"Broadcast message sent by: {e.broadcastSender}, message: {e.broadcastMessage}");
	}
}

public class BroadcastStation
{
	public event BroadcastHandler BroadcastEvent;
	private string _message;
	
	public BroadcastStation(string message)
	{
		_message = message;
	}
		
	public void Broadcast()
	{
		Console.WriteLine($"Broadcasting message: {_message}");
		OnBroadcast();
	}
	protected void OnBroadcast()
	{
		BroadcastEvent?.Invoke(this, new BroadcastEventArgs("Alvaro", _message));
	}
}

enum Message
{
	TestDriveBroadcasters = 1,
	BroadcastersHere,
	BroadcastersLeaving
}