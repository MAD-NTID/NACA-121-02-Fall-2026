public class Gorilla : Animal
{
    public Gorilla(int age, string name) : base(age, name)
    {
    }

    public override string Sound()
    {
        return "HOO! HOO! HOO!";
    }
}