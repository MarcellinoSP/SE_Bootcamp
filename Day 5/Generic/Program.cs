namespace MechanicalSwitch;

class Program{
	static void Main(){
		Switch<string, string, int> newDataSwitch = new Switch<string, string, int>();
		MechanicalSwitch dataSwitch = newDataSwitch.NewSwitchData("Outemu", "Red", 40);
		Console.WriteLine(dataSwitch.switchType);
		Console.WriteLine(dataSwitch.switchColor);
		Console.WriteLine(dataSwitch.switchWeight);

		Console.Write("\n");
		
		Switch<string, string, int> editDataSwitch = new Switch<string, string, int>();
		MechanicalSwitch editSwitch = editDataSwitch.EditSwitchData("CherryMX", "Blue", 45);
		editDataSwitch.switchType = dataSwitch.switchType;							//Using Old Switch Type
		editDataSwitch.switchColor = dataSwitch.switchColor;						//Using Old Switch Color
		editDataSwitch.switchWeight = Convert.ToInt32(dataSwitch.switchWeight);		//Using Old Switch Weight
		Console.WriteLine("Old switch type: " + editDataSwitch.switchType);
		Console.WriteLine("Old switch color: " + editDataSwitch.switchColor);
		Console.WriteLine("Old switch weight: " + editDataSwitch.switchWeight);
		Console.WriteLine("Change of switch");
		Console.WriteLine("New switch type :" + editSwitch.switchType);
		Console.WriteLine("New switch type :" + editSwitch.switchColor);
		Console.WriteLine("New switch type :" + editSwitch.switchWeight);
	}
}