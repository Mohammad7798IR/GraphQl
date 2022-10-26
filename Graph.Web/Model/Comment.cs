namespace Graph.Web.Model
{
        public class Comment : BaseEntity
        {
                public String? UserId { get; set; }

                public User? User { get; set; }

                public string? PostId { get; set; }

                public Post? Post { get; set; }

                public Comment? Parent { get; set; }
                
                public String? ParentId { get; set; }
                
                public long LikeCount { get; set; }

                public List<Like>? CommentLikes { get; set; }
        }
}