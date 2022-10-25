using Graph.Web.Context;
using Graph.Web.Model;
using HotChocolate;

namespace Graph.Web
{
        public class Query
        {
                

                public IQueryable<User> Users([Service]GraphDbContext graphDbContext) =>
                    graphDbContext.Users;
                //public IQueryable<Like> Likes([Service] GraphDbContext graphDbContext) =>
                //    graphDbContext.Likes;


                //public IQueryable<Post> GetPosts([Service] GraphDbContext context) =>
                //        context.Posts;
        }
}