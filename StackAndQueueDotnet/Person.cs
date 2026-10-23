public class Person
{
    public string Name { get; private set; }
    public Plate<string> Plate { get; private set; }

    public Person(string name)
    {
        Name = name;
        Plate = new Plate<string>();
    }

    // We need a method for the person to add a pancake to their plate
    public void PickPancake()
    {
        Plate.AddPancake($"Pancake");
    }

    public void EatPancake()
    {
        Console.WriteLine($"{Name} ate {Plate.RemovePancake()}");
    }

    public void EatAll()
    {
        while(Plate.NotEmpty())
        {
            EatPancake();
        }
    }

    public override string ToString()
    {
        return $"{Name} has a plate with {Plate.Count()}";
    }
}