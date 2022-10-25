using Graph.Web.Context;
using Graph.Web.Model;

namespace Graph.Web
{
        public class Query
        {
                

                public IQueryable<User> Users(GraphDbContext graphDbContext) =>
                    graphDbContext.Users;

                public IQueryable<Post> GetPosts([Service] GraphDbContext context) =>
                        context.Posts;
        }
}