public interface IStack<T>
{
    // Info of Data Structure: Contains, count, clear, ToArray
    public int Count { get; }
    public bool Contains (T element);
    public void Clear();
    public T?[] ToArray();
    
    // Stack Specific Behaviors: push, pop, peek
    public Node<T>? Top { get; }
    public void Push(T element);
    public T? Peek();
    public T? Pop();
}