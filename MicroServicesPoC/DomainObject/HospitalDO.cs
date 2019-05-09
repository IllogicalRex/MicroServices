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
        public List<HospitalDataDTO> FindByFilter(HospitalFilterDTO filter)
        {
            HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return dao.FindByFilter(filter);
        }

    }
}
