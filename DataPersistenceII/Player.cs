public class Player
{
    public string Name { get; private set; }
    public string Position { get; private set; }
    public int Number { get; private set; }

    public Player(string name, string position, int number)
    {
        Name = name;
        Position = position;
        Number = number;
    }

    public override string ToString()
    {
        return $"Name: {Name} - Position: {Position} - Number: {Number}";
    }
}