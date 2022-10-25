namespace Graph.Web.Model
{
        public class Like : BaseEntity
        {
                public String? UserId { get; set; }
                public String? PostId { get; set; }
                public String? CommentId { get; set; }
                public Post? Post { get; set; }
                public Comment? Comment { get; set; }
                public User? User { get; set; }
        }
}