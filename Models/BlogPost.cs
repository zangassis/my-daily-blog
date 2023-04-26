namespace MyDailyBlog.Models;

public class BlogPost
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? LongTitle { get; set; }
    public string? Content { get; set; }
    public List<string>? Tags { get; set; }
    public DateTime CreationDate { get; set; }
}
