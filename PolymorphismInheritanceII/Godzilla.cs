public class Godzilla : Beast
{
    public Godzilla(string name, int health, int damage) : base(name, health, damage)
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
        Console.WriteLine($"{Name} attacks with Plasma Breath - Damage: {abilityAttackDamage}");

        return abilityAttackDamage;
    }

    public override bool Equals(object? obj)
    {
        // this calls the parent's Equals()
        // return base.Equals(obj);

        // this compares itself to the obj's type
        // return obj is Godzilla;

        // Logical comparison - exact values comparison, no longer a type comparison
        return obj is Godzilla objGodzilla && 
            objGodzilla.Name == Name &&
            objGodzilla.Health == Health &&
            objGodzilla.Damage == Damage;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}