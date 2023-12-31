﻿using System;
using System.Threading.Tasks;

static class Program
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("Main Method Started");
		Task task1 = null;
		Task task2 = null;

		task1 = Task.Run(async () =>
		{
			Console.WriteLine("Task 1 started");
			await Task.Delay(1000);
			
			// await task2;	//TURN THIS OFF TO REMOVE DEADLOCK

			Console.WriteLine("Task 1 waiting for Task 2");
		});
		
		task2 = Task.Run(async () =>
		{
			Console.WriteLine("Task 2 started");
			await Task.Delay(1000);
			
			// await task1;	//TURN THIS OFF TO REMOVE DEADLOCK

			Console.WriteLine("Task 2 waiting for Task 1");
		});

		await Task.WhenAll(task1, task2);

		Console.WriteLine("All tasks completed");
		Console.ReadKey();
	}
}