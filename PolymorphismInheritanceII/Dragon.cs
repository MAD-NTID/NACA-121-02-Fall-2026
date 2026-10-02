public class Dragon : Beast
{
    public Dragon(string name, int health, int damage) : base(name, health, damage)
    {
        
    }

    public override int AttackAbility()
    {
        int abilityAttackDamage = base.AttackAbility();

        // It's not encouraged to do console writeline here... FYI.
        Console.WriteLine($"{Name} attacks with Fire Breath - Damage: {abilityAttackDamage}");

        return abilityAttackDamage;
    }
}