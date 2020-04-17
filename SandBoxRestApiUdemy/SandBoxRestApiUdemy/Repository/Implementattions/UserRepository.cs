using SandBoxRestApiUdemy.Model;
using SandBoxRestApiUdemy.Model.Context;
using System.Linq;

namespace SandBoxRestApiUdemy.Repository.Implementattions
{
    public class UserRepository : IUserRepository
    {
        private readonly SqlServerContext _context;
        public UserRepository(SqlServerContext context)
        {
            _context = context;
        }
        public User FindByLogIn(string login)
        {
            return _context.Users.SingleOrDefault(s => s.Login.Equals(login));
        }
    }
}
