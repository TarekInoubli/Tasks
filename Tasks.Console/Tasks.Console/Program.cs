Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started");

// 1. Using Task Class
//Task task1 = new Task(PrintCounter);
//task1.Start();

// 2. Using Factory
//Task task1 = Task.Factory.StartNew(PrintCounter);

// 3. Using Run method
Task task1 = Task.Run(PrintCounter);

Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
Console.ReadKey();

static void PrintCounter()
{
    Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
    for (int count = 1; count <= 5; count++)
    {
        Console.WriteLine($"count value: {count}");
    }
    Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
}