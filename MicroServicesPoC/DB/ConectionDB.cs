using System;
using System.Collections.Generic;
using System.Linq;
using MicroServicesPoC.DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
namespace MicroServicesPoC.DB
{
    public class ConectionDB
    {
        private  IMongoCollection<HospitalFilterDTO> _hospital;
        private IMongoCollection<MedicoFilterDTO> _medico;
        private IMongoCollection<UsuarioFilterDTO> _usuario;

        public ConectionDB()
        {
            // Lee la instancia del servidor para realizar operaciones de base de datos.
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("hospitalDB");
            _hospital = database.GetCollection<HospitalFilterDTO>("hospitales");
            _medico = database.GetCollection<MedicoFilterDTO>("medicos");
            _usuario = database.GetCollection<UsuarioFilterDTO>("usuarios");
        }

        //Obtener todos los Hospitales
        public List<HospitalFilterDTO> Get()
        {
            return _hospital.Find(hospital => true).ToList();
        }
        //Obtener Hospitales por nombre
        public List<HospitalFilterDTO> FindByFilter(string name)
        {
            
            return _hospital.Find(hospital => hospital.nombre.Contains(name)).ToList();
        }
        //Crear nuevo hospital
        public string FindByFilterP(HospitalFilterDTO filter)
        {
            _hospital.InsertOneAsync(filter);
            
            return "Se inserto";
        }
        //Actualizar hospital
        public string Put(string nombre, HospitalFilterDTO value)
        {
            _hospital.ReplaceOneAsync(updt => updt.nombre == nombre, value);
            return "Se actualizo";
        }
        //Eliminar Hospital
        public string Delete(string nombre)
        {
            _hospital.DeleteOneAsync(hospital => hospital.nombre == nombre);
            return "Elemento eliminado";
        }



        //////////////////////////////////////////////////////////////////////////////////////////

        //Obtener todos los Hospitales
        public List<MedicoFilterDTO> GetMedico()
        {
            return _medico.Find(hospital => true).ToList();
        }
        //Obtener Hospitales por nombre
        public List<MedicoFilterDTO> FindByFilterMedico(string name)
        {

            return _medico.Find(hospital => hospital.nombre.Contains(name)).ToList();
        }
        //Crear nuevo hospital
        public string FindByFilterPMedico(MedicoFilterDTO filter)
        {
            _medico.InsertOneAsync(filter);

            return "Se inserto";
        }
        //Actualizar hospital
        public string PutMedico(string nombre, MedicoFilterDTO value)
        {
            _medico.ReplaceOneAsync(updt => updt.nombre == nombre, value);
            return "Se actualizo";
        }
        //Eliminar Hospital
        public string DeleteMedico(string nombre)
        {
            _medico.DeleteOneAsync(hospital => hospital.nombre == nombre);
            return "Elemento eliminado";
        }

        //////////////////////////////////////////////////////////////////////////////////////////

        //Obtener todos los Usuario
        public List<UsuarioFilterDTO> GetUsuario()
        {
            return _usuario.Find(usuario => true).ToList();
        }
        //Obtener Usuario por nombre
        public List<UsuarioFilterDTO> FindByFilterUsuario(string name)
        {

            return _usuario.Find(usuario => usuario.nombre.Contains(name)).ToList();
        }
        //Crear nuevo Usuario
        public string FindByFilterPUsuario(UsuarioFilterDTO filter)
        {
            _usuario.InsertOneAsync(filter);

            return "Se inserto";
        }
        //Actualizar Usuario
        public string PutUsuario(string nombre, UsuarioFilterDTO value)
        {
            _usuario.ReplaceOneAsync(updt => updt.nombre == nombre, value);
            return "Se actualizo";
        }
        //Eliminar Usuario
        public string DeleteUsuario(string nombre)
        {
            _usuario.DeleteOneAsync(usuario => usuario.nombre == nombre);
            return "Elemento eliminado";
        }


    }
}
