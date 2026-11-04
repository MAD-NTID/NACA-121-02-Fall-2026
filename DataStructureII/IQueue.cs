public interface IQueue<T>
{
    public int Count { get; }           //  Same for stack
    public bool Contains(T element);    //  Same for stack
    public T? Dequeue();
    public void Enqueue(T element);
    public T?[] ToArray();               //  Same for stack
    public void Clear();                //  Same for stack
    public T? Peek();                    //  Same for stack
}