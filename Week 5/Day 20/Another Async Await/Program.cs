using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Start Main method.");

        // Start DoSomethingAsync as a separate task using Task.Run.
        Task doSomethingTask = Task.Run(DoSomethingAsync);

        // Perform other tasks concurrently.
        await DoSomethingElseAsync();

        // Wait for the DoSomethingAsync task to complete.
        await doSomethingTask;

        Console.WriteLine("Main method completed.");
    }

    public static async Task DoSomethingAsync()
    {
        Console.WriteLine("Start async operation.");
        await Task.Delay(2000); // Simulating an asynchronous delay of 2 seconds.
        Console.WriteLine("Async operation completed.");
    }

    public static async Task DoSomethingElseAsync()
    {
        Console.WriteLine("Start another async operation.");
        await Task.Delay(1000); // Simulating another asynchronous delay of 1 second.
        Console.WriteLine("Another async operation completed.");
    }
}
