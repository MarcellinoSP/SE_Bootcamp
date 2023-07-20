namespace FooBar;
using System.Text;

public class FooBarMain
{
	SortedDictionary<int, string> conditionLists = new SortedDictionary<int, string>();
	
	public string GenerateResult(int maximumValue)
	{
		StringBuilder result = new();
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
	public string AddCondition(int position, string word)
	{
		StringBuilder message = new();
		bool result = CheckCondition(position);
		if(result)
		{
			message.Append("Number already exist!");
		}
		else
		{
			conditionLists.Add(position, word);
			message.Append("New condition successfully added");
		}
		return message.ToString();
	}
	public string RemoveCondition(int removePosition)
	{
		StringBuilder message = new();
		bool result = CheckCondition(removePosition);
		if(!result)
		{
			message.Append("Number doesn't exist on current list");
		}
		else
		{
			conditionLists.Remove(removePosition);
			message.Append("Condition successfully removed!");
		}
		return message.ToString();
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