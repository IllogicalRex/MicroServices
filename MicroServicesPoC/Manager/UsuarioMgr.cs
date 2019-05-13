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

        public List<UsuarioFilterDTO> FindAll()
        {

            //    HospitalDO domain = new HospitalDO(); // Buscar patron de diseño singleton / Factory
            return _usuarioDO.FindAll();
        }
        public List<UsuarioFilterDTO> FindByFilter(string name)
        {

            // Buscar patron de diseño singleton / Factory
            return _usuarioDO.FindByFilter(name);
        }

        public string FindByFilterP(UsuarioFilterDTO filter)
        {

            var result = _usuarioDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string nombre, UsuarioFilterDTO value)
        {
            return _usuarioDO.Put(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _usuarioDO.Delete(nombre);
        }
    }
}
