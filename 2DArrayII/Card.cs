public class Card
{
    public string? Animal { get; private set; }
    public string? Color { get; private set; }
    private bool hide;
    public bool Hide
    {
        get
        {
            return hide;
        }
    }

    public Card(string? animal, string? color)
    {
        Animal = animal;
        Color = color;
        hide = true;
    }

    public void ShowToggle()
    {
        hide = !hide;
    }

    public override bool Equals(object? obj)
    {
        return obj is Card card &&
            card.Animal == Animal &&
            card.Color == Color;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return !hide ? $"{Animal} - {Color}" : "hidden";
    }
}