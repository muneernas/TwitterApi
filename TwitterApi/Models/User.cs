namespace TwitterApi.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } =string.Empty;
    public string Name { get; set; } =string.Empty;
    public string? Image { get; set; } =string.Empty;
    public List<Tweet> Tweets { get; set; } = new List<Tweet>();
}