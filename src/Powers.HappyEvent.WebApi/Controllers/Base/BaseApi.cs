using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Shared;
using Powers.HappyEvent.Shared.Responses;
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
            if(await _generalRepository.Update(entity))
            {
                return Success("更新成功");
            }
            else
            {
                return Fail("更新失败");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(T entity)
        {
            if(await _generalRepository.Insert(entity))
            {
                return Success("创建成功");
            }
            else
            {
                return Fail("创建失败");
            }                
        }

        [NonAction]
        public ActionResult Success(object data = null)
        {
            return Ok(new ResponseModel
            {
                Code = 200,
                Data = data
            });
        }

        [NonAction]
        public ActionResult Success(string message = "", object data = null)
        {
            return Ok(new ResponseModel
            {
                Code = 200,
                Message = message,
                Data = data
            });
        }

        [NonAction]
        public ActionResult Fail(string message = "", object data = null)
        {
            return Ok(new ResponseModel
            {
                Code = 400,
                Message = message,
                Data = data
            });
        }

        [NonAction]
        public ActionResult Fail(object data = null)
        {
            return Ok(new ResponseModel
            {
                Code = 400,
                Data = data
            });
        }
    }
}
