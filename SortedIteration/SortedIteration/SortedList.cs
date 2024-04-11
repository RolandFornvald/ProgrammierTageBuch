namespace SortedIteration;

public sealed class SortedList<T> : IEnumerable<T> where T : IComparable<T>
{
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;
        while (current is not null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
    
    
    private Node? _head; 

    private sealed class Node 
    {
        public Node(T data) 
        {
            Data = data;
        }

        public T Data { get; } 
        public Node? Next { get; set; } 
    }
    
    public void Add(T data)
    {
        if (_head is null) 
        {
            _head = new Node(data);

            return;
        }

        if (data.CompareTo(_head.Data) < 0) 
        {
            _head = new Node(data)
            {
                Next = _head
            };

            return;
        }

        var current = _head;
        while (current.Next is not null
               && data.CompareTo(current.Next.Data) > 0) 
        {
            current = current.Next;
        }

        current.Next = new Node(data) { Next = current.Next }; 
    }
}