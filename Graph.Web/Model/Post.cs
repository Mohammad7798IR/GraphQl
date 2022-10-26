using System.ComponentModel.DataAnnotations;

namespace Graph.Web.Model
{
        public class Post : BaseEntity
        {
                
                public string? Title { get; set; }

                public string? Text { get; set; }
                
                public string? UserId { get; set; }

                public long LikeCount { get; set; }

                public User? User { get; set; }
                public List<Like>? PostLikes { get; set; }
                public List<Comment>? comments { get; set; }




        }
}