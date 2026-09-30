public class Godzilla : Beast
{
    // This is the default constructor
    public Godzilla() : base() {}

    // Parameterized constructor for Godzilla - invokes the base parent constructor
    public Godzilla(string name, int currentHP, int maxHP) : base(name, currentHP, maxHP)
    {
        
    }
}