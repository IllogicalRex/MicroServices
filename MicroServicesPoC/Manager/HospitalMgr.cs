using MicroServicesPoC.DomainObject;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.Manager
{
    public class HospitalMgr
    {
        private HospitalDO _hospitalDO = new HospitalDO();
        public List<HospitalFilterDTO> FindAll()
        {

        //    HospitalDO domain = new HospitalDO(); // Buscar patron de diseño singleton / Factory
            return _hospitalDO.FindAll();
        }
        public List<HospitalFilterDTO> FindByFilter(string name)
        {

            // Buscar patron de diseño singleton / Factory
            return _hospitalDO.FindByFilter(name);
        }

        public string FindByFilterP( HospitalFilterDTO filter)
        {

            var result = _hospitalDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string nombre, HospitalFilterDTO value)
        {
            return _hospitalDO.Put(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _hospitalDO.Delete(nombre);
        }
    }
}
