using MicroServicesPoC.DB;
using MicroServicesPoC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DataAccessObject
{
    public class UsuarioDAO
    {
        /// <summary>
        /// Busca por filtro
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>

        private ConectionDB _usuarioBD = new ConectionDB();

        public List<UsuarioDataDTO> FindAll()
        {
            return _usuarioBD.GetUsuario().ToList();
        }

        public List<UsuarioDataDTO> FindByFilter(string name)
        {
            HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _usuarioBD.FindByFilterUsuario(name);
        }


        public string FindByFilterP(UsuarioDataDTO filter)
        {

            var result = _usuarioBD.FindByFilterPUsuario(filter);
            return result;
        }

        public string Put(string _id, UsuarioDataDTO value)
        {
            return _usuarioBD.PutUsuario(_id, value);
        }

        public string Delete(string nombre)
        {
            return _usuarioBD.DeleteUsuario(nombre);
        }
    }
}
