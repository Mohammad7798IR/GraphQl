using Graph.Web.Context;
using Graph.Web.Model;

namespace Graph.Web
{
    public class Query
    {

        public string SayHello()
        {
            return "Hello";
        }


        //public User User() =>
        //     new User { Username = "a", Id = "aa" };

        public IQueryable<User> Users(GraphDbContext graphDbContext) =>
            graphDbContext.Users;

    }
}
