
public class Bird : Animal
{
    public Bird(int age, string name) : base(age, name)
    {
        
    }

    public override void CelebrateBirthday()
    {
        age += 11;
    }

    public override string Sound()
    {
        return "chip chip chip";
    }
}