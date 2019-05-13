using System;
using MicroServicesPoC.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServicesPoC.DB;

namespace MicroServicesPoC.DataAccessObject
{
    public class HospitalDAO
    {
        /// <summary>
        /// Busca por filtro
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>

        private ConectionDB _hospitalBD = new ConectionDB();

        public List<HospitalDataDTO> FindAll()
        {
            return _hospitalBD.Get().ToList();
        }

        public List<HospitalDataDTO> FindByFilter(string _id)
        {
            HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _hospitalBD.FindByFilter(_id);
        }


        public string FindByFilterP(HospitalDataDTO filter)
        {

            var result = _hospitalBD.FindByFilterP(filter);
            return result;
        }

        public string Put(string _id, HospitalDataDTO value)
        {
            return _hospitalBD.Put(_id, value);
        }

        public string Delete(string _id)
        {
            return _hospitalBD.Delete(_id);
        }
    }
}
