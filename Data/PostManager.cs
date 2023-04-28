using MyDailyBlog.Models;
using System.Text.Json;

namespace MyDailyBlog.Data;
public class PostManager
{
    public static List<BlogPost> _posts = new List<BlogPost>();
    private readonly string _pathData = @"~/Data/collectionPosts.json";

    public PostManager()
    {
        _posts = GetAllPosts();
    }

    public List<BlogPost> GetAllPosts()
    {
        using var jsonFile = File.OpenRead(_pathData.Replace("~/", ""));

        var posts = JsonSerializer.Deserialize<List<BlogPost>>(jsonFile);
        return posts.OrderByDescending(x => x.CreationDate).ToList();
    }

    public BlogPost GetPostById(Guid Id) =>
        _posts.Find(p => p.Id == Id);
}
