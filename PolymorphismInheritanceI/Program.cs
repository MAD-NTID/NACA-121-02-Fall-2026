// Dragon is a Beast | A Beast can be a Dragon
Beast abhikAbomination = new Dragon("Abhik Abomination", 500, 1000);

// Godzilla is a Beast | A beast can be a Godzilla
Beast isaiahZilla = new Godzilla("IsaiahZilla", 400, 500);

// Create a Dragon
Dragon shamikSmoke = new Dragon("Shamik Smoke", 600, 800);

// Console.WriteLine($"{abhikAbomination.GetType().BaseType} - {abhikAbomination.GetType()} - {abhikAbomination.Name} - {abhikAbomination.CurrentHP} - {abhikAbomination.MaxHP}");
// Console.WriteLine($"{shamikSmoke.GetType().BaseType} - {shamikSmoke.GetType()} - {shamikSmoke.Name} - {shamikSmoke.CurrentHP} - {shamikSmoke.MaxHP}");
// Console.WriteLine($"{isaiahZilla.GetType().BaseType} - {isaiahZilla.GetType()} - {isaiahZilla.Name} - {isaiahZilla.CurrentHP} - {isaiahZilla.MaxHP}");

// Console.WriteLine(abhikAbomination);
// Console.WriteLine(shamikSmoke);
// Console.WriteLine(isaiahZilla);

Beast[] beasts = {abhikAbomination, shamikSmoke, isaiahZilla};

for(int i = 0; i < beasts.Length; i++)
    Console.WriteLine(beasts[i]);

// THIS IS NOT ALLOWED - NOT THE SAME TYPE
// Dragon thisDragon = new Godzilla();
// Dragon thisDragon2 = new Beast();
// Godzilla thisGodzilla = new Dragon();
// Godzilla thisGodzilla2 = new Beast();