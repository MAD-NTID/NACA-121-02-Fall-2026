Console.WriteLine("Hello, World!");

string name = "Michael";

// Interpolation - converts a variable value into a string formatting
Console.WriteLine($"Your name is {name}");

// Don't forget to enable 'auto save' by clicking on File > Auto Save
// This will save as you type
double weight = 180;

Console.WriteLine($"Your name is {name} and you weight {weight}lbs");

Console.Write("Enter your name: ");

// Read the user's input
string yourName = Console.ReadLine();

// Read the user's age - should it be string?
Console.Write("Enter your age: ");
int yourAge = int.Parse(Console.ReadLine());

// Calculate the year born!
int todayYear = 2026;

// Is this accurate?
int yearBorn = todayYear - yourAge;

Console.WriteLine($"Your name is {yourName} and you are {yourAge} years old, and were born approximately in {yearBorn}");