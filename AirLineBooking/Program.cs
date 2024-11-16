using Entities.Models;
#region DESIGN
// Ticket buying process is within a critical section
// Tickets are based on available seats
// The plane has 12 seats available
// Seats are numbered as six rows and AB and CD seats for each row
// User can buy a ticket
// User can cancel a ticket
// For each input iteration, display the available seats
// To book a seat a user must enter their name and seat number
// To cancel a seat a user must enter their name and seat number
// The user must enter their name and seat number separated by a comma
// The ticket booking process is attempted immediately after the user enters their name and seat number
// The ticket booking process is a critical section
#endregion
// Create finite set of tickets

List<AirlineTicket
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
