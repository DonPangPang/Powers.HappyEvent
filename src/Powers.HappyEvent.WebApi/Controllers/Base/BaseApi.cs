using Microsoft.AspNetCore.Mvc;
using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Repository;

namespace Powers.HappyEvent.WebApi.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class BaseApi<T>: ControllerBase where T : EntityBase
    {
        private readonly IGeneralRepository<T> _generalRepository;

        public BaseApi(IGeneralRepository<T> generalRepository)
        {
            _generalRepository = generalRepository;
        }

        [HttpGet]
        public async Task<ActionResult> FindAll()
        {
            var res = await _generalRepository.FindAll();

            return Ok(res);
        }

        [HttpGet]
        public async Task<ActionResult> FindOne(Guid id)
        {
            var res = await _generalRepository.FirstOrDefault(id);

            return Ok(res);
        }

        [HttpPost]
        public async Task<ActionResult> Update(T entity)
        {
            await _generalRepository.Update(entity);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Create(T entity)
        {
            await _generalRepository.Insert(entity);

            return NoContent();
        }
    }
}
