namespace SortedIteration;

public interface IEnumerable<T>
{
    public IEnumerator<T> GetEnumerator();
    
}