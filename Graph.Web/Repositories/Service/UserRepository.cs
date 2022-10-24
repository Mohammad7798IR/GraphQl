using Graph.Web.Context;
using Graph.Web.Model;
using Graph.Web.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Graph.Web.Repositories.Service
{
    public class UserRepository : IUserRepository
    {

        private readonly GraphDbContext _graphDbContext;

        public async Task<User> GetUser() =>
           await _graphDbContext.Users.FirstOrDefaultAsync();

    }
}
