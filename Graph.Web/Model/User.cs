namespace Graph.Web.Model;

public class User : BaseEntity
{
    public string? Username { get; set; }

    public ICollection<Post>? Posts { get; set; }

    public ICollection<Comment>? Comments { get; set; }

    public ICollection<Like>? Likes { get; set; }
}

