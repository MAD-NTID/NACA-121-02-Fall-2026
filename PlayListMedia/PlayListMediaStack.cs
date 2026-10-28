public class PlayListMediaStack<T> : PlayListMedia<T>
{
    private Stack<T> playlist;

    public PlayListMediaStack()
    {
        // Initialize the playlist stack object
        playlist = new Stack<T>();
    }

    public override void Add(T media)
    {
        playlist.Push(media);

        totalMedia ++;
    }

    public override T Play()
    {
        T media = playlist.Pop();

        totalMedia --;

        return media;   
    }

    public override T ShowNextMedia()
    {
        return playlist.Peek();
    }
}