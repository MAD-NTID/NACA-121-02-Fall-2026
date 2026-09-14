Car mbCar = new Car("Toyota", "Tercel", 1993, "PR-1234");
Car mbCar2 = new Car("Hyundai", "Tiburon", 2004, "NY-1234");

// Console.WriteLine($"{mbCar.make}");

// mbCar.make = "Hyundai";

// Console.WriteLine($"{mbCar.make}");

// Console.WriteLine($"{mbCar.RevUp()}");
// Console.WriteLine($"Engine Running: {mbCar.EngineIsRunning()}");

// mbCar.StartEngine();

// Console.WriteLine($"Engine Running: {mbCar.EngineIsRunning()}");
// Console.WriteLine($"{mbCar.RevUp()}");

// Console.WriteLine($"Engine Running: {mbCar.EngineIsRunning()}");
// Console.WriteLine($"Start up the engines and rev up:");
// Console.WriteLine($"{mbCar.RevUp(true)}");
// Console.WriteLine($"Engine Running: {mbCar.EngineIsRunning()}");

// RevUp(bool startEngine, int revTimes)
// Console.WriteLine($"Engine Running: {mbCar.EngineIsRunning()}");
// Console.WriteLine($"Start up the engines and rev up:");
// Console.WriteLine($"{mbCar.RevUp(true, 10)}");
// Console.WriteLine($"Engine Running: {mbCar.EngineIsRunning()}");

// Console.WriteLine(mbCar);
// Console.WriteLine(mbCar2);

// We can have an array of Car objects
Car[] cars = new Car[10];
cars[0] = mbCar;
cars[1] = mbCar2;
cars[2] = new Car("Lamborghini", "X1", 1999, "NJ-1234");
cars[2].StartEngine();

cars[3] = new Car("Nissan", "Pathfinder", 2010, "NJ-4321");

cars[4] = new Car("Bughatti", "YourBillion", 2026, "AK-1234");
cars[4].StartEngine();

// For Loop
for(int i = 0; i < cars.Length; i++)
{   
    // Show only non-null Car objects
    if(cars[i] != null && cars[i].EngineIsRunning())
    {
        //  cars[i] inside a string will "implicitly" call ToString()
        Console.WriteLine($"{i + 1}\n{cars[i]}");  // is equivalent to
        
        // cars[i] inside a string with .ToString() will "explicitly" call ToString()
        Console.WriteLine($"{i + 1}\n{cars[i].ToString()}");
        Console.WriteLine($"{cars[i].RevUp()}");

        // Line spacer
        Console.WriteLine();
    }
}