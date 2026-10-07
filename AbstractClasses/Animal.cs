public abstract class Animal
{
    protected int age;
    protected string name;

    public Animal(int age, string name)
    {
        this.age = age;
        this.name = name;
    }

    // These abstract methods are to eb implemented by the subclass (child class)
    // This abstract method allows you to override it - must be implemented by child class
    public abstract string Sound();

    // This virtual method allows you to override or use it as - is
    public virtual void CelebrateBirthday()
    {
        age ++;
    }

    public override string ToString()
    {
        return $"Name: {name} - {age} years old";
    }
}