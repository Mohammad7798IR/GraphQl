using Graph.Web;
using Graph.Web.Context;
using Microsoft.EntityFrameworkCore;
using Graph.Web.GraphQL.Types;
using GraphQL.Server.Ui.Voyager;
using StackExchange.Redis;
using Graph.Web.GraphQL;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
// Add services to the container.


builder.Services.AddPooledDbContextFactory<GraphDbContext>(options =>
{
        options.UseSqlServer(configuration.GetSection("ConnectionStrings")["DefaultConnectionStrings"]);
});

builder.Services
    .AddGraphQLServer()
    .AddProjections()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddSorting()
    .RegisterDbContext<GraphDbContext>(DbContextKind.Pooled)
    .AddFiltering()
    .AddInMemorySubscriptions();

    //.AddType<UserType>();
    //.AddRedisSubscriptions(configuration);
//.RegisterDbContext<GraphDbContext>();
//.AddType<UserType>()
//.AddType<LikeType>();
//.AddType<PostType>()
//.AddType<CommentType>();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseWebSockets();
app.UseRouting();
   //.UseWebSockets();

app.UseEndpoints(endpoint =>
{
        endpoint.MapGraphQL("/graphql");
        endpoint.MapGraphQLVoyager("ui/voyager");
});
app.Run();