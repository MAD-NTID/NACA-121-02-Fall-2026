public class Character : ICharacter
{
    // Use this approach if you have validation code in properties
    private string name;
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if(!string.IsNullOrEmpty(value))
                name = value;
            else 
                name = "Undefined";
        }
    }

    // Use this approach if no validation is necessary on the property
    public int Health { get; private set; }
    
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(ICharacter target)
    {
        // start implementing the code...
    }

    public void Defend()
    {
        // start implementing the code...
    }
}