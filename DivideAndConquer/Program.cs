Queue<string> Inputs = new Queue<string>();

Thread monitor = new(Monitor);
monitor.Start();

while (true)
{
    Console.WriteLine("Enter input:");
    string? input = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(input))
        break;
    if (input?.Trim().ToLower() == "exit")
        break;

    AcceptInput(input);
}
void Monitor()
{
    Console.WriteLine($"MONITORING QUEUE ({Inputs.Count})");
    while (true)
    {
        if (Inputs.Count > 0)
        {
            Thread t = new(() => ProcessTasks(Environment.CurrentManagedThreadId));
            t.Start();
        }
    }
}
void AcceptInput(string? input)
{
    Inputs.Enqueue(input);
    Console.WriteLine($"Input accepted: {input}");
}

void ProcessTasks(int tid)
{
    // Simulate processing time
    if (Inputs.Count == 0)
        return;

    Thread.Sleep(3000);

    if (Inputs.Count > 0)
    {
        string? input = Inputs.Dequeue();
        Console.WriteLine($"Processed input: {input} [TID - {tid}]");
    }
}
