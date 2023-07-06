namespace Smartphone;

public class MobilePhone
{
	public IScreen screen;
	public IProcie procie;
	
	public MobilePhone(IScreen screen, IProcie procie)
	{
		this.screen = screen;
		this.procie = procie;
	}
	
	public void RunPhone()
	{
		procie.runPhone();
		screen.showImage();
		screen.turnOff();
	}
}

