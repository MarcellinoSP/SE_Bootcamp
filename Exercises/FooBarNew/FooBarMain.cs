namespace FooBar;
using System.Text;

public class FooBarMain
{
	SortedDictionary<int, string> conditionLists = new SortedDictionary<int, string>();
	StringBuilder message = new();
	StringBuilder result = new();
	
	public string GenerateResult(int maximumValue)
	{
		for(int i = 0; i <= maximumValue; i++)
		{
			StringBuilder tempResult = new();
			if(i == 0)
			{
				tempResult.Append(i.ToString());
			}else
			{
				foreach(KeyValuePair<int, string> conditions in conditionLists)
				{
					if(i % conditions.Key == 0)
					{
						tempResult.Append(conditions.Value);
					}
				}
			}
			if(string.IsNullOrEmpty(tempResult.ToString()))
			{
				tempResult.Append(i.ToString());
			}
			result.Append(tempResult + " ");
		}
		return result.ToString();
	}
	public void AddCondition(int position, string word)
	{
		bool result = CheckCondition(position);
		if(result)
		{
			message.Append("Number already exist!");
			Console.WriteLine(message.ToString());
		}
		else
		{
			conditionLists.Add(position, word);
		}
	}
	public void RemoveCondition(int removePosition)
	{
		bool result = CheckCondition(removePosition);
		if(!result)
		{
			message.Append("Number doesn't exist on current list");
			Console.WriteLine(message.ToString());
		}
		else
		{
			conditionLists.Remove(removePosition);	
		}
	}
	private bool CheckCondition(int position)
	{
		bool conditionResult = conditionLists.ContainsKey(position);
		return conditionResult;
	}
	public string PrintConditionList()
	{
		string list = "";
		foreach(KeyValuePair <int, string> condition in conditionLists)
		{
			list += (condition.Key + ": ");
			list += (condition.Value + "\n");
		}
		return list;
	}
}