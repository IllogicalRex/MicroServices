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

        public ConectionDB()
        {
            // Lee la instancia del servidor para realizar operaciones de base de datos.
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("hospitalDB");
            _hospital = database.GetCollection<HospitalFilterDTO>("hospitales");
        }

        public List<HospitalFilterDTO> Get()
        {
            return _hospital.Find(hospital => true).ToList();
        }

        public List<HospitalFilterDTO> FindByFilter(string name)
        {
            
            return _hospital.Find(hospital => hospital.nombre.Contains(name)).ToList();
        }

        public string FindByFilterP(HospitalFilterDTO filter)
        {
            _hospital.InsertOneAsync(filter);
            
            return "Se inserto";
        }

        public string Put(string nombre, HospitalFilterDTO value)
        {
            //_hospital.UpdateOneAsync(updt => updt.nombre == nombre, upd => upd.nombre, value);
            _hospital.UpdateOneAsync(nombre, value.nombre);
            return "Se actualizo";
        }

        public string Delete(string nombre)
        {
            _hospital.DeleteOneAsync(hospital => hospital.nombre == nombre);
            return "Elemento eliminado";
        }

        //public HospitalFilterDTO Create(HospitalFilterDTO book)
        //{
        //    _hospital.InsertOne(book);
        //    return book;
        //}

        //public void Update(string id, HospitalFilterDTO bookIn)
        //{
        //    _hospital.ReplaceOne(book => book.Id == id, bookIn);
        //}

        //public void Remove(HospitalFilterDTO bookIn)
        //{
        //    _hospital.DeleteOne(book => book.Id == bookIn.Id);
        //}

        //public void Remove(string id)
        //{
        //    _hospital   .DeleteOne(book => book.Id == id);
        //}
    }
}
