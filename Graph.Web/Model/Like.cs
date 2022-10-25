namespace Graph.Web.Model
{
        public class Like : BaseEntity
        {
                public int UserId { get; set; }
                public int PostId { get; set; }
                public int CommentId { get; set; }
                public Post? Post { get; set; }
                public Comment? Comment { get; set; }
                public User? User { get; set; }
        }
}