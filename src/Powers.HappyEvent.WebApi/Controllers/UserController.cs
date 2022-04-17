using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Controllers.Base;
using Powers.HappyEvent.WebApi.Manager;
using Powers.HappyEvent.WebApi.Repository;

namespace Powers.HappyEvent.WebApi.Controllers
{
    public class UserController : BaseApi<User>
    {
        private readonly IGeneralRepository<User> _generalRepository;
        private readonly SessionManagerService _sessionManagerService;

        public UserController(IGeneralRepository<User> generalRepository,
            SessionManagerService sessionManagerService) : base(generalRepository)
        {
            _generalRepository = generalRepository;
            _sessionManagerService = sessionManagerService;
        }

        [HttpGet]
        public ActionResult LoginUserInfo()
        {
            var user = _sessionManagerService.Get<User>("happy-login");

            return Success(user);
        }

        [HttpGet]
        public async Task<ActionResult> Login(string username, string password)
        {
            var user = await _generalRepository.GetQueryable()
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefaultAsync();
            if (user == null)
            {
                return Fail("用户名或密码错误");
            }

            return Success("登录成功", user);
        }

        [HttpPost]
        public async Task<ActionResult> Register(User user)
        {
            var existUser = await _generalRepository.GetQueryable()
                .Where(x => x.Username == user.Username)
                .FirstOrDefaultAsync();
            if (existUser != null)
            {
                return Fail("用户名已存在");
            }

            if(await _generalRepository.Insert(user))
            {
                return Success("注册成功");
            }
            else
            {
                return Fail("注册失败");
            }
        }
    }
}
