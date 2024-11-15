int counter = 0;
object lockObject = new();

Thread thread1 = new(() => IncrementCounter());
Thread thread2 = new(() => IncrementCounter());
thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();

Console.WriteLine(counter);

void IncrementCounter()
{
    for (int i = 0; i < 100000; i++)
    {
        lock (lockObject)
        {
            counter++;
        }
    }
}
