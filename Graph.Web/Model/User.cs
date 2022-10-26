namespace Graph.Web.Model;

public class User : BaseEntity
{
        public string? Username { get; set; }

        public List<Post>? Posts { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Comment>? comments { get; set; }




}

