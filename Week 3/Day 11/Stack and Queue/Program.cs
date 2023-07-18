class Program
{
	static void Main()
	{
		int count;
		Stack newStack = new();
		newStack.AddToStack(5);
		newStack.AddToStack(10);
		newStack.AddToStack(3);
		do											//Tidak Valid kalau pake while, 
		{											//Karena count baru di assign setelah CheckStack
			count = newStack.CheckStack();
			int item = newStack.PopFromStack();
			Console.WriteLine($"Count: {count}");
			Console.WriteLine(item);
		}while(count > 1);
		Console.WriteLine("");
		//END OF STACK
		
		Queue newQueue = new();
		newQueue.AddToQueue(10);
		newQueue.AddToQueue(90);
		newQueue.AddToQueue(45);
		do
		{
			count = newQueue.CheckQueue();
			int item = newQueue.PopFromQueue();
			Console.WriteLine($"Count: {count}");
			Console.WriteLine(item);
		}while(count > 1);
		//END OF QUEUE
	}
}

public class Stack
{
	public Stack<int> myStack;
	public Stack()
	{
		myStack = new Stack<int>();
	}
	public void AddToStack(int number)
	{
		myStack.Push(number);
	}
	public int CheckStack()
	{
		int count = myStack.Count();
		return count;
	}
	public int PopFromStack()
	{
		int item = myStack.Pop();
		return item;
	}
}

public class Queue
{
	public Queue <int> myQueue;
	
	public Queue()
	{
		myQueue = new Queue<int>();
	}
	public void AddToQueue(int item)
	{
		myQueue.Enqueue(item);
	}
	public int CheckQueue()
	{
		int count = myQueue.Count();
		return count;
	}
	public int PopFromQueue()
	{
		int item = myQueue.Dequeue();
		return item;
	}
}