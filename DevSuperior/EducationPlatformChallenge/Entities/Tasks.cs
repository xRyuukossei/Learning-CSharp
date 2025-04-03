namespace EducationPlatformChallenge.Entities;
internal class Tasks : Lesson
{
    public string Description { get; set; }
    public int QuestionCount { get; set; }

    public Tasks()
    {

    }
    public Tasks(string title, string description, int questionCount) : base (title)
    {
        Description = description;
        QuestionCount = questionCount;
    }

    public sealed override int Duration()
    {
        return QuestionCount * 5 * 60;
    }
}
