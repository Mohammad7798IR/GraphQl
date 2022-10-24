using Graph.Web;
using Graph.Web.Context;
using Graph.Web.Repositories.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<GraphDbContext>(options =>
{
    options.UseSqlServer(configuration.GetSection("ConnectionStrings")["DefaultConnectionStrings"]);
});

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .RegisterDbContext<GraphDbContext>(DbContextKind.Resolver);
//.AddType<UserType>()
//.AddType<PostType>();

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

app.MapGraphQL();

app.UseAuthorization();

app.MapControllers();

app.Run();