public class Item
{
    public string Name
    {
        get; private set; 
    }

    public Item(string name = "N/A")
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}