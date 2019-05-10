using MicroServicesPoC.DataAccessObject;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DomainObject
{
    public class HospitalDO
    {
        /// <summary>
        /// Busca por filtro
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private  HospitalDAO _hospitalDO = new HospitalDAO();
        public List<HospitalFilterDTO> FindAll()
        {
           // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _hospitalDO.FindAll();
        }

        public List<HospitalFilterDTO> FindByFilter(string name)
        {
            // Buscar patron de diseño singleton / Factory
            return _hospitalDO.FindByFilter(name);
        }

        public string FindByFilterP(HospitalFilterDTO filter)
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
