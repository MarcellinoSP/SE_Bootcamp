namespace Smartphone;

public class MobilePhone
{
	public IScreen screen;
	public IProcie procie;
	private string _phoneName;
	
	public MobilePhone(IScreen screen, IProcie procie, string phoneName)
	{
		this.screen = screen;
		this.procie = procie;
		_phoneName = phoneName;
		Console.WriteLine(_phoneName);
	}
	
	public void RunPhone()
	{
		procie.runPhone();
		screen.showImage();
		screen.turnOff();
	}
}

