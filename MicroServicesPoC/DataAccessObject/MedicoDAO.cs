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

        public List<MedicoFilterDTO> FindAll()
        {
            return _MedicoBD.GetMedico().ToList();
        }

        public List<MedicoFilterDTO> FindByFilter(string name)
        {
           // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _MedicoBD.FindByFilterMedico(name);
        }


        public string FindByFilterP(MedicoFilterDTO filter)
        {

            var result = _MedicoBD.FindByFilterPMedico(filter);
            return result;
        }

        public string Put(string nombre, MedicoFilterDTO value)
        {
            return _MedicoBD.PutMedico(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _MedicoBD.DeleteMedico(nombre);
        }
    }
}
