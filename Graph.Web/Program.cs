using Graph.Web;
using Graph.Web.Context;
using Graph.Web.Model.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GraphDbContext>(options =>
{
        options.UseSqlServer(configuration.GetSection("ConnectionStrings")["DefaultConnectionStrings"]);
});

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .RegisterDbContext<GraphDbContext>()
    .AddType<UserType>()
    .AddType<LikeType>();
    //.AddType<PostType>()
    //.AddType<CommentType>();

//builder.Services
//    .AddSingleton<UserRepository>();

//builder.Services
//    .AddScoped<IUserRepository, UserRepository>();

//builder.Services
//    .AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
        app.UseSwagger();
        app.UseSwaggerUI();
}

app.UseRouting();
app.MapGraphQL("/graphql");
//app.UseEndpoints(endpoint =>
//{
//        endpoint.MapGraphQL("/graphql");
//});
//app.UseAuthorization();

//app.MapControllers();

app.Run();