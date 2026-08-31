// Do-While Loop is Post-Test Loop, it supports more condition check
// As compared to For loop which checks if count has reached condition
// Also, do while allows you to do something first before even repeating the loop
bool student = true;
bool study = false;

do
{
    Console.Write("Do you want to study (y/n): ");

    string response = Console.ReadLine();

    if(response == "y" || response == "Y")    
        study = true;

// Loop until the user wants to study
} while(student && !study);

// // Loop until the user wants to study
// while(student && !study)
// {
//     Console.Write("Do you want to study (y/n): ");

//     string response = Console.ReadLine();

//     if(response == "y" || response == "Y")    
//         study = true;
// }

Console.WriteLine("You are now studying");