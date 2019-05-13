using MicroServicesPoC.DB;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DataAccessObject
{
    public class MedicoDAO
    {
        private ConectionDB _MedicoBD = new ConectionDB();

        public List<MedicoDataDTO> FindAll()
        {
            return _MedicoBD.GetMedico().ToList();
        }

        public List<MedicoDataDTO> FindByFilter(string _id)
        {
           // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _MedicoBD.FindByFilterMedico(_id);
        }


        public string FindByFilterP(MedicoDataDTO filter)
        {

            var result = _MedicoBD.FindByFilterPMedico(filter);
            return result;
        }

        public string Put(string _id, MedicoDataDTO value)
        {
            return _MedicoBD.PutMedico(_id, value);
        }

        public string Delete(string _id)
        {
            return _MedicoBD.DeleteMedico(_id);
        }
    }
}
