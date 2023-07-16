namespace BroadcastStationProgram;

public class BroadcastEventArgs : EventArgs
{
	public string broadcastSender{get; set;}
	public string broadcastMessage{get; set;}
	public string broadcastTime{get; set;}
	
	public BroadcastEventArgs(string broadcastSender, string broadcastMessage, string broadcastTime)
	{
		this.broadcastSender = broadcastSender;
		this.broadcastMessage = broadcastMessage;
		this.broadcastTime = broadcastTime;
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
	// TimeSpan
	public void ReceiveMessage(object sender, BroadcastEventArgs e)
	{
		Console.WriteLine($"Message broadcasted from: {sender.ToString()}");
		Console.WriteLine($"Broadcast message sent by: {e.broadcastSender}, message: {e.broadcastMessage}");
		Console.WriteLine($"Broadcasted on: {e.broadcastTime}");
	}
}

public class BroadcastStation
{
	//TimeSpan
	public event BroadcastHandler BroadcastEvent;
	private string _message;
	private string _time;
	
	public BroadcastStation(string message, string time)
	{
		_message = message;
		_time = time;
	}
		
	public void Broadcast()
	{
		Console.WriteLine($"Broadcasting message: {_message}");
		OnBroadcast();
	}
	protected void OnBroadcast()
	{
		BroadcastEvent?.Invoke(this, new BroadcastEventArgs("Alvaro", _message, _time));
	}
}

enum Message
{
	TestDriveBroadcasters = 1,
	BroadcastersHere,
	BroadcastersLeaving
}