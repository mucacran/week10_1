namespace week10_1;

public class FunctionalTests
{
    public static void Run()
    {
        var queue = new LQueue<int>();

        Console.WriteLine("== Functional Tests ==");
        //this test
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Console.WriteLine($"Size after enqueue: {queue.Size}"); // I hope that the: 3

        Console.WriteLine($"Peek: {queue.Peek()}"); // I hope that the: 10
        Console.WriteLine($"Contains 20: {queue.Contains(20)}"); // I hope that the: True
        Console.WriteLine($"Contains 50: {queue.Contains(50)}"); // I hope that the: False

        Console.WriteLine($"Dequeue: {queue.Dequeue()}"); // I hope that the: 10
        Console.WriteLine($"Size after dequeue: {queue.Size}"); // I hope that the: 2

        // Edge Case: Take a look at the empty queue
        var emptyQueue = new LQueue<string>();
        try
        {
            emptyQueue.Peek();
        }
        catch (QueueException ex)
        {
            Console.WriteLine($"Peek on empty queue threw exception: {ex.Message}");
        }

        // Edge case: Dequeue into empty queue
        try
        {
            emptyQueue.Dequeue();
        }
        catch (QueueException ex)
        {
            Console.WriteLine($"Dequeue on empty queue threw exception: {ex.Message}");
        }
    }
}
