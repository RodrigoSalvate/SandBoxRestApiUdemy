using SandBoxRestApiUdemy.Model;

namespace SandBoxRestApiUdemy.Repository
{
    public interface IUserRepository 
    {
        User FindByLogIn(string login);
    }
}
