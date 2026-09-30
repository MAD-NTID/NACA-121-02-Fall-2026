public interface IBeast
{
    // Properties and methods to be implemented by the Beast class
    public string Name { get; }
    public int CurrentHP { get; }
    public int MaxHP { get; }

    
    public void TakeDamage(int damage);
    public void AbilityAttack();
}