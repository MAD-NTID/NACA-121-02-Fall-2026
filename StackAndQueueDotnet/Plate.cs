public class Plate<T>
{
    // Stack is a LIFO (Last In First Out)
    public Stack<T> Pancakes { get; private set; }

    // A default constructor
    public Plate() 
    {
        Pancakes = new Stack<T>();
    }

    // A constructor that accepts pancakes
    public Plate(Stack<T> pancakes)
    {
        Pancakes = pancakes;
    }

    public void AddPancake(T pancake)
    {
        Pancakes.Push(pancake);
    }

    public T RemovePancake()
    {
        return Pancakes.Pop();
    }

    public int Count()
    {
        return Pancakes.Count;
    }

    public bool NotEmpty()
    {
        return Pancakes.Count > 0;
    }

    public override string ToString()
    {
        return $"Plate has {Pancakes.Count} pancakes";
    }
}