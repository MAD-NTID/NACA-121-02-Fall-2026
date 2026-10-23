// // At the very basic - a Stack of Pancakes (string)
// Stack<string> pancakes = new Stack<string>();
// //              ^^ the Stack Object

// // Now we add the pancakes, let's add 10 pancakes
// Console.WriteLine($"Pancakes are being cooked and stacked onto the plate ");
// for(int i = 0; i < 10; i++)
// {
//     string name = $"Pancake {i + 1}";
//     pancakes.Push(name);

//     Console.WriteLine($"{name} has been cooked and stacked");
// }

// Console.WriteLine($"Stack of {pancakes.Count} is served");
// Console.WriteLine($"");
// Console.WriteLine($"Abhik is hungry...");

// while(pancakes.Count > 0)
// {
//     Console.WriteLine($"He is thinking of eating {pancakes.Peek()} - hmmm");

//     Console.WriteLine($"He ate {pancakes.Pop()}, yum yum");
// }

// Console.WriteLine($"He am done eating the whole stack of pancakes");

// Use the Plate and Pancake Classes
Person abhik = new Person("Abhik");
Person shamik = new Person("Shamik");
Person isaiah = new Person("Isaiah");

// Line at Gracies use Queue to serve pancakes in order
Queue<Person> people = new Queue<Person>();
people.Enqueue(shamik);
people.Enqueue(abhik);
people.Enqueue(isaiah);

Person nextPerson = people.Dequeue();
Console.WriteLine($"Next Person in line is {nextPerson.Name}");
Console.WriteLine($"{nextPerson.Name} just woke up at 2pm and he's famished. He picks 10 pancakes");

for(int i = 0; i < 10; i ++)
{
    nextPerson.PickPancake();
}
Console.WriteLine(nextPerson);
Console.WriteLine();

nextPerson = people.Dequeue();
Console.WriteLine($"{nextPerson.Name} finished working out and is super hungry. He picks 10 pancakes");

for(int i = 0; i < 10; i ++)
{
    nextPerson.PickPancake();
}

Console.WriteLine(nextPerson);
Console.WriteLine();

nextPerson = people.Dequeue();
Console.WriteLine($"{nextPerson.Name} is hungry but there are no pancakes left. Professor Michael cooks 10 more pancakes for Isaiah");

for(int i = 0; i < 10; i ++)
{
    nextPerson.PickPancake();
}

Console.WriteLine(nextPerson);
Console.WriteLine();

Console.WriteLine($"After {abhik.Name} and {shamik.Name} and {isaiah.Name} each other's plate, they decided to compete on who eats all the pancakes first.");

// Use a randomizer for randomizing who eats the next pancake
Random random = new Random();
Person winner = new Person(string.Empty);

while(  abhik.Plate.NotEmpty() && 
        shamik.Plate.NotEmpty() && 
        isaiah.Plate.NotEmpty())
{
    int choice = random.Next(1, 4);

    if(choice == 1)
    {
        abhik.EatPancake();
        Console.WriteLine(abhik);
        winner = abhik;
    }

    else if(choice == 2)
    {
        shamik.EatPancake();
        Console.WriteLine(shamik);
        winner = shamik;
    }

    else
    {
        isaiah.EatPancake();
        Console.WriteLine(isaiah);
        winner = isaiah;
    }
}

Console.WriteLine();
Console.WriteLine($"Winner: {winner.Name}");