using MicroServicesPoC.DTO;
using MicroServicesPoC.Manager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController: ControllerBase
    {
        private MedicoMgr _medicoMgr = new MedicoMgr();


        // GET api/values
        [HttpGet]
        public ActionResult<List<MedicoDataDTO>> Get()
        {

            return _medicoMgr.FindAll();
        }


        [HttpGet("{_id}")]
        public ActionResult<List<MedicoDataDTO>> FindByFilter(string _id)//[FromBody] HospitalFilterDTO filter)
        {


            return _medicoMgr.FindByFilter(_id);
        }


        //[Route("FindByFilter")]
        [HttpPost]
        public ActionResult<string> FindByFilterP([FromBody] MedicoDataDTO filter)
        {
            var result = _medicoMgr.FindByFilterP(filter);
            return result;
        }

        [HttpPut("{_id}")]
        public string Put(string _id, [FromBody] MedicoDataDTO value)
        {
            return _medicoMgr.Put(_id, value);
        }

        [HttpDelete("{_id}")]
        public string Delete(string _id)
        {
            return _medicoMgr.Delete(_id);

        }

    }
}
