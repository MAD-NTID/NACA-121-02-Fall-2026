Console.WriteLine($"Create printer");
// Create a printer of type int with a capacity of 10
Printer<int> printerInt = new Printer<int>(10);

Console.WriteLine($"Created Printer with 10 Capacity");

printerInt.Add(1);
printerInt.Add(2);
printerInt.Add(3);

Console.WriteLine($"Job Printer {printerInt.Print()}");
Console.WriteLine($"Job Printer {printerInt.Print()}");
Console.WriteLine($"Job Printer {printerInt.Print()}");
Console.WriteLine("====================================");

Printer<string> printerString = new Printer<string>(10);
printerString.Add("Hello");
printerString.Add("World");
printerString.Add("Get Programming On!");

Console.WriteLine($"Job Printer {printerString.Print()}");
Console.WriteLine($"Job Printer {printerString.Print()}");
Console.WriteLine($"Job Printer {printerString.Print()}");
Console.WriteLine("====================================");

Printer<Item> printerItem = new Printer<Item>(10);
printerItem.Add(new Item("Coca-Cola"));
printerItem.Add(new Item("Mentos"));
printerItem.Add(new Item("Pizza"));

Console.WriteLine($"Job Printer {printerItem.Print()}");
Console.WriteLine($"Job Printer {printerItem.Print()}");
Console.WriteLine($"Job Printer {printerItem.Print()}");