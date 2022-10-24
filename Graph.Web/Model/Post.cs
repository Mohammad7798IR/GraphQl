namespace Graph.Web.Model
{
    public class Post : BaseEntity
    {
        public string? Title { get; set; }

        public string? Text { get; set; }

        public string? UserId { get; set; }

        public ulong LikeCount { get; set; }

        public User? User { get; set; }
    }
}