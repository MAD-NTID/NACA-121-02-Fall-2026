using System.Dynamic;

public class Ship
{
    public int Distance { get; private set; } // easiest and fastest to write (readonly)

    public int WarpSpeed { get; private set; }

    public string Name { get; private set; }

    const int INITIAL_ALIEN_CAPACITY = 10;
    const string DEFAULT_SHIP_NAME = "Unidentified Flying Object";

    private Alien[] crew; 

    private int totalCrew;
    public int TotalCrew 
    { 
        get { return totalCrew; }
    }

    public Ship()
    {
        crew = new Alien[INITIAL_ALIEN_CAPACITY];
        Distance = 0;
        WarpSpeed = 0; 
        Name = DEFAULT_SHIP_NAME;
    }

    public Ship(string name, int crewCount, int distance, int warpspeed)
    {
        Name = name;

        crew = new Alien[crewCount];

        Distance = distance;

        WarpSpeed = warpspeed; 
    }

    // Return true if Alien is added
    public bool Add(Alien alien)
    {
        // Can we test if the crew list is full?
        if(totalCrew >= crew.Length)
            return false;

        // There can only be 1 captain and 1 chief officer
        for(int i = 0; i < crew.Length; i++)
            // Check if there's a captain or chief officer
            if(crew[i] != null && 
                (crew[i].Role == "Captain" && alien.Role == "Captain" || 
                crew[i].Role == "Chief Officer" && alien.Role == "Chief Officer"))
            {
                // Can't be added
                return false;
            }

        // Add the alien to an available spot in the crew list
        for(int i = 0; i < crew.Length; i++)
            if(crew[i] == null)
            {
                crew[i] = alien;
                totalCrew ++;
                break;
            }

        // Otherwise, Alien has been added to the crew list
        return true;
    }

    // Return true if alien is removed
    public bool Remove(string name)
    {
        for(int i = 0; i < crew.Length; i++)
            // Make sure crew[i] is not null so that we can check property Name. Otherwise, can crash if null
            if(crew[i] != null && crew[i].Name == name)
            {
                // Remove the Alien by assigning null to crew[i]
                crew[i] = null;

                // Reduce number of totalCrew by 1
                totalCrew --;
                return true;
            }

        return false;
    }

    public void Fly()
    {
        WarpSpeed += 3;
        Distance += 5;
    }

    public void Fly(int warpSpeed)
    {
        for(int i = 0; i < warpSpeed; i++)
            Fly();
    }

    public override string ToString()
    {
        string crews = "";

        // Build the string of crews and their roles
        for(int i = 0; i < crew.Length; i++)
            // Important. Check if the crew is not null to avoid NullPointerException
            if(crew[i] != null)
                crews += $"\t{crew[i].Name} {crew[i].Role}\n";

        return 
            $"Ship Name: {Name}\n" + 
            $"Speed: {WarpSpeed}\n" + 
            $"Distance: {Distance}\n" +
            $"Total Crew: {totalCrew}\n" + 
            $"Crews:\n{crews}";
    }
}