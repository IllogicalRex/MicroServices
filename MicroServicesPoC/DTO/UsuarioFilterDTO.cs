using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DTO
{
    [BsonIgnoreExtraElements]
    public class UsuarioFilterDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
       
        
    }
    [BsonIgnoreExtraElements]
    public class UsuarioDataDTO: UsuarioFilterDTO
    {
        public string role { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        //public UsuarioDataDTO(UsuarioFilterDTO filter)
        //{
        //    this.nombre = filter.nombre;
        //    this.email = filter.email;
        //    this.password = filter.password;
        //    this.role = filter.role;
        //}
    }
}
