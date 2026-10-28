using System.Data.SqlTypes;

IPlayListMedia<Video> videoStack = new PlayListMediaStack<Video>();
IPlayListMedia<Video> videoQueue = new PlayListMediaQueue<Video>();

// Loading from File Process
StreamReader sr = new StreamReader("movies.txt");

bool skipHeader = false;

while(!sr.EndOfStream)
{
    // This will run once
    if(!skipHeader)
    {
        sr.ReadLine();
        skipHeader = !skipHeader;
        continue;   //  Do not process this iteration
    }    

    // Extract a row to a video object
    string[] movieString = sr.ReadLine().Split(',');
    // movieString[0] title
    // movieString[1] duration
    // movieString[2] category

    Video video = new Video(movieString[0], movieString[1], movieString[2]);

    videoStack.Add(video);
    Console.WriteLine($"Added '{video}' to the stack");

    videoQueue.Add(video);
    Console.WriteLine($"Added '{video}' to the queue");

    Console.WriteLine();
}

sr.Close();

Console.WriteLine(  "All video(s) are loaded into the stack and queue playlists.\n" +
                    $"Stack: {videoStack.GetTotalMedia()}\n" +
                    $"Queue: {videoQueue.GetTotalMedia()}\n");
// End Loading from File Process

// Stack write output to stack_results.txt
string stackResultsFile = "stack_results.txt";

StreamWriter swStack = new StreamWriter(stackResultsFile);

Console.WriteLine("Stack\n===========================");
swStack.WriteLine("Stack\n===========================");

int videoStackMediaCount = videoStack.GetTotalMedia();
for(int i = 0; i < videoStackMediaCount; i++)
{
    Console.WriteLine($"Next: '{videoStack.ShowNextMedia()}'");
    swStack.WriteLine($"Next: '{videoStack.ShowNextMedia()}'");

    Video video = videoStack.Play();
    Console.WriteLine($"Play: '{video}'");
    swStack.WriteLine($"Play: '{video}'");
}

swStack.Close();

Console.WriteLine();

string queueResultsFile = "queue_results.txt";
StreamWriter swQueue = new StreamWriter(queueResultsFile);

Console.WriteLine("Queue\n===========================");
swQueue.WriteLine("Queue\n===========================");

int videoQueueMediaCount = videoQueue.GetTotalMedia();
for(int i = 0; i < videoQueueMediaCount; i++)
{
    Console.WriteLine($"Next: '{videoQueue.ShowNextMedia()}'");
    swQueue.WriteLine($"Next: '{videoQueue.ShowNextMedia()}'");

    Video video = videoQueue.Play();
    Console.WriteLine($"Play: '{video}'");
    swQueue.WriteLine($"Play: '{video}'");
}

swQueue.Close();