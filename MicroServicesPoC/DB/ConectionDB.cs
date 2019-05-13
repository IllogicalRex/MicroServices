using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using MicroServicesPoC.DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
namespace MicroServicesPoC.DB
{
    public class ConectionDB
    {
        private  IMongoCollection<HospitalDataDTO> _hospital;
        private IMongoCollection<MedicoDataDTO> _medico;
        private IMongoCollection<UsuarioDataDTO> _usuario;

        public ConectionDB()
        {
            // Lee la instancia del servidor para realizar operaciones de base de datos.
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("hospitalDB");
            _hospital = database.GetCollection<HospitalDataDTO>("hospitales");
            _medico = database.GetCollection<MedicoDataDTO>("medicos");
            _usuario = database.GetCollection<UsuarioDataDTO>("usuarios");
        }

        //Obtener todos los Hospitales
        public List<HospitalDataDTO> Get()
        {
            return _hospital.Find(hospital => true).ToList();
        }
        //Obtener Hospitales por nombre
        public List<HospitalDataDTO> FindByFilter(string _id)
        {
            
            return _hospital.Find(hospital => hospital._id.Equals(_id)).ToList();
        }
        //Crear nuevo hospital
        public string FindByFilterP(HospitalDataDTO filter)
        {
            _hospital.InsertOneAsync(filter);
            
            return String.Concat("Se inserto el Hospital ", filter.nombre);
        }
        //Actualizar hospital
        public string Put(string _id, HospitalDataDTO value)
        {
            _hospital.ReplaceOneAsync(updt => updt._id.Equals(_id), value);
            return String.Concat("Se Actualizo el Hospital con id: ", _id);
        }
        //Eliminar Hospital
        public string Delete(string _id)
        {
            _hospital.DeleteOneAsync(hospital => hospital._id == _id);
            return String.Concat("Se Elimino el Hospital con id: ", _id);
        }



        //////////////////////////////////////////////////////////////////////////////////////////

        //Obtener todos los Medicos
        public List<MedicoDataDTO> GetMedico()
        {
            return _medico.Find(hospital => true).ToList();
        }
        //Obtener Medico por nombre
        public List<MedicoDataDTO> FindByFilterMedico(string _id)
        {

            return _medico.Find(medico => medico._id.Equals(_id)).ToList();
        }
        //Crear nuevo Medico
        public string FindByFilterPMedico(MedicoDataDTO filter)
        {
            _medico.InsertOneAsync(filter);

            return "Se inserto";
        }
        //Actualizar Medico
        public string PutMedico(string _id, MedicoDataDTO value)
        {
            _medico.ReplaceOneAsync(updt => updt._id == _id, value);
            return "Se actualizo";
        }
        //Eliminar Medico
        public string DeleteMedico(string _id)
        {
            _medico.DeleteOneAsync(hospital => hospital._id == _id);
            return "Elemento eliminado";
        }

        //////////////////////////////////////////////////////////////////////////////////////////

        //Obtener todos los Usuario
        public List<UsuarioDataDTO> GetUsuario()
        {
            return _usuario.Find(usuario => true).ToList();
        }
        //Obtener Usuario por nombre
        public List<UsuarioDataDTO> FindByFilterUsuario(string _id)
        {

            return _usuario.Find(usuario => usuario._id.Equals(_id)).ToList();
        }
        //Crear nuevo Usuario
        public string FindByFilterPUsuario(UsuarioDataDTO filter)
        {
            _usuario.InsertOneAsync(filter);

            return "Se inserto";
        }
        //Actualizar Usuario
        public string PutUsuario(string _id, UsuarioDataDTO value)
        {
            _usuario.ReplaceOneAsync(updt => updt._id.Equals(_id), value);
            return "Se actualizo";
        }
        //Eliminar Usuario
        public string DeleteUsuario(string _id)
        {
            _usuario.DeleteOneAsync(usuario => usuario._id.Equals(_id));
            return "Elemento eliminado";
        }


    }
}
