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
        public List<UsuarioDataDTO> FindAll()
        {
            // HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _usuariolDO.FindAll();
        }

        public List<UsuarioDataDTO> FindByFilter(string _id)
        {
            // Buscar patron de diseño singleton / Factory
            return _usuariolDO.FindByFilter(_id);
        }

        public string FindByFilterP(UsuarioDataDTO filter)
        {

            var result = _usuariolDO.FindByFilterP(filter);
            return result;
        }

        public string Put(string _id, UsuarioDataDTO value)
        {
            return _usuariolDO.Put(_id, value);
        }

        public string Delete(string _id)
        {
            return _usuariolDO.Delete(_id);
        }
    }
}
