﻿using MicroServicesPoC.DomainObject;
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
        public List<MedicoDataDTO> FindAll()
        {

            //    HospitalDO domain = new HospitalDO(); // Buscar patron de diseño singleton / Factory
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
