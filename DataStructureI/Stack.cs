using System.Collections;

public class Stack<T> : IStack<T>, IEnumerable<T>
{
    // Keeps the count of the stack
    public int Count { get; private set; }

    // Keep the top of the node at Top
    public Node<T>? Top { get; private set; }

    public Stack()
    {
        Count = 0; 
        Top = null;
    }

    public void Clear()
    {
        Count = 0;
        Top = null; //  By setting the top to null, delete all the chained Nodes
    }

    public bool Contains(T element)
    {
        if(Top is null)
            return false; 

        // Make a copy of the Top - for integrity of Top (maintains all chained Nodes)
        // Copy of Top allows us to manipulate 
        Node<T>? copyOfTop = Top;

        // How do we travers through each Node in search of the match?
        // Abhik says Next () - Heck yeah.
        while(copyOfTop is not null)
        {
            // Check if the Data of the current Top matches element
            if(EqualityComparer<T>.Default.Equals(copyOfTop.Data, element))
                return true;

            // Otherwise, replace the top with the next Node<T> of the current Node<T>
            copyOfTop = copyOfTop.Next;
        }

        // if an element doesn't match in any of the Node<T> then you are done, doesn't exist
        return false;
    }

    // Returns the Data of the Top Node without removing it
    public T? Peek()
    {
        if(Top is not null)
            return Top.Data;

        return default;
    }

    public T? Pop()
    {
        if(Top is null)
            return default;

        // First get the data at the top
        T? currentTopData = Top.Data;

        //  Replace the top with the next Node<T> of the current Node<T>
        Top = Top.Next;

        // Reduce the count by 1
        Count--;

        // Return the data (element)
        return currentTopData;
    }

    public void Push(T element)
    {
        // Element in the parameter 'element' will become the new Top
        // Before doing that, let's make a copy of the current Top
        Node<T>? currentTop = Top;

        // Create the new Node with element as the data and its Next<T> as currentTop
        Node<T>? newNode = new(element, Top);

        // Make the newly created node the new Top - remember (newNode holds data about its previous Top - all chained nodes)
        Top = newNode;

        // Increment the count by 1
        Count ++;
    }

    public T?[] ToArray()
    {
        // Create an array of T with Count of the stack as the size
        T?[] array = new T?[Count];

        // Make a copy of the Top
        Node<T>? copyOfTop = Top;
        
        // Insert each data (the element) from each Node
        // the pointer for inserting into indexes
        int i = 0;

        while(copyOfTop is not null)
        {
            array[i ++] = copyOfTop.Data;

            copyOfTop = copyOfTop.Next;
        }

        return array;
    }

    public IEnumerator<T> GetEnumerator()
    {
        // Before we can use the Enumerator, we need to teach C# how to enumerate
        Node<T>? currentTop = Top;

        while(currentTop is not null)
        {
            if(currentTop.Data is not null)
            {
                yield return currentTop.Data;
                currentTop = currentTop.Next;   
            }
            else
                break;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() 
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        if(Top is null)
            return "null";

        // Call the ToString method of the Top Node<T>
        return Top.ToString();
    }
}