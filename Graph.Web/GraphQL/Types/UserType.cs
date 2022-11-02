using Graph.Web.Context;
using Graph.Web.Model;

namespace Graph.Web.GraphQL.Types
{
        public class UserType : ObjectType<User>
        {
                protected override void Configure(IObjectTypeDescriptor<User> descriptor)
                {
                        base.Configure(descriptor);
                        descriptor
                                .Field(p => p.Username).Ignore();

                        descriptor
                                .Field(p => p.Posts)
                                .ResolveWith<Resolver>(p => p.GetPosts(default!, default!))
                                .UseDbContext<GraphDbContext>();
                       
                }

                private class Resolver
                {
                        public IQueryable<Post> GetPosts(User user, [ScopedService] GraphDbContext context)
                        {
                                return context.Posts.Where(p => p.UserId == user.Id);
                        }
                }
        }
}