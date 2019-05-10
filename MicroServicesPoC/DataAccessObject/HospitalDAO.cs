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

        public List<HospitalFilterDTO> FindAll()
        {
            return _hospitalBD.Get().ToList();
        }

        public List<HospitalFilterDTO> FindByFilter(string name)
        {
            HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _hospitalBD.FindByFilter(name);
        }


        public string FindByFilterP(HospitalFilterDTO filter)
        {

            var result = _hospitalBD.FindByFilterP(filter);
            return result;
        }

        public string Put(string nombre, HospitalFilterDTO value)
        {
            return _hospitalBD.Put(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _hospitalBD.Delete(nombre);
        }
    }
}
