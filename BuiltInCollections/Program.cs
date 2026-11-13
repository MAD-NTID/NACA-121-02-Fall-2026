using System.Collections.Generic;

// List<T>
List<int> favoriteNumbers =
[
    // Add Favorite Numbers
    5,
    1,
    3,
    5,
];

Console.WriteLine(  $"List is Simple - Grows and Shrink automatically\n" +
                    $"Values are indexed - Favorite Number at Index 0 {favoriteNumbers[0]} == 5");

Console.WriteLine(  $"Has Insert Capabilities. Insert 10 at Index 1 which pushes down the values\n");
favoriteNumbers.Insert(1, 10);

Console.WriteLine(  $"Value at index 1 is {favoriteNumbers[1]} == 10");

Console.WriteLine(  $"Unsorted:");
foreach(int num in favoriteNumbers)
    Console.Write($"{num},");
Console.WriteLine();

favoriteNumbers.Sort();
Console.WriteLine(   $"Sorted:");
foreach(int num in favoriteNumbers)
    Console.Write($"{num},");
Console.WriteLine();

Console.WriteLine("==============Dictionary===============");
Dictionary<string, string> userIDs = new();

userIDs.Add("123123", "Abhik");
userIDs.Add("123124", "Shamik");
userIDs.Add("123125", "Isaiah");

// Safe Search - Won't Crash (boolean)
if(userIDs.TryGetValue("123125", out string? Name))
{
    Console.WriteLine($"Found name for userId '123125' is {Name}");    
}
else
{
    Console.WriteLine($"Could not fin name for user id '123125'");
}

Stack<string> pringles = new();
pringles.Push($"Chip 1");
pringles.Push($"Chip 2");
pringles.Push($"Chip 3");

Console.WriteLine(pringles.Pop());
Console.WriteLine(pringles.Pop());
Console.WriteLine(pringles.Pop());

try
{
    Console.WriteLine(pringles.Pop());    
} catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Queue<string> customers = new();
customers.Enqueue($"Customer 1");
customers.Enqueue($"Customer 2");
customers.Enqueue($"Customer 3");

Console.WriteLine(customers.Dequeue());
Console.WriteLine(customers.Dequeue());
Console.WriteLine(customers.Dequeue());

try
{
    Console.WriteLine(customers.Dequeue());    
} catch(Exception e)
{
    Console.WriteLine(e.Message);
}

HashSet<string> uniqueHashSet = new();

uniqueHashSet.Add("Hello World");
uniqueHashSet.Add("Hello World");
uniqueHashSet.Add("Hello World");
uniqueHashSet.Add("Hello World");

Console.WriteLine($"Added 'Hello World' 4 times. How long is the hashset? {uniqueHashSet.Count}");