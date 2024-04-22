using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("AgendsPropertys")]
    public class AgendsPropertys
    {
        
        public int? AgendId { get; set; }  
        public Agends? Agends { get; set; }
        public int Propertyid{ get; set; }

        public Propertys Propertys{ get; set; }
    }
}