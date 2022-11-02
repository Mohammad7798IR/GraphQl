using Graph.Web.Context;
using Graph.Web.Model;
using HotChocolate;

namespace Graph.Web
{
        public class Query
        {
                
                [UseDbContext(typeof(GraphDbContext))]
                [UseProjection]
                [UseSorting]
                [UseFiltering]
                public IQueryable<User> Users([ScopedService]GraphDbContext graphDbContext) =>
                    graphDbContext.Users;

                [UseDbContext(typeof(GraphDbContext))]
                [UseProjection]
                [UseSorting]
                [UseFiltering]

                public IQueryable<Post> Posts([ScopedService] GraphDbContext graphDbContext) =>
                    graphDbContext.Posts;

                [UseDbContext(typeof(GraphDbContext))]
                [UseProjection]
                [UseSorting]
                [UseFiltering]

                public IQueryable<Comment> comments([ScopedService] GraphDbContext graphDbContext) =>
                    graphDbContext.comments;
                //public IQueryable<Like> Likes([Service] GraphDbContext graphDbContext) =>
                //    graphDbContext.Likes;


                //public IQueryable<Post> GetPosts([Service] GraphDbContext context) =>
                //        context.Posts;
        }
}