using Smartphone;
class Program
{
	static void Main()
	{
		Amoled amoledScreen = new Amoled();
		IPS IPSScreen = new IPS();
		RetinaScreen retinaScreen = new RetinaScreen();
		Mediatek mediatekPrcoie = new Mediatek();
		Snapdragon snapdragonProcie = new Snapdragon();
		Bionic binoicProcie = new Bionic();
		
		MobilePhone Samsung = new(amoledScreen, snapdragonProcie, "Samsung");
		Samsung.RunPhone();
		Console.WriteLine("\n");
		//End of Samsung Phone
		MobilePhone Xiaomi = new(IPSScreen, snapdragonProcie, "Xiaomi");
		Xiaomi.RunPhone();
		Console.WriteLine("\n");
		//End of Xiaomi Phone
		MobilePhone IPhone = new(retinaScreen, binoicProcie, "IPhone");
		IPhone.RunPhone();
		Console.WriteLine("\n");
		//End of Iphone
	}
}