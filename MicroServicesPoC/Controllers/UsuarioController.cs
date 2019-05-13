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
            public ActionResult<List<UsuarioFilterDTO>> Get()
            {

                return _usuarioMgr.FindAll();
            }


            [HttpGet("{name}")]
            public ActionResult<List<UsuarioFilterDTO>> FindByFilter(string name)//[FromBody] HospitalFilterDTO filter)
            {


                return _usuarioMgr.FindByFilter(name);
            }


            //[Route("FindByFilter")]
            [HttpPost]
            public ActionResult<string> FindByFilterP([FromBody] UsuarioFilterDTO filter)
            {
                var result = _usuarioMgr.FindByFilterP(filter);
                return result;
            }

            [HttpPut("{nombre}")]
            public string Put(string nombre, [FromBody] UsuarioFilterDTO value)
            {
                return _usuarioMgr.Put(nombre, value);
            }

            [HttpDelete("{nombre}")]
            public string Delete(string nombre)
            {
                return _usuarioMgr.Delete(nombre);

            }
        }
    }

