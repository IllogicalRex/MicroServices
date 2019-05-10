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
        public ActionResult<List<HospitalFilterDTO>> Get()
        {

            return _hospitalMgr.FindAll();
        }


        [HttpGet("{name}")]
        public ActionResult<List<HospitalFilterDTO>> FindByFilter(string name)//[FromBody] HospitalFilterDTO filter)
        {


            return _hospitalMgr.FindByFilter(name);
        }


        //[Route("FindByFilter")]
        [HttpPost]
        public ActionResult<string> FindByFilterP([FromBody] HospitalFilterDTO filter)
        {
            var result = _hospitalMgr.FindByFilterP(filter);
            return result;
        }

        [HttpPut("{nombre}")]
        public string Put(string nombre, [FromBody] HospitalFilterDTO value)
        {
            return _hospitalMgr.Put(nombre, value);
        }

        [HttpDelete("{nombre}")]
        public string Delete(string nombre)
        {
            return _hospitalMgr.Delete(nombre);

        }

    }
}
