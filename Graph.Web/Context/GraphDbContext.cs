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

                public DbSet<Comment> Comments { get; set; }

                public DbSet<Like> Likes { get; set; }

                public DbSet<Post> Posts { get; set; }

                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                        //modelBuilder
                        //    .Entity<User>()
                        //    .HasKey(x => x.Id);

                        //modelBuilder
                        //   .Entity<Comment>()
                        //   .HasKey(x => x.Id);

                        //modelBuilder
                        //   .Entity<Post>()
                        //   .HasKey(x => x.Id);

                        //modelBuilder
                        //   .Entity<Like>()
                        //   .HasKey(x => x.Id);

                        //modelBuilder
                        //  .Entity<User>()
                        //  .HasMany(p => p.Posts)
                        //  .WithOne(u => u.User)
                        //  .HasForeignKey(u => u.UserId);

                        //modelBuilder
                        // .Entity<User>()
                        // .HasMany(p => p.Comments)
                        // .WithOne(u => u.User)
                        // .HasForeignKey(u => u.UserId);

                        //modelBuilder
                        // .Entity<User>()
                        // .HasMany(p => p.Likes)
                        // .WithOne(u => u.User)
                        // .HasForeignKey(u => u.UserId);

                        //modelBuilder
                        //.Entity<Post>()
                        //.HasMany(p => p.PostLikes)
                        //.WithOne(u => u.Post)
                        //.HasForeignKey(u => u.PostId);

                        //modelBuilder
                        //.Entity<Comment>()
                        //.HasMany(p => p.CommentLikes)
                        //.WithOne(u => u.Comment)
                        //.HasForeignKey(u => u.CommentId);
                }
        }
}