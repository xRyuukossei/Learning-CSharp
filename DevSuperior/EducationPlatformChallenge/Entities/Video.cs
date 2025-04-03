namespace EducationPlatformChallenge.Entities;
internal class Video : Lesson
{
    public string Url { get; set; }
    public int Seconds { get; set; }

    public Video()
    {

    }
    public Video(string title, string url, int seconds) : base(title)
    {
        Url = url;
        Seconds = seconds;
    }

    public sealed override int Duration()
    {
        return Seconds;
    }
}
