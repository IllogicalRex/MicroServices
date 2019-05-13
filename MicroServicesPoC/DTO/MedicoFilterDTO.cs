using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DTO
{
    [BsonIgnoreExtraElements]
    public class MedicoFilterDTO
    {
        public string nombre { get; set; }
        public object usuario { get; set; }
        public object hospital { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class MedicoDataDTO : MedicoFilterDTO
    {

        public string nombre { get; set; }
        public object usuario { get; set; }
        public object hospital { get; set; }
        /// <summary>
        /// Constructor a partir de ul filtro
        /// </summary>
        /// <param name="filter"></param>
        public MedicoDataDTO(MedicoFilterDTO filter)
        {
            nombre = filter.nombre;
            usuario = filter.usuario;
            hospital = filter.hospital;

        }



    }
}
