using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Controllers.Base;
using Powers.HappyEvent.WebApi.Repository;

namespace Powers.HappyEvent.WebApi.Controllers
{
    public class PickRecordController : BaseApi<PickRecord>
    {
        private readonly IGeneralRepository<PickRecord> _generalRepository;

        public PickRecordController(IGeneralRepository<PickRecord> generalRepository) : base(generalRepository)
        {
            _generalRepository = generalRepository;
        }
    }
}
