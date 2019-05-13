using MicroServicesPoC.DomainObject;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.Manager
{
    public class MedicoMgr
    {
        private MedicoDO _medicoDO = new MedicoDO();
        public List<MedicoFilterDTO> FindAll()
        {

            //    HospitalDO domain = new HospitalDO(); // Buscar patron de diseño singleton / Factory
            return _medicoDO.FindAll();
        }
        public List<MedicoFilterDTO> FindByFilter(string name)
        {

            // Buscar patron de diseño singleton / Factory
            return _medicoDO.FindByFilter(name);
        }

        public string FindByFilterP(MedicoFilterDTO filter)
        {

            var result = _medicoDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string nombre, MedicoFilterDTO value)
        {
            return _medicoDO.Put(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _medicoDO.Delete(nombre);
        }
    }
}
