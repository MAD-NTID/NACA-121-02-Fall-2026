// Battle between two beasts
Beast drogon = new Dragon("Drogon", 1000, 100);
Beast godzilla = new Godzilla("Godzilla 1954", 1000, 100);

Console.WriteLine($"================Let the Battle Begin!================");

Random random = new Random();
int round = 1;

/**
    We need a loop for the two beast to continue battling until one of their health
    reaches 0 or below which indicates they've been defeated and the battle ends.

    Continue battle as long as both of the beast's health are >= 1
**/
while(drogon.CurrentHealth > 0 && godzilla.CurrentHealth > 0)
{
    Console.WriteLine($"Current Round: {round++}");

    // Begin Logic for Battle
    /**
        We use random to determine what type of ability a Beast will use
        There are many ways to do this, a simple way is if random has 75% or above
    **/
    int drogonAbility = random.Next(1, 101);

    // This is called a Ternary Operator
    int drogonDamage = drogonAbility >= 75 ? drogon.AttackAbility() : drogon.Attack();

    // Code below is the same as Ternary Operator above ^^ (preference)
    // if(drogonAbility >= 75)
    //     drogonDamage = drogon.Attack();
    // else
    //     drogonDamage = drogon.AttackAbility();

    godzilla.TakeDamage(drogonDamage);
    Console.WriteLine($"{godzilla.Name} took damage {drogonDamage}");
    Console.WriteLine($"Health: {godzilla.CurrentHealth} / {godzilla.Health}");
    Console.WriteLine();

    // Check if Godzilla is not dead
    if(godzilla.CurrentHealth <= 0)
        break;

    int godzillaAbility = random.Next(1, 101);

    // This is called a Ternary Operator
    int godzillaDamage = godzillaAbility >= 75 ? godzilla.AttackAbility() : godzilla.Attack();

    // Code below is the same as Ternary Operator above ^^ (preference)
    // if(godzillaAbility >= 75)
    //     godzillaDamage = godzilla.Attack();
    // else
    //     godzillaDamage = godzilla.AttackAbility();

    drogon.TakeDamage(godzillaDamage);
    Console.WriteLine($"{drogon.Name} took damage {godzillaDamage}");
    Console.WriteLine($"Health: {drogon.CurrentHealth} / {drogon.Health}");
    Console.WriteLine();

    // Check if Godzilla is not dead
    if(drogon.CurrentHealth <= 0)
        break;
    // End Logic for Battle

    Console.WriteLine($"================End of Round {round}================");
}

Console.WriteLine($"================Battle Over!================");

// Determine the winner
Beast? winner = null;

if(drogon.CurrentHealth > godzilla.CurrentHealth)
    winner = drogon;
else
    winner = godzilla;

Console.WriteLine($"{winner.Name} won!");
