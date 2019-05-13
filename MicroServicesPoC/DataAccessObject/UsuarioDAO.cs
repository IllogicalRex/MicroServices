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

        public List<UsuarioFilterDTO> FindAll()
        {
            return _usuarioBD.GetUsuario().ToList();
        }

        public List<UsuarioFilterDTO> FindByFilter(string name)
        {
            HospitalDAO dao = new HospitalDAO(); // Buscar patron de diseño singleton / Factory
            return _usuarioBD.FindByFilterUsuario(name);
        }


        public string FindByFilterP(UsuarioFilterDTO filter)
        {

            var result = _usuarioBD.FindByFilterPUsuario(filter);
            return result;
        }

        public string Put(string nombre, UsuarioFilterDTO value)
        {
            return _usuarioBD.PutUsuario(nombre, value);
        }

        public string Delete(string nombre)
        {
            return _usuarioBD.DeleteUsuario(nombre);
        }
    }
}
