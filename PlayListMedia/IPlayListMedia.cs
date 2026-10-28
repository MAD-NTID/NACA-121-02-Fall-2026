public interface IPlayListMedia<T>
{
    // public int TotalMedia { get; }
    public void Add(T media);
    public T ShowNextMedia();
    public T Play();
    public int GetTotalMedia();
}