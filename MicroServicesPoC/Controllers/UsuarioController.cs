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
        public class UsuarioController : ControllerBase
        {

            private UsuarioMgr _usuarioMgr = new UsuarioMgr();


            // GET api/values
            [HttpGet]
            public ActionResult<List<UsuarioDataDTO>> Get()
            {

                return _usuarioMgr.FindAll();
            }


            [HttpGet("{_id}")]
            public ActionResult<List<UsuarioDataDTO>> FindByFilter(string _id)//[FromBody] HospitalFilterDTO filter)
            {


                return _usuarioMgr.FindByFilter(_id);
            }


            //[Route("FindByFilter")]
            [HttpPost]
            public ActionResult<string> FindByFilterP([FromBody] UsuarioDataDTO filter)
            {
                var result = _usuarioMgr.FindByFilterP(filter);
                return result;
            }

            [HttpPut("{_id}")]
            public string Put(string _id, [FromBody] UsuarioDataDTO value)
            {
                return _usuarioMgr.Put(_id, value);
            }

            [HttpDelete("{_id}")]
            public string Delete(string _id)
            {
                return _usuarioMgr.Delete(_id);

            }
        }
    }

