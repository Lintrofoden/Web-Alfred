namespace Web_develop.Models;

public class Post
{
    public int Id { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Category { get; set; }
    public DateTime DatePublished { get; set; }
}