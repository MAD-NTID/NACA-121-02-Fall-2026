public class Video
{
    private string title, duration, category;

    public Video(string title, string duration, string category)
    {
        this.title = title;
        this.duration = duration;
        this.category = category;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetDuration()
    {
        return duration;
    }

    public string GetCategory()
    {
        return category;
    }

    public override string ToString()
    {
        return $"{title}, {category}, {duration} minutes";
    }
}