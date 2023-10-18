namespace Pass_Keeper.Models;

public class Notification
{
    public Guid Id { get; }
    public DateTime NotifDate { get; }
    public string? Title { get; set; }
    public string? Text { get; set; }
    public string? FromUser { get; set; }

    public Notification()
    {
        Id = Guid.NewGuid();
        NotifDate = DateTime.Now;
    }
    public Notification(string title, string text, string fromUser)
        : this()
    {
        Title = title;
        Text = text;
        FromUser = fromUser;
    }

    public override string ToString()
    {
        string? sym = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        return $"\n\n{sym}\n   Title: {Title}\n\n   Text: {Text}\n\n   FromUser: {FromUser}\n{sym}";
    }
}
