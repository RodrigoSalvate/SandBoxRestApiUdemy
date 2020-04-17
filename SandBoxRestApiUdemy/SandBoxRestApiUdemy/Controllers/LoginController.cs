using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SandBoxRestApiUdemy.Business;
using SandBoxRestApiUdemy.Model;

namespace SandBoxRestApiUdemy.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILogInBusiness _logInBusiness;

        public LoginController(ILogInBusiness logInBusiness)
        {
            _logInBusiness = logInBusiness;
        }

        [AllowAnonymous]
        [HttpPost]
        public object Post([FromBody] User user)
        {
            if (user == null) return BadRequest();

            return _logInBusiness.FindByLogIn(user);
        }


    }
}