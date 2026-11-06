IDictionary<string, string> dictionary = new Dictionary<string, string>();

Console.WriteLine($"Hashes for keys");
Console.WriteLine($"'banana' {dictionary.GetIndex("banana")}");
Console.WriteLine($"'car' {dictionary.GetIndex("car")}");
Console.WriteLine($"'computer' {dictionary.GetIndex("computer")}");
Console.WriteLine($"'fruit' {dictionary.GetIndex("fruit")}");
Console.WriteLine($"'table' {dictionary.GetIndex("table")}");

dictionary.Add("banana", "a yellow fruit");
dictionary.Add("car", "a vehicle with 4 wheels");
dictionary.Add("computer", "a device that computes");
dictionary.Add("fruit", "a sweet thing to eat");
dictionary.Add("table", "a platform to putt stuff");

Console.WriteLine(dictionary);