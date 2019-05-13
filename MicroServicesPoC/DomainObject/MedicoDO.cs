﻿using MicroServicesPoC.DataAccessObject;
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
        public List<MedicoFilterDTO> FindAll()
        {
            // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _medicoDO.FindAll();
        }

        public List<MedicoFilterDTO> FindByFilter(string name)
        {
            // Buscar patron de diseño singleton / Factory
            return _medicoDO.FindByFilter(name);
        }

        public string FindByFilterP(MedicoFilterDTO filter)
        {

            var result = _medicoDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string nombre, MedicoFilterDTO value)
        {
            return _medicoDO.Put(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _medicoDO.Delete(nombre);
        }
    }
}
