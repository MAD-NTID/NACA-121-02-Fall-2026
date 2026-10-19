using System.Net;

StreamWriter? sw = null;
string filename = "student_record.csv";

try
{
    sw = new StreamWriter("student_record.csv");

    // First, write the headers
    sw.WriteLine("name, academic year, state, graduated");
    
    // Abhik
    sw.WriteLine("Abhik Chakraborty, 2, NJ, No");

    // Shamik
    sw.WriteLine("Shamik Chakraborty, 2, NJ, No");

    // Isaiah
    sw.WriteLine("Isaiah Jordan, 2, CA, No");

    sw.Close();
}
catch (DirectoryNotFoundException dnfe)
{
    Console.WriteLine($"Could not find folder");
    Console.WriteLine(dnfe.Message);
}
catch (IOException ioe)
{
    Console.WriteLine("Could not write some info");
    Console.WriteLine(ioe.Message);
}
catch (Exception e)
{
    Console.WriteLine($"Oh uh, we hid a snap");
    Console.WriteLine(e.Message);
}

// We need to read multiple lines in a file so we need to use Loop
bool firstLine = true;

if(File.Exists(filename))
{
    StreamReader sr = new StreamReader(filename);

    // Checks if we reached the end of the file or not
    while(!sr.EndOfStream)
    {
        // Read out the first line the rows (no need to output anything)
        string? line = sr.ReadLine();

        // first line is not read, read it and mark it to skip it next time
        // this is usually done for skipping the headers if they're not needed.
        if(firstLine)
        {
            firstLine = !firstLine;
            continue;
        }

        // Output the line just read
        Console.WriteLine(line);

        // Split the string by the comma delimeter
        if(!string.IsNullOrEmpty(line))
        {
            string[] row = line.Split(",");

            Console.WriteLine($"Name: {row[0]} - Academic Year: {row[1]} - State: {row[2]} - Graduated: {row[3]}\n");
        }
    }

    Console.WriteLine($"Finished reading '{filename}'");
    sr.Close();
}
else
{
    Console.WriteLine($"File was not found '{filename}'");
}

if(File.Exists(filename))
{   
    string? deleteConfirm = null;
    
    while(string.IsNullOrEmpty(deleteConfirm) || 
        !(
            deleteConfirm.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || 
            deleteConfirm.Equals("no", StringComparison.CurrentCultureIgnoreCase)))
    {
        Console.Write($"Would you like to delete '{filename}' (yes/no)? ");

        deleteConfirm = Console.ReadLine();
    }

    if(!string.IsNullOrEmpty(deleteConfirm) && deleteConfirm.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
    {
        File.Delete(filename);

        Console.WriteLine($"File '{filename}' has been deleted");
    }
}