using MicroServicesPoC.DomainObject;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.Manager
{
    public class UsuarioMgr
    {
        private UsuarioDO _usuarioDO = new UsuarioDO();

        public List<UsuarioDataDTO> FindAll()
        {

            //    HospitalDO domain = new HospitalDO(); // Buscar patron de diseño singleton / Factory
            return _usuarioDO.FindAll();
        }
        public List<UsuarioDataDTO> FindByFilter(string _id)
        {

            // Buscar patron de diseño singleton / Factory
            return _usuarioDO.FindByFilter(_id);
        }

        public string FindByFilterP(UsuarioDataDTO filter)
        {

            var result = _usuarioDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string _id, UsuarioDataDTO value)
        {
            return _usuarioDO.Put(_id, value);
        }

        public string Delete(string _id)
        {
            return _usuarioDO.Delete(_id);
        }
    }
}
