using MicroServicesPoC.DataAccessObject;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DomainObject
{
    public class UsuarioDO
    {
        /// <summary>
        /// Busca por filtro
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private UsuarioDAO _usuariolDO = new UsuarioDAO();
        public List<UsuarioFilterDTO> FindAll()
        {
            // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _usuariolDO.FindAll();
        }

        public List<UsuarioFilterDTO> FindByFilter(string name)
        {
            // Buscar patron de diseño singleton / Factory
            return _usuariolDO.FindByFilter(name);
        }

        public string FindByFilterP(UsuarioFilterDTO filter)
        {

            var result = _usuariolDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string nombre, UsuarioFilterDTO value)
        {
            return _usuariolDO.Put(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _usuariolDO.Delete(nombre);
        }
    }
}
