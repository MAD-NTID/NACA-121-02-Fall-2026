Console.WriteLine($"1 - Choice 1\n2 - Choice 2\n3 - Exit");
Console.Write("Select a Choice: ");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":   
        //  no break statement between case "1" and "2" so either "1" or "2" will have the same output
    case "2":
        Console.WriteLine("Your choice is 1 or 2");
    break;

    case "3":
        Console.WriteLine("Your choice is 3 - Exit");
    break;

    // When the results from the expression has no case match
    default:
        Console.WriteLine("Invalid Choice");
    break;
}
