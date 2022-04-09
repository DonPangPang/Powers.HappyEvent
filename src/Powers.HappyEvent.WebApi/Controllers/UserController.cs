using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Controllers.Base;
using Powers.HappyEvent.WebApi.Repository;

namespace Powers.HappyEvent.WebApi.Controllers
{
    public class UserController : BaseApi<User>
    {
        private readonly IGeneralRepository<User> _generalRepository;

        public UserController(IGeneralRepository<User> generalRepository) : base(generalRepository)
        {
            _generalRepository = generalRepository;
        }
    }
}
