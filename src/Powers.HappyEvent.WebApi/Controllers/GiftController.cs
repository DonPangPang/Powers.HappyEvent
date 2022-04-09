using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Controllers.Base;
using Powers.HappyEvent.WebApi.Repository;

namespace Powers.HappyEvent.WebApi.Controllers
{
    public class GiftController : BaseApi<Gift>
    {
        private readonly IGeneralRepository<Gift> _generalRepository;

        public GiftController(IGeneralRepository<Gift> generalRepository) : base(generalRepository)
        {
            _generalRepository = generalRepository;
        }
    }
}
