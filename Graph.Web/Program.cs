using Graph.Web;
using Graph.Web.Context;
using Microsoft.EntityFrameworkCore;
using GraphQL.Server.Ui.Voyager;

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
    .AddSorting()
    .AddFiltering();
    //.RegisterDbContext<GraphDbContext>();
    //.AddType<UserType>()
    //.AddType<LikeType>();
    //.AddType<PostType>()
    //.AddType<CommentType>();



var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseRouting();
app.UseEndpoints(endpoint =>
{
        endpoint.MapGraphQL("/graphql");
        endpoint.MapGraphQLVoyager("ui/voyager");
});
app.Run();