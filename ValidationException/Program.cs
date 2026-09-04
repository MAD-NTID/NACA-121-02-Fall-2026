string newData = Console.ReadLine();

// int inputValue = int.Parse( newData );
// this returns true/false
// if(int.TryParse(newData, out int inputValue))
// {
//     Console.WriteLine($"Successfully converted {inputValue}");
// }   
// else
// {
//     Console.WriteLine($"Could not convert '{newData}'");
// } 

// Console.WriteLine(inputValue);

try
{
    int inputValue = int.Parse(newData);
    Console.WriteLine($"Successfully converted {inputValue}");

    Console.WriteLine(inputValue);
}
// We can catch specific exception
// catch (FormatException fe)
// {
//     Console.WriteLine($"Could not convert '{newData}'");
//     Console.WriteLine($"{fe.Message}");
// } 
catch (Exception e)
{
    Console.WriteLine($"Could not convert '{newData}'");
    Console.WriteLine($"{e.Message}");
} 