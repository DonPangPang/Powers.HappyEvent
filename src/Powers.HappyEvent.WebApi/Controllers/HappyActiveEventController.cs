using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Controllers.Base;
using Powers.HappyEvent.WebApi.Repository;

namespace Powers.HappyEvent.WebApi.Controllers
{
    public class HappyActiveEventController : BaseApi<HappyActiveEvent>
    {
        private readonly IGeneralRepository<HappyActiveEvent> _generalRepository;

        public HappyActiveEventController(IGeneralRepository<HappyActiveEvent> generalRepository) : base(generalRepository)
        {
            _generalRepository = generalRepository;
        }
    }
}
