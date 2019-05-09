﻿using MicroServicesPoC.DomainObject;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.Manager
{
    public class HospitalMgr
    {
        public List<HospitalDataDTO> FindByFilter(HospitalFilterDTO filter)
        {
            HospitalDO domain = new HospitalDO(); // Buscar patron de diseño singleton / Factory
            return domain.FindByFilter(filter);
        }
    }
}
