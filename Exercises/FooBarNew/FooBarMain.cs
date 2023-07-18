namespace FooBar;

public class FooBarMain
{
	SortedDictionary<int, string> conditionLists = new SortedDictionary<int, string>();
	string? result;
	
	public string GenerateResult(int maximumValue)
	{
		for(int i = 0; i <= maximumValue; i++)
		{
			string tempResult = "";
			if(i == 0)
			{
				tempResult += i.ToString();
			}else
			{
				foreach(KeyValuePair<int, string> conditions in conditionLists)
				{
					if(i % conditions.Key == 0)
					{
						tempResult += conditions.Value;
					}
				}
			}
			if(string.IsNullOrEmpty(tempResult))
			{
				tempResult += i.ToString();
			}
			result += tempResult + " ";
		}
		return result;
	}

	public void AddCondition(int position, string word)
	{
		if(CheckDuplicate == true)
		{
			Console.WriteLine("Condition already exist!");
		}else
		{
			conditionLists.Add(position, word);
		}
	}
	
	public void RemoveCondition(int removePosition)
	{
		conditionLists.Remove(removePosition);
	}
	
	private bool CheckDuplicate(int position)
	{
		bool checkCondition = conditionLists.ContainsKey(position);
		return checkCondition;
	}
}