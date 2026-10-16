public class Board
{
    private string[] animals = {"Fox", "Panda", "Monkey"};
    private string[] color = {"Black", "Red"};

    public Card[,] Cards { get; private set; }

    public Board ()
    {
        // 4x3
        Cards = new Card[,]
        {
            { new Card("Monkey", "Red"), new Card("Fox", "Black"), new Card("Panda", "Red") },
            { new Card("Panda", "Black"), new Card("Fox", "Red"), new Card("Monkey", "Black") },
            { new Card("Fox", "Red"), new Card("Monkey", "Red"), new Card("Panda", "Black") },
            { new Card("Panda", "Red"), new Card("Monkey", "Black"), new Card("Fox", "Black") }
        };
    }

    public void Flip(int i, int c)
    {
        // Flip the card at i and c
        Cards[i, c].ShowToggle();
    }

    public bool Match(int firstI, int firstC, int secondI, int secondC)
    {
        Card A = Cards[firstI, firstC];
        Card B = Cards[secondI, secondC];

        return A.Equals(B);
    }

    public bool AllFacingUp()
    {
        for(int i = 0; i < Cards.GetLength(0); i++)
        {
            for(int c = 0; c < Cards.GetLength(1); c++)
            {
                // if at least 1 is hidden, they are all not facing up
                if(Cards[i, c].Hide)
                    return false;
            }
        }

        // they are all facing up
        return true; 
    }

    public override string ToString()
    {
        string board = "";

        for(int i = 0; i < Cards.GetLength(0); i++)
        {
            for(int c = 0; c < Cards.GetLength(1); c++)
            {
                board += $"[{i}, {c}]{Cards[i, c]}\t";
            }

            board += $"\n";
        }

        return board;
    }
}