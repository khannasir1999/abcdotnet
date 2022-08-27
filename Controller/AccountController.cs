using abc.RepositoryLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abc.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
     
        private readonly IAccountRL _accountRL;

        public AccountController(IAccountRL accountRL)
        {
            _accountRL = accountRL;
        }
    }
}
 