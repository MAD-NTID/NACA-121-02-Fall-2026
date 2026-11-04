using System.Collections;

public class Queue<T> : IQueue<T>, IEnumerable<T>
{
    public Node<T>? Front { get; private set; }
    public Node<T>? Back { get; private set; }

    public int Count { get; private set; }

    public Queue()
    {
        Front = null;
        Back = null;
    }

    public void Clear()
    {
        Count = 0;
        Front = null; //  By setting the top to null, delete all the chained Nodes
        Back = null;
    }

    public bool Contains(T element)
    {
        if(Front is null)
            return false; 

        // Make a copy of the Top - for integrity of Top (maintains all chained Nodes)
        // Copy of Top allows us to manipulate 
        Node<T>? copyOfFront = Front;

        // How do we travers through each Node in search of the match?
        // Abhik says Next () - Heck yeah.
        while(copyOfFront is not null)
        {
            // Check if the Data of the current Top matches element
            if(EqualityComparer<T>.Default.Equals(copyOfFront.Data, element))
                return true;

            // Otherwise, replace the top with the next Node<T> of the current Node<T>
            copyOfFront = copyOfFront.Next;
        }

        // if an element doesn't match in any of the Node<T> then you are done, doesn't exist
        return false;
    }

    public T? Dequeue()
    {
        // If the Queue is empty then simply return default there's nothing there
        if(Front is null)
            return default;

        // Get the Data from the front
        T? data = Front.Data;

        // Update the new Front with the Next of the current Front
        Front = Front.Next;

        Count --;

        return data;
    }

    public void Enqueue(T element)
    {
        // Create the Node<T> object from element
        Node<T> enqueueNode = new Node<T>(element);

        Count ++;

        // This happens only if Front or back is null 
        if(Back is null)
        {
            Front = enqueueNode;
        }
        else
        {
            Back.Next = enqueueNode;
        }

        Back = enqueueNode;
    }

    public T? Peek()
    {
        if(Front is not null)
            return Front.Data;

        return default;
    }

    public T?[] ToArray()
    {
        // Create an array of T with Count of the stack as the size
        T?[] array = new T?[Count];

        // Make a copy of the Top
        Node<T>? copyOfFront = Front;
        
        // Insert each data (the element) from each Node
        // the pointer for inserting into indexes
        int i = 0;

        while(copyOfFront is not null)
        {
            array[i ++] = copyOfFront.Data;

            copyOfFront = copyOfFront.Next;
        }

        return array;
    }

    public IEnumerator<T> GetEnumerator()
    {
        // Before we can use the Enumerator, we need to teach C# how to enumerate
        Node<T>? currentFront = Front;

        while(currentFront is not null)
        {
            if(currentFront.Data is not null)
            {
                yield return currentFront.Data;
                currentFront = currentFront.Next;   
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
        if(Front is null)
            return "null";

        // Call the ToString method of the Top Node<T>
        return Front.ToString();
    }
}