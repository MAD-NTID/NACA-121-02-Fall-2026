using Newtonsoft.Json;  //  reference to the Newtonsoft.Json package

// // The Below Examples cover the basics of storing and loading a single object as JSON
// Player? player1 = new Player("Abhik", "Defensive", 23);

// Console.WriteLine($"Player: {player1}");
// Console.WriteLine("Serialized - ");
// string player1_serialized = JsonConvert.SerializeObject(player1);

// Console.WriteLine(player1_serialized);
// Console.WriteLine();

// // Intentionally nullify player1 object - proof that it's deleted
// player1 = null;

// Console.WriteLine($"Player: {player1}");

// // Let's reload the player from the player1_serialized we created earlier
// player1 = JsonConvert.DeserializeObject<Player>(player1_serialized);

// Console.WriteLine("Deserialized - ");
// Console.WriteLine($"Player: {player1}");

const string jsonFileName = "Players.json";
Player?[] players = new Player[10];

players[0] = new("Abhik", "Defensive", 23);
players[1] = new("Isaiah", "Dunker", 99);
players[2] = new("Shamik", "Spanker", 07);
players[3] = new("Michael", "3 Pointer Shooter", 01);

// Serialize to String
string players_string = JsonConvert.SerializeObject(players, Formatting.Indented);

// using it this way automatically flushes and closes
using (StreamWriter sw = new StreamWriter("Players.json"))
{
    sw.Write(players_string);
};

players[0] = null;
players[1] = null;
players[2] = null;
players[3] = null;

// Reload from string
// players = JsonConvert.DeserializeObject<Player[]>(players_string);

// Reload from file
using (StreamReader sr = new StreamReader(jsonFileName))
{
    // Read the whole thing at once
    string playerInfo = sr.ReadToEnd();    

    players = JsonConvert.DeserializeObject<Player[]>(playerInfo);
};

Console.WriteLine($"Players has been reloaded");

// Proof players array has been reloaded
for(int i = 0; i < players.Length; i++)
{
    Player player = players[i];

    if(player != null)
        Console.WriteLine(players[i]);
}