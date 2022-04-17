using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Repository;

namespace Powers.HappyEvent.WebApi.Controllers.Base
{
    [ApiController]
    [EnableCors("Any")]
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

            return Success(res);
        }

        [HttpGet]
        public async Task<ActionResult> FindOne(Guid id)
        {
            var res = await _generalRepository.FirstOrDefault(id);

            return Success(res);
        }

        [HttpPost]
        public async Task<ActionResult> Update(T entity)
        {
            await _generalRepository.Update(entity);

            return Success("更新成功");
        }

        [HttpPost]
        public async Task<ActionResult> Create(T entity)
        {
            await _generalRepository.Insert(entity);
            
            return NoContent();
        }

        [NonAction]
        public ActionResult Success(object data = null)
        {
            return Ok(new
            {
                Code = 200,
                Data = data
            });
        }

        [NonAction]
        public ActionResult Success(string message = "", object data = null)
        {
            return Ok(new
            {
                Code = 200,
                Message = message,
                Data = data
            });
        }

        [NonAction]
        public ActionResult Fail(string message = "", object data = null)
        {
            return Ok(new
            {
                Code = 400,
                Message = message,
                Data = data
            });
        }

        [NonAction]
        public ActionResult Fail(object data = null)
        {
            return Ok(new
            {
                Code = 400,
                Data = data
            });
        }
    }
}
