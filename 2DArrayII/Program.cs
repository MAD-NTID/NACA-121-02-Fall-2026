Board board = new Board();

while(true)
{
    // Show the board
    Console.WriteLine(board);

    // Ask for the coordinates for 1st card
    Console.WriteLine("Enter row for first card: ");
    int firstI = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter col for first card: ");
    int firstC = int.Parse(Console.ReadLine());

    board.Flip(firstI, firstC);

    Console.WriteLine("Enter row for second card: ");
    int secondI = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter col for second card: ");
    int secondC = int.Parse(Console.ReadLine());

    board.Flip(secondI, secondC);

    // Show the board
    Console.WriteLine(board);

    bool match = board.Match(firstI, firstC, secondI, secondC);
    Console.WriteLine($"[{firstI}, {firstC}] == [{secondI}, {secondC}] >> {match}");
    Console.ReadLine();

    // If there's no match, flip hide again
    if(!match)
    {
        board.Flip(firstI, firstC);
        board.Flip(secondI, secondC);
    }

    // Check if game is over
    if(board.AllFacingUp())
        break;
}

Console.WriteLine("You won! Thank you for playing with us");