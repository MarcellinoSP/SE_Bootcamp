namespace MechanicalSwitch;

public class MechanicalSwitch{
	public string? switchType;
	public string? switchColor;
	public int? switchWeight;
	
	public MechanicalSwitch(){
		Console.WriteLine("Constructing Switch");
	}
	
	public MechanicalSwitch(string edit){
		Console.WriteLine("Editting Switch");
	}
}

public class Switch <TKey1, TKey2, TKey3>{
	public TKey1 switchType;
	public TKey2 switchColor;
	public TKey3 switchWeight;
	
	public MechanicalSwitch NewSwitchData (TKey1 type, TKey2 color, TKey3 weight){
		MechanicalSwitch switchData = new MechanicalSwitch();
		switchData.switchType = type.ToString();
		switchData.switchColor = color.ToString();
		switchData.switchWeight = Convert.ToInt32(weight);
		return switchData;
	}
	
	public MechanicalSwitch EditSwitchData (TKey1 type, TKey2 color, TKey3 weight){
		MechanicalSwitch editSwitch = new MechanicalSwitch("edit");
		editSwitch.switchType = type.ToString();
		editSwitch.switchColor = color.ToString();
		editSwitch.switchWeight = Convert.ToInt32(weight);
		return editSwitch;
	}
}