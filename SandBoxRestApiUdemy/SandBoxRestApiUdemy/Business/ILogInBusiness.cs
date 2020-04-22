using SandBoxRestApiUdemy.Data.VO;

namespace SandBoxRestApiUdemy.Business
{
    public interface ILogInBusiness
    {
        object FindByLogIn(UserVO login);
    }
}
