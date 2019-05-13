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
        public List<HospitalDataDTO> FindAll()
        {
           // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _hospitalDO.FindAll();
        }

        public List<HospitalDataDTO> FindByFilter(string _id)
        {
            // Buscar patron de diseño singleton / Factory
            return _hospitalDO.FindByFilter(_id);
        }

        public string FindByFilterP(HospitalDataDTO filter)
        {

            var result = _hospitalDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string _id, HospitalDataDTO value)
        {
            return _hospitalDO.Put(_id, value);
        }

        public string Delete(string _id)
        {
            return _hospitalDO.Delete(_id);
        }
    }
}
