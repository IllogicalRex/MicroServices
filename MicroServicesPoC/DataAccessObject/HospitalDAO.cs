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

        public List<HospitalDataDTO> FindByFilter(HospitalFilterDTO filter)
        {
           
            List<HospitalDataDTO> result = new List<HospitalDataDTO>();
            for (int i = 0; i < 5; i++)
            {
               
                

                //var element = new HospitalDataDTO(filter);
                //element.nombre = lista.nombre;
                //element.Phone = (11180000 + i).ToString();
                //result.Add(element);
            }

           
            return result;
        }
    }
}
