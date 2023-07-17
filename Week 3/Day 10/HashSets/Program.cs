class Program
{
	static void Main()
	{
		HashSetsClass newHashSet = new();
		int value = 25;
		int checkMember = 500;
		for(int i = 0; i <= 5; i ++){
			newHashSet.AddHashSet(value);
			value += value*i;
		}
		foreach(var member in newHashSet.hashSet)
		{
			Console.Write($"{member} ");
		}
		Console.WriteLine(" ");
		
		int hashSetMember = newHashSet.CheckHashSetMember();
		Console.WriteLine($"Total HashSet Member: {hashSetMember}");
		
		bool result = newHashSet.CheckAvailableMember(checkMember);
		Console.WriteLine($"Check availibility of 500: {result}");
		
		newHashSet.AddHashSet(500);
		bool result2 = newHashSet.CheckAvailableMember(checkMember);
		Console.WriteLine($"Check new availbility of 500: {result2}");
		
		newHashSet.hashSet.Clear();
	}
}

class HashSetsClass
{
	public HashSet<int> hashSet = new HashSet<int>();
	
	public void AddHashSet(int number)
	{
		hashSet.Add(number);
	}
	public int CheckHashSetMember()
	{
		int member = hashSet.Count();
		return member;
	}
	public bool CheckAvailableMember(int memberCheck)
	{
		bool result = hashSet.Contains(500);
		return result;
	}
}