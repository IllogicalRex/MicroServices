using MicroServicesPoC.DataAccessObject;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DomainObject
{
    public class MedicoDO
    {
        /// <summary>
        /// Busca por filtro
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private MedicoDAO _medicoDO = new MedicoDAO();
        public List<MedicoDataDTO> FindAll()
        {
            // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _medicoDO.FindAll();
        }

        public List<MedicoDataDTO> FindByFilter(string _id)
        {
            // Buscar patron de diseño singleton / Factory
            return _medicoDO.FindByFilter(_id);
        }

        public string FindByFilterP(MedicoDataDTO filter)
        {

            var result = _medicoDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string _id, MedicoDataDTO value)
        {
            return _medicoDO.Put(_id, value);
        }

        public string Delete(string _id)
        {
            return _medicoDO.Delete(_id);
        }
    }
}
