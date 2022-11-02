using Graph.Web.Context;
using Graph.Web.Model;
using HotChocolate.Subscriptions;

namespace Graph.Web.GraphQL
{
        public class Mutation
        {
                [UseDbContext(typeof(GraphDbContext))]
                public async Task<AddPostPayload> AddPostAsync
                        (AddPostInput input
                        , [ScopedService] GraphDbContext context,
                        [Service] ITopicEventSender eventSender,
                        CancellationToken cancellationToken)
                {
                        var post = new Post
                        {
                                Title = input.Title,
                                Text = input.Text,
                                UserId = input.Userid
                        };

                        context.Posts.Add(post);
                        await context.SaveChangesAsync(cancellationToken);
                        await eventSender.SendAsync(nameof(Subscription.OnPostAdded), post, cancellationToken);

                        return new AddPostPayload(post);
                }

                [UseDbContext(typeof(GraphDbContext))]
                public async Task<AddUserPayload> AddUserAsync
                       (AddUserInput input
                       , [ScopedService] GraphDbContext context,
                        [Service] ITopicEventSender eventSender,
                        CancellationToken cancellationToken)
                {
                        var user = new User
                        {
                                Id = input.Id,
                                Username = input.UserName
                        };

                        context.Users.Add(user);
                        await context.SaveChangesAsync(cancellationToken);
                        await eventSender.SendAsync(nameof(Subscription.OnPostAdded), user, cancellationToken);


                        return new AddUserPayload(user);
                }
        }
}
