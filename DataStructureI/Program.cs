// Unfeasible approach
Node<string> chain = new("Third", 
                                    new("Second", 
                                                    new("First")
                                        )
                        );

Console.WriteLine($"Node Chain: {chain}");

// Better approach
Node<string> first = new("First");
Node<string> second = new("Second", first);
Node<string> third = new("Third", second);

Console.WriteLine($"Node Chain: {third}");

// Best approach (Use Node in a Data Structure like Stack)
Stack<string> stack = new();
stack.Push("First");
stack.Push("Second");
stack.Push("Third");

Console.WriteLine($"Stack: {stack}");

Console.WriteLine("For each: ");
foreach(string data in stack)
{
    Console.Write($"{data} --> ");
}