Ship voyager = new("Voyager", 3000, 0, 0);

while(true)
{
    Console.WriteLine($"StarFleed Federation\n\nMenu");
    Console.WriteLine("=====================");
    Console.WriteLine($"1. Add Alien to Ship");
    Console.WriteLine($"2. Fly");
    Console.WriteLine($"3. Fly at specific speed");
    Console.WriteLine($"4. Remove an Alien from the ship");
    Console.WriteLine($"5. Show Ship information");
    Console.WriteLine($"6. Exit");

    Console.Write($"Selection: ");
    int selection = 0; 
    
    try
    {
        selection = int.Parse(Console.ReadLine());
    }
    catch(FormatException fe)
    {
        Console.WriteLine($"Invalid Selection. Input must be a digit!");
    }

    if(selection == 1)
    {
        string name, role;
        bool added = false;

        do
        {
            Console.Write($"Enter the name of Alien: ");
            name = Console.ReadLine();

            Console.Write($"Enter the role of the Alien: ");
            role = Console.ReadLine();

            added = voyager.Add(new Alien(name, role));

            if(added)
                Console.WriteLine($"Alien {name} Role {role} was added to the crew");                
            else
                Console.WriteLine($"Alien {name} Role {role} was not added to the crew");
        } while(!added);
    }

    else if(selection == 2)
    {
        voyager.Fly();

        Console.WriteLine($"{voyager.Name} flew {voyager.Distance} interstellar distance at {voyager.WarpSpeed} warp speed");
    }

    else if(selection == 3)
    {
        Console.Write($"Enter the WarpSpeed: ");
        if(int.TryParse(Console.ReadLine(), out int warpSpeed) && warpSpeed % 3 == 0)
        {
            //  Conversion
            warpSpeed /= 3;

            voyager.Fly(warpSpeed);
            Console.WriteLine($"{voyager.Name} flew {voyager.Distance} interstellar distance at {voyager.WarpSpeed} warp speed");
        }
        else
        {
            Console.WriteLine($"Invalid speed! Speed must be an integer in mutliple of 3!\nShip did not fly!");
        }
    }

    else if(selection == 4)
    {
        Console.Write("Enter Alien's Name to Remove from Crew: ");
        string name = Console.ReadLine();

        if(voyager.Remove(name))
            Console.WriteLine($"Alien {name} was successfully removed from the crew");
        else
            Console.WriteLine($"Alien {name} doesn't exist");
    }

    else if(selection == 5)
    {
        Console.WriteLine(voyager);
    }

    else if(selection == 6)
    {
        Console.WriteLine("Thank you for exploring space with us!");
        break;
    }

    else
    {
        Console.WriteLine($"Invalid Option");
    }

    Console.WriteLine();
}