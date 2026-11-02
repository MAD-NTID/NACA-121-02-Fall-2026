public class Node<T>
{
    /*
        Allows to store any kind of data.
        This is the data about the node itself
    */
    public T? Data { get; set; }

    /*
        Store the next node's data. (Chained data)
        This is the data about the next node
    */
    public Node<T>? Next { get; set; }

    // Constructors
    // Accepts the value for the Node itself
    // Accepts a Node<T> for the Next Node
    public Node(T? data, Node<T>? next)
    {
        Data = data;
        Next = next;
    }

    // Overloaded constructor for when you want to make an instance of Node without the Next node
    public Node(T data): this(data, null) {}

    public override string ToString()
    {
        // Show only information about itself if Next is null
        if(Next is null)
            return $"{Data} --> null";

        // Otherwise, show information about itself and next
        return $"{Data} --> {Next}";
    }
}
