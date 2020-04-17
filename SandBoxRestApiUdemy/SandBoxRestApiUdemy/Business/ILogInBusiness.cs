using SandBoxRestApiUdemy.Model;
using System;

namespace SandBoxRestApiUdemy.Business
{
    public interface ILogInBusiness
    {
        object FindByLogIn(User login);
    }
}
