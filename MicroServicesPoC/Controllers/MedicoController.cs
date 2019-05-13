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
        public ActionResult<List<MedicoFilterDTO>> Get()
        {

            return _medicoMgr.FindAll();
        }


        [HttpGet("{name}")]
        public ActionResult<List<MedicoFilterDTO>> FindByFilter(string name)//[FromBody] HospitalFilterDTO filter)
        {


            return _medicoMgr.FindByFilter(name);
        }


        //[Route("FindByFilter")]
        [HttpPost]
        public ActionResult<string> FindByFilterP([FromBody] MedicoFilterDTO filter)
        {
            var result = _medicoMgr.FindByFilterP(filter);
            return result;
        }

        [HttpPut("{nombre}")]
        public string Put(string nombre, [FromBody] MedicoFilterDTO value)
        {
            return _medicoMgr.Put(nombre, value);
        }

        [HttpDelete("{nombre}")]
        public string Delete(string nombre)
        {
            return _medicoMgr.Delete(nombre);

        }

    }
}
