using System.Threading.Tasks;
class Program
{
	static void Main()
	{
		Task<int> task1 = Task.Run(() => Add(5, 10));
		
		int result = task1.Result;
		Console.WriteLine(result);
	}
	
	static int Add(int x, int y)
	{
		return x + y;
	}
}