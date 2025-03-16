namespace week10_1;

public class QueueException : Exception
{
    public QueueException(string message) : base(message) { }
}

public class LQueue<T>
{
    private List<T> _data = new();

    public LQueue(){ }

    public int Size => _data.Count;

    public int Capacity => _data.Capacity;

    public void Enqueue(T item)
    {
        // adds the value n to the back of the queue. 
        //Expected complexity is O(1), but may be O(n) when resizing occurs.
        _data.Add(item); 
    }

    public T Dequeue()
    {
        // Expected complexity is O(n) because of element shifting when using List<T>.
        // Throws an exception if the queue is empty.
        if (Size == 0)
            throw new QueueException("Queue is empty");

        // removes and returns a T, the value at the front of the queue.
        T front = _data[0];
        _data.RemoveAt(0); 
        return front;
    }

    public T Peek()
    {
        // Expected complexity is O(1).
        // If the queue is empty, throw an exception.
        if (Size == 0)
            throw new QueueException("Queue is empty");

        // returns the value at the front of the queue, without removing it.
        return _data[0];
    }

    public bool Contains(T item)
    {
        // returns the boolean true if the queue contains the value n. Otherwise it returns false.
        return _data.Contains(item); 
    }
}


