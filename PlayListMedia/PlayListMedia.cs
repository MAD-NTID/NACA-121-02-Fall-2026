public abstract class PlayListMedia<T> : IPlayListMedia<T>
{
    protected int totalMedia;

    public PlayListMedia() { }

    public abstract void Add(T media);

    public int GetTotalMedia()
    {
        return totalMedia;
    }

    public abstract T Play();

    public abstract T ShowNextMedia();
}