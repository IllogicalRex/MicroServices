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

        [Route("FindByFilter")]
        [HttpPost]
        public ActionResult<List<HospitalDataDTO>> FindByFilter([FromBody] HospitalFilterDTO filter)
        {
            HospitalMgr manager = new HospitalMgr();
            var result = manager.FindByFilter(filter);
            return result;
        }

    }
}
