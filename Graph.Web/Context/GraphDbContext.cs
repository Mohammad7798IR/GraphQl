using Graph.Web.Model;
using Microsoft.EntityFrameworkCore;

namespace Graph.Web.Context
{
        public class GraphDbContext : DbContext
        {
                public GraphDbContext(DbContextOptions<GraphDbContext> options) : base(options)
                {
                }

                public DbSet<User> Users { get; set; }
                public DbSet<Like> Likes { get; set; }
                public DbSet<Comment> comments { get; set; }
                public DbSet<Post> Posts { get; set; }

                
        }
}