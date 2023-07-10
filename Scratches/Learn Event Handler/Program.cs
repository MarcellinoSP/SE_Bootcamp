public delegate void ButtonClickedHandler(object sender, EventArgs e);
//You should have the same Variable name between delegate and the event inside ButtonClicked

public class ButtonClicked
{
	public event ButtonClickedHandler Clicked; 
	
	public void onButtonClicked()
	{
		if(Clicked != null)
		{
			Clicked(this, EventArgs.Empty);
		}
	}
}

public class Form
{
	public void HandleButtonClick(object sender, EventArgs e)
	{
		Console.WriteLine("Button Clicked!");
	}
}

class Program
{
	static void Main()
	{
		ButtonClicked button = new ButtonClicked();
		Form form = new Form();
		button.Clicked += form.HandleButtonClick;
		button.onButtonClicked();
	}
}
