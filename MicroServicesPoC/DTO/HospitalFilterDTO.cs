using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesPoC.DTO
{
    /// <summary>
    /// Dto para filtro
    /// </summary>
    [BsonIgnoreExtraElements]
    public class HospitalFilterDTO
    {
        /// <summary>
        /// Nombre del hospital
        /// </summary>
        public string nombre { get; set; }
        public object usuario { get; set; }
    }

    /// <summary>
    /// DTO de respuesta
    /// </summary>
    [BsonIgnoreExtraElements]
    public class HospitalDataDTO : HospitalFilterDTO
    {

        public string nombre { get; set; }
        public object usuario { get; set; }
        /// <summary>
        /// Constructor a partir de ul filtro
        /// </summary>
        /// <param name="filter"></param>
        public HospitalDataDTO(HospitalFilterDTO filter)
        {
            nombre = filter.nombre;
            usuario = filter.usuario;
            
        }
       
        
        
    }
}
