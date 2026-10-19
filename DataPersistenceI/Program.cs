// Simple StreamWriter that outpus "Hello world" to a file called "hello world.txt"
string fileName = "HelloWorld/hello world.txt";
//                  ^^ notice no file path, folder "HelloWorld" must exist first
//                  or you'll get DirectoryNotFoundException

try
{
    // We need the stream writer object
    StreamWriter sw = new StreamWriter(fileName);

    sw.WriteLine("Hello World! My name is Michael");

    // After finishing writing to file, close the stream (releases file lock)
    // If you forget the close, the stream will not persist data
    // The technical term is, it will not "flush" data to the file
    sw.Close();  

    Console.WriteLine($"Finished writing to '{fileName}'");
}
catch (DirectoryNotFoundException dnfe)
{
    Console.WriteLine($"Bad File Path");
    Console.WriteLine(dnfe.Message);
}

try
{
    // The same way you streamwrite, you can streamread with StreamReader
    StreamReader sr = new StreamReader("badfilename.txt");

    Console.WriteLine(sr.ReadLine());

    // Don't forget to close the reader to release access lock
    sr.Close();
}
catch (FileNotFoundException fnfe)
{
    Console.WriteLine($"File '{fileName}' was not found");
    Console.WriteLine(fnfe.Message);
}