public class Beast : IBeast
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public int CurrentHealth { get; private set; }

    public int Damage { get; private set; }

    public Beast(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        CurrentHealth = health;
        Damage = damage;
    }

    public virtual int Attack()
    {
        // Return the damage that this beast can cause - add a 15% chance of attacking 'critically'
        Random random = new Random();

        if(random.Next(0, 101) > 85)
        {
            double extraDamage = 1 + (random.Next(1, 6) / 100.0);
            extraDamage *= Damage;

            Console.WriteLine($"{Name} critical attacks - Damage: {(int) extraDamage}");

            return (int) extraDamage;
        }

        // Otherwise, return regular damage power
        Console.WriteLine($"{Name} normal attacks - Damage: {Damage}");

        return Damage;
    }

    /**
        Add the keyword 'virtual' before the type. This makes the method overridable by the child class. 
        Meaning, you provide flexibility to the child classes to Override and do different behaviors and still 
        honor Inheritance rules.
    **/
    public virtual int AttackAbility()
    {
        /**
        Ability attack deals 15% - 20% (randomized) more damage than a physical attack.
            Dragon uses “Fire Breath”
            Godzilla throws “Spikes”
        **/
        Random random = new Random();

        // We'll need to convert this to percentage
        double attackPower = 1 + (random.Next(15, 21) / 100.0);

        // Conver this to an integer
        return (int) (Damage * attackPower);
    }

    public void TakeDamage(int damage)
    {
        // Reduce the current health from the damage taken by the opponent
        CurrentHealth -= damage;
    }

    public override string ToString()
    {
        return  $"Type: {base.ToString()}\n" +
                $"Name: {Name}\n" + 
                $"Health: {CurrentHealth}/{Health}\n" + 
                $"Damage: {Damage}";
                
    }

    public override bool Equals(object? obj)
    {
        // Checks if object being passed is a child of Beast (this Beast class)
        return obj is Beast;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}