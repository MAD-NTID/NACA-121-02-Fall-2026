public class Beast : IBeast
{
    public string Name { get; private set; }
    public int CurrentHP { get; private set; }
    public int MaxHP { get; private set; }

    public Beast()
    {
        // Default name
        Name = "No Name";
    }

    public Beast(string name, int currentHP, int maxHP)
    {
        Name = name;
        CurrentHP = currentHP;
        MaxHP = maxHP;
    }

    public void AbilityAttack()
    {
        throw new NotImplementedException();
    }

    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        // Return the type for this class
        return $"{GetType()} is a {GetType().BaseType} - Name: {Name} - Health: {CurrentHP}/{MaxHP}";
    }
}