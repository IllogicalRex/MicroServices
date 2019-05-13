using MicroServicesPoC.DB;
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
    public class HospitalController : ControllerBase
    {

        private HospitalMgr _hospitalMgr = new HospitalMgr();


        // GET api/values
        [HttpGet]
        public ActionResult<List<HospitalDataDTO>> Get()
        {

            return _hospitalMgr.FindAll();
        }


        [HttpGet("{_id}")]
        public ActionResult<List<HospitalDataDTO>> FindByFilter(string _id)//[FromBody] HospitalFilterDTO filter)
        {

            return _hospitalMgr.FindByFilter(_id);
        }


        //[Route("FindByFilter")]
        [HttpPost]
        public ActionResult<string> FindByFilterP([FromBody] HospitalDataDTO filter)
        {
            var result = _hospitalMgr.FindByFilterP(filter);
            return result;
        }

        [HttpPut("{_id}")]
        public string Put(string _id, [FromBody] HospitalDataDTO value)
        {
            return _hospitalMgr.Put(_id, value);
        }

        [HttpDelete("{_id}")]
        public string Delete(string _id)
        {
            return _hospitalMgr.Delete(_id);

        }

    }
}
