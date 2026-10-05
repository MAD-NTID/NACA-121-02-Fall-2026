public class Dragon : Beast
{
    public Dragon(string name, int health, int damage) : base(name, health, damage)
    {
        
    }

    public override int Attack()
    {
        int normalAttack = base.Attack();

        Console.WriteLine($"{Name} attacks - Damage: {normalAttack}");

        return normalAttack;
    }

    public override int AttackAbility()
    {
        int abilityAttackDamage = base.AttackAbility();

        // It's not encouraged to do console writeline here... FYI.
        Console.WriteLine($"{Name} attacks with Fire Breath - Damage: {abilityAttackDamage}");

        return abilityAttackDamage;
    }

    // receives genericBeast which is Beast, its name is in variable obj
    public override bool Equals(object? obj)
    {
        // this calls the parent's Equals()
        // return base.Equals(obj);

        // this compares itself to the obj's type
        // return obj is Dragon;

        // Logical comparison - exact values comparison, no longer a type comparison
        return obj is Dragon objDragon && 
            objDragon.Name == Name &&
            objDragon.Health == Health &&
            objDragon.Damage == Damage;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}