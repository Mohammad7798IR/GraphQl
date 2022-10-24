namespace Graph.Web.Model
{
    public class Comment : BaseEntity
    {
        public string? UserId { get; set; }

        public User? User { get; set; }
        public Comment? Parent { get; set; }

        public string? ParentId { get; set; }

        public ulong LikeCount { get; set; }
    }
}