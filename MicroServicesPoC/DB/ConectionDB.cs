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
        private readonly IMongoCollection<HospitalFilterDTO> _hospital;

        public ConectionDB(IConfiguration config)
        {
            // Lee la instancia del servidor para realizar operaciones de base de datos.
            var client = new MongoClient(config.GetConnectionString("hospitalDB"));
            var database = client.GetDatabase("hospitalDB");
            _hospital = database.GetCollection<HospitalFilterDTO>("hospitales");
        }

        public List<HospitalFilterDTO> Get()
        {
            return _hospital.Find(hospital => true).ToList();
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
