Console.WriteLine("Welcome to Gracies - Get in the Line!");

Queue<string> customers = new Queue<string>();

customers.Enqueue("Abhik");
customers.Enqueue("Shamik");
customers.Enqueue("Isaiah");
customers.Enqueue("Michael");

foreach(string person in customers)
    Console.WriteLine($"{person} got in the line.");

Console.WriteLine($"The Line looks like this {customers}");

Console.WriteLine($"Get them out of the line");

int count = customers.Count;

for(int i = 0; i < count; i ++)
    Console.WriteLine($"{customers.Dequeue()} finished his business and left the line");

Console.WriteLine(customers);