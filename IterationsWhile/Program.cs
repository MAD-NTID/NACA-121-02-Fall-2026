// While Loop is another Pre-Test Loop, it supports more condition check
// As compared to For loop which checks if count has reached condition
bool student = true;
bool study = false;

// Loop until the user wants to study
while(student && !study)
{
    Console.Write("Do you want to study (y/n): ");

    string response = Console.ReadLine();

    if(response == "y" || response == "Y")    
        study = true;
}

Console.WriteLine("You are now studying");