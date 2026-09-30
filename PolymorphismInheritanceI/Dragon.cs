public class Dragon : Beast
{
    // This is the default constructor
    public Dragon() : base() {}

    // Parameterized constructor for Dragon - invokes the base parent constructor
    public Dragon(string name, int currentHP, int maxHP) : base(name, currentHP, maxHP)
    {
        
    }
}