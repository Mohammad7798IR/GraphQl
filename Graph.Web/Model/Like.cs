namespace Graph.Web.Model
{
    public class Like : BaseEntity
    {
        public string? UserId { get; set; }

        public User? User { get; set; }
    }
}
