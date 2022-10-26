using Graph.Web.Context;
using Graph.Web.Model;
using HotChocolate;

namespace Graph.Web
{
        public class Query
        {
                
                [UseDbContext(typeof(GraphDbContext))]
                [UseProjection]
                public IQueryable<User> Users([ScopedService]GraphDbContext graphDbContext) =>
                    graphDbContext.Users;

                [UseDbContext(typeof(GraphDbContext))]
                [UseProjection]
                public IQueryable<Post> Posts([ScopedService] GraphDbContext graphDbContext) =>
                    graphDbContext.Posts;
                //public IQueryable<Like> Likes([Service] GraphDbContext graphDbContext) =>
                //    graphDbContext.Likes;


                //public IQueryable<Post> GetPosts([Service] GraphDbContext context) =>
                //        context.Posts;
        }
}