public class Game
{
    const int DEFAULT_CHARACTER_SIZE = 3000;

    private ICharacter[] characters;
    // Approach #2 - Use a Property for Get
    public ICharacter[] Characters { get; }

    public Game()
    {
        characters = new ICharacter[DEFAULT_CHARACTER_SIZE];
    }

    public Game(int size = DEFAULT_CHARACTER_SIZE)
    {
        // Some Validation is Always Good
        if(size <= 0)
            size = DEFAULT_CHARACTER_SIZE;

        characters = new ICharacter[size];
    }

    public void AddCharacter(ICharacter character)
    {
        // do implementation code
    }

    public void RemoveCharacter(ICharacter character)
    {
        // do implementation code
    }

    // Approach #1 - Getter Method
    public ICharacter[] GetCharacters()
    {
        return characters;
    }

    public ICharacter GetCharacter(ICharacter character)
    {
        // do implementation code - must return an ICharacter for this one method
        throw new NotImplementedException();
    }
}