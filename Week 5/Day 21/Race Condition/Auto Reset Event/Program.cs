using System;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    private static AutoResetEvent task1Event = new AutoResetEvent(false);
    private static AutoResetEvent task3Event = new AutoResetEvent(false);

    public static void Main()
    {
        // Create tasks for Task 1, Task 2, and Task 3
        Task task1 = Task.Run(() => Task1Method());
        Task task2 = Task.Run(() => Task2Method());
        Task task3 = Task.Run(() => Task3Method());

        // Wait for Task 1 and Task 3 to complete
        Task.WaitAll(task1, task3);

        Console.WriteLine("All tasks completed.");
    }

    private static void Task1Method()
    {
        Console.WriteLine("Task 1 is waiting for the signal...");
        task1Event.WaitOne();
        Console.WriteLine("Task 1 received the signal and started its work.");
        // Task 1's work here...
        Console.WriteLine("Task 1 completed its work.");
    }

    private static void Task2Method()
    {
        Console.WriteLine("Task 2 is doing some work...");
        Thread.Sleep(2000);
        Console.WriteLine("Task 2 is signaling Task 1 and Task 3 to start.");
        task1Event.Set();
        task3Event.Set();
    }

    private static void Task3Method()
    {
        Console.WriteLine("Task 3 is waiting for the signal...");
        task3Event.WaitOne();
        Console.WriteLine("Task 3 received the signal and started its work.");
        Console.WriteLine("Task 3 completed its work.");
    }
}
